namespace dnsChanger
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.adaptorsComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.connectButton = new MaterialSkin.Controls.MaterialButton();
            this.pingButton = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.dnsComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.clearSwitch = new MaterialSkin.Controls.MaterialSwitch();
            this.adaptorStatusLabel = new MaterialSkin.Controls.MaterialLabel();
            this.dnsPingLabel = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // adaptorsComboBox
            // 
            this.adaptorsComboBox.AutoResize = false;
            this.adaptorsComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.adaptorsComboBox.Depth = 0;
            this.adaptorsComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.adaptorsComboBox.DropDownHeight = 174;
            this.adaptorsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.adaptorsComboBox.DropDownWidth = 121;
            this.adaptorsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.adaptorsComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.adaptorsComboBox.FormattingEnabled = true;
            this.adaptorsComboBox.IntegralHeight = false;
            this.adaptorsComboBox.ItemHeight = 43;
            this.adaptorsComboBox.Location = new System.Drawing.Point(117, 79);
            this.adaptorsComboBox.MaxDropDownItems = 4;
            this.adaptorsComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.adaptorsComboBox.Name = "adaptorsComboBox";
            this.adaptorsComboBox.Size = new System.Drawing.Size(243, 49);
            this.adaptorsComboBox.StartIndex = 0;
            this.adaptorsComboBox.TabIndex = 0;
            this.adaptorsComboBox.SelectedIndexChanged += new System.EventHandler(this.adaptorsComboBox_SelectedIndexChanged);
            // 
            // connectButton
            // 
            this.connectButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.connectButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.connectButton.Depth = 0;
            this.connectButton.HighEmphasis = true;
            this.connectButton.Icon = null;
            this.connectButton.Location = new System.Drawing.Point(24, 283);
            this.connectButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.connectButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.connectButton.Name = "connectButton";
            this.connectButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.connectButton.Size = new System.Drawing.Size(64, 36);
            this.connectButton.TabIndex = 1;
            this.connectButton.Text = "SET";
            this.connectButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.connectButton.UseAccentColor = false;
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // pingButton
            // 
            this.pingButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pingButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.pingButton.Depth = 0;
            this.pingButton.HighEmphasis = true;
            this.pingButton.Icon = null;
            this.pingButton.Location = new System.Drawing.Point(407, 283);
            this.pingButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.pingButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.pingButton.Name = "pingButton";
            this.pingButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.pingButton.Size = new System.Drawing.Size(64, 36);
            this.pingButton.TabIndex = 2;
            this.pingButton.Text = "ping";
            this.pingButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.pingButton.UseAccentColor = false;
            this.pingButton.UseVisualStyleBackColor = true;
            this.pingButton.Click += new System.EventHandler(this.pingButton_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(34, 96);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(57, 19);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Adaptor";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(45, 163);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(33, 19);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "DNS";
            // 
            // dnsComboBox
            // 
            this.dnsComboBox.AutoResize = false;
            this.dnsComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dnsComboBox.Depth = 0;
            this.dnsComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.dnsComboBox.DropDownHeight = 174;
            this.dnsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dnsComboBox.DropDownWidth = 121;
            this.dnsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.dnsComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dnsComboBox.FormattingEnabled = true;
            this.dnsComboBox.IntegralHeight = false;
            this.dnsComboBox.ItemHeight = 43;
            this.dnsComboBox.Location = new System.Drawing.Point(117, 148);
            this.dnsComboBox.MaxDropDownItems = 4;
            this.dnsComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.dnsComboBox.Name = "dnsComboBox";
            this.dnsComboBox.Size = new System.Drawing.Size(243, 49);
            this.dnsComboBox.StartIndex = 0;
            this.dnsComboBox.TabIndex = 6;
            // 
            // clearSwitch
            // 
            this.clearSwitch.AutoSize = true;
            this.clearSwitch.Depth = 0;
            this.clearSwitch.Location = new System.Drawing.Point(24, 227);
            this.clearSwitch.Margin = new System.Windows.Forms.Padding(0);
            this.clearSwitch.MouseLocation = new System.Drawing.Point(-1, -1);
            this.clearSwitch.MouseState = MaterialSkin.MouseState.HOVER;
            this.clearSwitch.Name = "clearSwitch";
            this.clearSwitch.Ripple = true;
            this.clearSwitch.Size = new System.Drawing.Size(173, 37);
            this.clearSwitch.TabIndex = 7;
            this.clearSwitch.Text = "clear dns on exit";
            this.clearSwitch.UseVisualStyleBackColor = true;
            // 
            // adaptorStatusLabel
            // 
            this.adaptorStatusLabel.AutoSize = true;
            this.adaptorStatusLabel.Depth = 0;
            this.adaptorStatusLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.adaptorStatusLabel.Location = new System.Drawing.Point(383, 96);
            this.adaptorStatusLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.adaptorStatusLabel.Name = "adaptorStatusLabel";
            this.adaptorStatusLabel.Size = new System.Drawing.Size(66, 19);
            this.adaptorStatusLabel.TabIndex = 8;
            this.adaptorStatusLabel.Text = "unknown";
            // 
            // dnsPingLabel
            // 
            this.dnsPingLabel.AutoSize = true;
            this.dnsPingLabel.Depth = 0;
            this.dnsPingLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dnsPingLabel.Location = new System.Drawing.Point(383, 163);
            this.dnsPingLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.dnsPingLabel.Name = "dnsPingLabel";
            this.dnsPingLabel.Size = new System.Drawing.Size(44, 19);
            this.dnsPingLabel.TabIndex = 9;
            this.dnsPingLabel.Text = "ping: -";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 335);
            this.Controls.Add(this.dnsPingLabel);
            this.Controls.Add(this.adaptorStatusLabel);
            this.Controls.Add(this.clearSwitch);
            this.Controls.Add(this.dnsComboBox);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.pingButton);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.adaptorsComboBox);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DNS changer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialComboBox adaptorsComboBox;
        private MaterialSkin.Controls.MaterialButton connectButton;
        private MaterialSkin.Controls.MaterialButton pingButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialComboBox dnsComboBox;
        private MaterialSkin.Controls.MaterialSwitch clearSwitch;
        private MaterialSkin.Controls.MaterialLabel adaptorStatusLabel;
        private MaterialSkin.Controls.MaterialLabel dnsPingLabel;
    }
}

