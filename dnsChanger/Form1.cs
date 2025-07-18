using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dnsChanger
{
    public partial class Form1 : MaterialForm
    {
        private Dictionary<string, (string primary, string secondary)> dnsServers;

        private void RunNetshCommand(string arguments)
        {
            var psi = new System.Diagnostics.ProcessStartInfo
            {
                FileName = "netsh",
                Arguments = arguments,
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true
            };

            using (var process = System.Diagnostics.Process.Start(psi))
            {
                process.WaitForExit();
                // Optional: read output or log errors
                // string output = process.StandardOutput.ReadToEnd();
                // string error = process.StandardError.ReadToEnd();
            }
        }


        private void SetDns(string adapterName, string primary, string secondary)
        {
            try
            {
                // Clear existing DNS
                RunNetshCommand($"interface ip set dns name=\"{adapterName}\" source=dhcp");

                if (!string.IsNullOrWhiteSpace(primary))
                    RunNetshCommand($"interface ip set dns name=\"{adapterName}\" static {primary}");

                if (!string.IsNullOrWhiteSpace(secondary))
                    RunNetshCommand($"interface ip add dns name=\"{adapterName}\" {secondary} index=2");

                MessageBox.Show("DNS successfully updated.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to set DNS:\n{ex.Message}");
            }
        }

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            this.FormClosing += Form1_FormClosing;


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pingButton.Click += pingButton_Click;
            adaptorsComboBox.SelectedIndexChanged += adaptorsComboBox_SelectedIndexChanged;

            // Get all network interfaces
            var adapters = NetworkInterface.GetAllNetworkInterfaces()
                .Where(ni =>
                    ni.NetworkInterfaceType != NetworkInterfaceType.Loopback &&
                    ni.OperationalStatus == OperationalStatus.Up)
                .ToList();

            // Clear and populate the combo box
            adaptorsComboBox.Items.Clear();
            foreach (var adapter in adapters)
            {
                adaptorsComboBox.Items.Add(adapter.Name);
            }

            if (adaptorsComboBox.Items.Count > 0)
            {
                adaptorsComboBox.SelectedIndex = 0;
            }

            dnsServers = new Dictionary<string, (string primary, string secondary)>
            {
                { "Automatic (DHCP)", ("", "") },
                { "Google", ("8.8.8.8", "8.8.4.4") },
                { "Cloudflare", ("1.1.1.1", "1.0.0.1") },
                { "Quad9", ("9.9.9.9", "149.112.112.112") },
                { "OpenDNS", ("208.67.222.222", "208.67.220.220") },
                { "AdGuard", ("94.140.14.14", "94.140.15.15") },
                { "Shecan", ("178.22.122.100", "185.51.200.2") },
                { "Electro DNS", ("78.157.42.100", "78.157.42.101") },
                { "RadarGame", ("10.202.10.10", "10.202.10.11") },
                { "403.online", ("10.202.10.202", "10.202.10.102") },
            };

            // Populate the combo box with names
            dnsComboBox.Items.Clear();
            foreach (var name in dnsServers.Keys)
            {
                dnsComboBox.Items.Add(name);
            }

            dnsComboBox.SelectedIndex = 0;

        }

        private void adaptorsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Optional: Show "Checking..." while working
            adaptorStatusLabel.Text = "Checking...";
            adaptorStatusLabel.ForeColor = Color.Gray;

            // Ping a reliable address (e.g., Google DNS)
            bool isOnline = false;
            try
            {
                using (Ping ping = new Ping())
                {
                    PingReply reply = ping.Send("8.8.8.8", 1000); // 1 second timeout
                    if (reply.Status == IPStatus.Success)
                    {
                        isOnline = true;
                    }
                }
            }
            catch
            {
                isOnline = false;
            }

            // Update label based on result
            if (isOnline)
            {
                adaptorStatusLabel.Text = "Online";
                adaptorStatusLabel.ForeColor = Color.Green;
            }
            else
            {
                adaptorStatusLabel.Text = "Offline";
                adaptorStatusLabel.ForeColor = Color.Red;
            }

        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            string adapter = adaptorsComboBox.SelectedItem?.ToString();
            string dnsName = dnsComboBox.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(adapter) || string.IsNullOrEmpty(dnsName))
            {
                MessageBox.Show("Please select both adapter and DNS.");
                return;
            }

            var (primary, secondary) = dnsServers[dnsName];
            SetDns(adapter, primary, secondary);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (clearSwitch.Checked)
            {
                string adapter = adaptorsComboBox.SelectedItem?.ToString();
                if (!string.IsNullOrEmpty(adapter))
                {
                    try
                    {
                        // Reset DNS to automatic (DHCP)
                        RunNetshCommand($"interface ip set dns name=\"{adapter}\" source=dhcp");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Failed to clear DNS:\n{ex.Message}");
                    }
                }
            }
        }

        private void pingButton_Click(object sender, EventArgs e)
        {
            string dnsName = dnsComboBox.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(dnsName) || !dnsServers.ContainsKey(dnsName))
            {
                dnsPingLabel.Text = "Invalid DNS selection";
                dnsPingLabel.ForeColor = Color.Gray;
                return;
            }

            var (primary, _) = dnsServers[dnsName];
            if (string.IsNullOrWhiteSpace(primary))
            {
                dnsPingLabel.Text = "No DNS IP to ping";
                dnsPingLabel.ForeColor = Color.Gray;
                return;
            }

            try
            {
                using (var ping = new Ping())
                {
                    var reply = ping.Send(primary, 1000); // 1 sec timeout
                    if (reply.Status == IPStatus.Success)
                    {
                        dnsPingLabel.Text = $"Ping: {reply.RoundtripTime} ms";
                        dnsPingLabel.ForeColor = Color.Green;
                    }
                    else
                    {
                        dnsPingLabel.Text = "Unreachable";
                        dnsPingLabel.ForeColor = Color.Red;
                    }
                }
            }
            catch
            {
                dnsPingLabel.Text = "Ping failed";
                dnsPingLabel.ForeColor = Color.Red;
            }
        }
    }
}
