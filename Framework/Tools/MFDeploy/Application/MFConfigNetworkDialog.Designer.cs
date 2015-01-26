namespace Microsoft.NetMicroFramework.Tools.MFDeployTool
{
    partial class MFNetworkConfigDialog
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
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxNetKey = new System.Windows.Forms.ComboBox();
            this.checkBox80211n = new System.Windows.Forms.CheckBox();
            this.checkBox80211g = new System.Windows.Forms.CheckBox();
            this.checkBox80211b = new System.Windows.Forms.CheckBox();
            this.checkBox80211a = new System.Windows.Forms.CheckBox();
            this.checkBoxEncryptConfigData = new System.Windows.Forms.CheckBox();
            this.comboBoxEncryption = new System.Windows.Forms.ComboBox();
            this.comboBoxAuthentication = new System.Windows.Forms.ComboBox();
            this.textBoxSSID = new System.Windows.Forms.TextBox();
            this.labelSSID = new System.Windows.Forms.Label();
            this.textBoxReKeyInternal = new System.Windows.Forms.TextBox();
            this.labelReKeyInternal = new System.Windows.Forms.Label();
            this.textBoxNetworkKey = new System.Windows.Forms.TextBox();
            this.labelNetworkKey = new System.Windows.Forms.Label();
            this.textBoxPassPhrase = new System.Windows.Forms.TextBox();
            this.labelPassPhrase = new System.Windows.Forms.Label();
            this.labelRadio = new System.Windows.Forms.Label();
            this.labelEncryption = new System.Windows.Forms.Label();
            this.labelAuthentication = new System.Windows.Forms.Label();
            this.tabControlIPSettings = new System.Windows.Forms.TabControl();
            this.tabPageIPv4 = new System.Windows.Forms.TabPage();
            this.panelIPv4DnsAddressesSettings = new System.Windows.Forms.Panel();
            this.radioButtonIPv4DnsAddressesStatic = new System.Windows.Forms.RadioButton();
            this.groupBoxIPv4DnsAddressesStatic = new System.Windows.Forms.GroupBox();
            this.textBoxIPv4DnsSecondary = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIPv4DnsPrimary = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonIPv4DnsAddressesDynamic = new System.Windows.Forms.RadioButton();
            this.panelIPv4IPAddressSettings = new System.Windows.Forms.Panel();
            this.radioButtonIPv4IPAddressStatic = new System.Windows.Forms.RadioButton();
            this.groupBoxIPv4AddressStatic = new System.Windows.Forms.GroupBox();
            this.textBoxIPv4DefaultGateway = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxIPv4SubnetMask = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxIPv4IPAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButtonIPv4IPAddressDynamic = new System.Windows.Forms.RadioButton();
            this.tabPageIPv6 = new System.Windows.Forms.TabPage();
            this.panelIPv6DnsAddressesSettings = new System.Windows.Forms.Panel();
            this.radioButtonIPv6DnsAddressesStatic = new System.Windows.Forms.RadioButton();
            this.groupBoxIPv6DnsAddressesStatic = new System.Windows.Forms.GroupBox();
            this.textBoxIPv6DnsSecondary = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxIPv6DnsPrimary = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.radioButtonIPv6DnsAddressesDynamic = new System.Windows.Forms.RadioButton();
            this.panelIPv6IPAddressSettings = new System.Windows.Forms.Panel();
            this.radioButtonIPv6IPAddressStatic = new System.Windows.Forms.RadioButton();
            this.groupBoxIPv6AddressStatic = new System.Windows.Forms.GroupBox();
            this.textBoxIPv6DefaultGateway = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxIPv6SubnetPrefixLength = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxIPv6IPAddress = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.radioButtonIPv6IPAddressDynamic = new System.Windows.Forms.RadioButton();
            this.textBoxMACAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.tabControlIPSettings.SuspendLayout();
            this.tabPageIPv4.SuspendLayout();
            this.panelIPv4DnsAddressesSettings.SuspendLayout();
            this.groupBoxIPv4DnsAddressesStatic.SuspendLayout();
            this.panelIPv4IPAddressSettings.SuspendLayout();
            this.groupBoxIPv4AddressStatic.SuspendLayout();
            this.tabPageIPv6.SuspendLayout();
            this.panelIPv6DnsAddressesSettings.SuspendLayout();
            this.groupBoxIPv6DnsAddressesStatic.SuspendLayout();
            this.panelIPv6IPAddressSettings.SuspendLayout();
            this.groupBoxIPv6AddressStatic.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUpdate.Location = new System.Drawing.Point(221, 644);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 36;
            this.buttonUpdate.Text = global::Microsoft.NetMicroFramework.Tools.MFDeployTool.Properties.Resources.ButtonUpdate;
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(302, 644);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 37;
            this.buttonCancel.Text = global::Microsoft.NetMicroFramework.Tools.MFDeployTool.Properties.Resources.ButtonCancel;
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.comboBoxNetKey);
            this.groupBox1.Controls.Add(this.checkBox80211n);
            this.groupBox1.Controls.Add(this.checkBox80211g);
            this.groupBox1.Controls.Add(this.checkBox80211b);
            this.groupBox1.Controls.Add(this.checkBox80211a);
            this.groupBox1.Controls.Add(this.checkBoxEncryptConfigData);
            this.groupBox1.Controls.Add(this.comboBoxEncryption);
            this.groupBox1.Controls.Add(this.comboBoxAuthentication);
            this.groupBox1.Controls.Add(this.textBoxSSID);
            this.groupBox1.Controls.Add(this.labelSSID);
            this.groupBox1.Controls.Add(this.textBoxReKeyInternal);
            this.groupBox1.Controls.Add(this.labelReKeyInternal);
            this.groupBox1.Controls.Add(this.textBoxNetworkKey);
            this.groupBox1.Controls.Add(this.labelNetworkKey);
            this.groupBox1.Controls.Add(this.textBoxPassPhrase);
            this.groupBox1.Controls.Add(this.labelPassPhrase);
            this.groupBox1.Controls.Add(this.labelRadio);
            this.groupBox1.Controls.Add(this.labelEncryption);
            this.groupBox1.Controls.Add(this.labelAuthentication);
            this.groupBox1.Location = new System.Drawing.Point(15, 354);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 284);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wireless";
            // 
            // comboBoxNetKey
            // 
            this.comboBoxNetKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNetKey.Enabled = false;
            this.comboBoxNetKey.FormattingEnabled = true;
            this.comboBoxNetKey.Items.AddRange(new object[] {
            "64-bit",
            "128-bit",
            "256-bit",
            "512-bit",
            "1024-bit",
            "2048-bit"});
            this.comboBoxNetKey.Location = new System.Drawing.Point(130, 171);
            this.comboBoxNetKey.Name = "comboBoxNetKey";
            this.comboBoxNetKey.Size = new System.Drawing.Size(230, 21);
            this.comboBoxNetKey.TabIndex = 32;
            this.comboBoxNetKey.SelectionChangeCommitted += new System.EventHandler(this.comboBoxNetKey_SelectionChangeCommitted);
            // 
            // checkBox80211n
            // 
            this.checkBox80211n.AutoSize = true;
            this.checkBox80211n.Location = new System.Drawing.Point(242, 99);
            this.checkBox80211n.Name = "checkBox80211n";
            this.checkBox80211n.Size = new System.Drawing.Size(65, 17);
            this.checkBox80211n.TabIndex = 29;
            this.checkBox80211n.Text = "802.11n";
            this.checkBox80211n.UseVisualStyleBackColor = true;
            // 
            // checkBox80211g
            // 
            this.checkBox80211g.AutoSize = true;
            this.checkBox80211g.Location = new System.Drawing.Point(130, 99);
            this.checkBox80211g.Name = "checkBox80211g";
            this.checkBox80211g.Size = new System.Drawing.Size(65, 17);
            this.checkBox80211g.TabIndex = 28;
            this.checkBox80211g.Text = "802.11g";
            this.checkBox80211g.UseVisualStyleBackColor = true;
            // 
            // checkBox80211b
            // 
            this.checkBox80211b.AutoSize = true;
            this.checkBox80211b.Location = new System.Drawing.Point(242, 76);
            this.checkBox80211b.Name = "checkBox80211b";
            this.checkBox80211b.Size = new System.Drawing.Size(65, 17);
            this.checkBox80211b.TabIndex = 27;
            this.checkBox80211b.Text = "802.11b";
            this.checkBox80211b.UseVisualStyleBackColor = true;
            // 
            // checkBox80211a
            // 
            this.checkBox80211a.AutoSize = true;
            this.checkBox80211a.Location = new System.Drawing.Point(130, 76);
            this.checkBox80211a.Name = "checkBox80211a";
            this.checkBox80211a.Size = new System.Drawing.Size(65, 17);
            this.checkBox80211a.TabIndex = 26;
            this.checkBox80211a.Text = "802.11a";
            this.checkBox80211a.UseVisualStyleBackColor = true;
            // 
            // checkBoxEncryptConfigData
            // 
            this.checkBoxEncryptConfigData.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxEncryptConfigData.Location = new System.Drawing.Point(5, 115);
            this.checkBoxEncryptConfigData.Name = "checkBoxEncryptConfigData";
            this.checkBoxEncryptConfigData.Size = new System.Drawing.Size(139, 24);
            this.checkBoxEncryptConfigData.TabIndex = 30;
            this.checkBoxEncryptConfigData.Text = "Encrypt Config Data";
            this.checkBoxEncryptConfigData.UseVisualStyleBackColor = true;
            // 
            // comboBoxEncryption
            // 
            this.comboBoxEncryption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEncryption.Enabled = false;
            this.comboBoxEncryption.FormattingEnabled = true;
            this.comboBoxEncryption.Items.AddRange(new object[] {
            "None",
            "WEP",
            "WPA",
            "WPAPSK",
            "Certificate"});
            this.comboBoxEncryption.Location = new System.Drawing.Point(130, 46);
            this.comboBoxEncryption.Name = "comboBoxEncryption";
            this.comboBoxEncryption.Size = new System.Drawing.Size(230, 21);
            this.comboBoxEncryption.TabIndex = 25;
            // 
            // comboBoxAuthentication
            // 
            this.comboBoxAuthentication.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAuthentication.Enabled = false;
            this.comboBoxAuthentication.FormattingEnabled = true;
            this.comboBoxAuthentication.Items.AddRange(new object[] {
            "None",
            "EAP",
            "PEAP",
            "WCN",
            "Open",
            "Shared"});
            this.comboBoxAuthentication.Location = new System.Drawing.Point(130, 19);
            this.comboBoxAuthentication.Name = "comboBoxAuthentication";
            this.comboBoxAuthentication.Size = new System.Drawing.Size(230, 21);
            this.comboBoxAuthentication.TabIndex = 24;
            // 
            // textBoxSSID
            // 
            this.textBoxSSID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSSID.Enabled = false;
            this.textBoxSSID.Location = new System.Drawing.Point(130, 250);
            this.textBoxSSID.MaxLength = 31;
            this.textBoxSSID.Name = "textBoxSSID";
            this.textBoxSSID.Size = new System.Drawing.Size(230, 20);
            this.textBoxSSID.TabIndex = 35;
            // 
            // labelSSID
            // 
            this.labelSSID.AutoSize = true;
            this.labelSSID.Enabled = false;
            this.labelSSID.Location = new System.Drawing.Point(7, 253);
            this.labelSSID.Name = "labelSSID";
            this.labelSSID.Size = new System.Drawing.Size(32, 13);
            this.labelSSID.TabIndex = 16;
            this.labelSSID.Text = "SSID";
            // 
            // textBoxReKeyInternal
            // 
            this.textBoxReKeyInternal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxReKeyInternal.Enabled = false;
            this.textBoxReKeyInternal.Location = new System.Drawing.Point(130, 224);
            this.textBoxReKeyInternal.MaxLength = 64;
            this.textBoxReKeyInternal.Name = "textBoxReKeyInternal";
            this.textBoxReKeyInternal.Size = new System.Drawing.Size(230, 20);
            this.textBoxReKeyInternal.TabIndex = 34;
            // 
            // labelReKeyInternal
            // 
            this.labelReKeyInternal.AutoSize = true;
            this.labelReKeyInternal.Enabled = false;
            this.labelReKeyInternal.Location = new System.Drawing.Point(6, 227);
            this.labelReKeyInternal.Name = "labelReKeyInternal";
            this.labelReKeyInternal.Size = new System.Drawing.Size(77, 13);
            this.labelReKeyInternal.TabIndex = 14;
            this.labelReKeyInternal.Text = "ReKey Internal";
            // 
            // textBoxNetworkKey
            // 
            this.textBoxNetworkKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNetworkKey.Enabled = false;
            this.textBoxNetworkKey.Location = new System.Drawing.Point(130, 198);
            this.textBoxNetworkKey.MaxLength = 16;
            this.textBoxNetworkKey.Name = "textBoxNetworkKey";
            this.textBoxNetworkKey.Size = new System.Drawing.Size(230, 20);
            this.textBoxNetworkKey.TabIndex = 33;
            // 
            // labelNetworkKey
            // 
            this.labelNetworkKey.AutoSize = true;
            this.labelNetworkKey.Enabled = false;
            this.labelNetworkKey.Location = new System.Drawing.Point(6, 176);
            this.labelNetworkKey.Name = "labelNetworkKey";
            this.labelNetworkKey.Size = new System.Drawing.Size(68, 13);
            this.labelNetworkKey.TabIndex = 12;
            this.labelNetworkKey.Text = "Network Key";
            // 
            // textBoxPassPhrase
            // 
            this.textBoxPassPhrase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPassPhrase.Enabled = false;
            this.textBoxPassPhrase.Location = new System.Drawing.Point(130, 145);
            this.textBoxPassPhrase.MaxLength = 63;
            this.textBoxPassPhrase.Name = "textBoxPassPhrase";
            this.textBoxPassPhrase.Size = new System.Drawing.Size(230, 20);
            this.textBoxPassPhrase.TabIndex = 31;
            // 
            // labelPassPhrase
            // 
            this.labelPassPhrase.AutoSize = true;
            this.labelPassPhrase.Enabled = false;
            this.labelPassPhrase.Location = new System.Drawing.Point(6, 148);
            this.labelPassPhrase.Name = "labelPassPhrase";
            this.labelPassPhrase.Size = new System.Drawing.Size(65, 13);
            this.labelPassPhrase.TabIndex = 10;
            this.labelPassPhrase.Text = "Pass phrase";
            // 
            // labelRadio
            // 
            this.labelRadio.AutoSize = true;
            this.labelRadio.Enabled = false;
            this.labelRadio.Location = new System.Drawing.Point(6, 76);
            this.labelRadio.Name = "labelRadio";
            this.labelRadio.Size = new System.Drawing.Size(35, 13);
            this.labelRadio.TabIndex = 3;
            this.labelRadio.Text = "Radio";
            // 
            // labelEncryption
            // 
            this.labelEncryption.AutoSize = true;
            this.labelEncryption.Enabled = false;
            this.labelEncryption.Location = new System.Drawing.Point(6, 49);
            this.labelEncryption.Name = "labelEncryption";
            this.labelEncryption.Size = new System.Drawing.Size(57, 13);
            this.labelEncryption.TabIndex = 2;
            this.labelEncryption.Text = "Encryption";
            // 
            // labelAuthentication
            // 
            this.labelAuthentication.AutoSize = true;
            this.labelAuthentication.Enabled = false;
            this.labelAuthentication.Location = new System.Drawing.Point(6, 22);
            this.labelAuthentication.Name = "labelAuthentication";
            this.labelAuthentication.Size = new System.Drawing.Size(75, 13);
            this.labelAuthentication.TabIndex = 1;
            this.labelAuthentication.Text = "Authentication";
            // 
            // tabControlIPSettings
            // 
            this.tabControlIPSettings.Controls.Add(this.tabPageIPv4);
            this.tabControlIPSettings.Controls.Add(this.tabPageIPv6);
            this.tabControlIPSettings.Location = new System.Drawing.Point(12, 12);
            this.tabControlIPSettings.Name = "tabControlIPSettings";
            this.tabControlIPSettings.SelectedIndex = 0;
            this.tabControlIPSettings.Size = new System.Drawing.Size(386, 277);
            this.tabControlIPSettings.TabIndex = 0;
            // 
            // tabPageIPv4
            // 
            this.tabPageIPv4.BackColor = System.Drawing.Color.Transparent;
            this.tabPageIPv4.Controls.Add(this.panelIPv4DnsAddressesSettings);
            this.tabPageIPv4.Controls.Add(this.panelIPv4IPAddressSettings);
            this.tabPageIPv4.Location = new System.Drawing.Point(4, 22);
            this.tabPageIPv4.Name = "tabPageIPv4";
            this.tabPageIPv4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageIPv4.Size = new System.Drawing.Size(378, 251);
            this.tabPageIPv4.TabIndex = 0;
            this.tabPageIPv4.Text = "IPv4";
            // 
            // panelIPv4DnsAddressesSettings
            // 
            this.panelIPv4DnsAddressesSettings.Controls.Add(this.radioButtonIPv4DnsAddressesStatic);
            this.panelIPv4DnsAddressesSettings.Controls.Add(this.groupBoxIPv4DnsAddressesStatic);
            this.panelIPv4DnsAddressesSettings.Controls.Add(this.radioButtonIPv4DnsAddressesDynamic);
            this.panelIPv4DnsAddressesSettings.Location = new System.Drawing.Point(0, 135);
            this.panelIPv4DnsAddressesSettings.Name = "panelIPv4DnsAddressesSettings";
            this.panelIPv4DnsAddressesSettings.Size = new System.Drawing.Size(378, 110);
            this.panelIPv4DnsAddressesSettings.TabIndex = 5;
            // 
            // radioButtonIPv4DnsAddressesStatic
            // 
            this.radioButtonIPv4DnsAddressesStatic.AutoSize = true;
            this.radioButtonIPv4DnsAddressesStatic.Checked = true;
            this.radioButtonIPv4DnsAddressesStatic.Location = new System.Drawing.Point(16, 30);
            this.radioButtonIPv4DnsAddressesStatic.Name = "radioButtonIPv4DnsAddressesStatic";
            this.radioButtonIPv4DnsAddressesStatic.Size = new System.Drawing.Size(218, 17);
            this.radioButtonIPv4DnsAddressesStatic.TabIndex = 8;
            this.radioButtonIPv4DnsAddressesStatic.TabStop = true;
            this.radioButtonIPv4DnsAddressesStatic.Text = "Us&e the following DNS server addresses:";
            this.radioButtonIPv4DnsAddressesStatic.UseVisualStyleBackColor = true;
            this.radioButtonIPv4DnsAddressesStatic.CheckedChanged += new System.EventHandler(this.radioButtonIPv4DnsAddressesDynamic_CheckedChanged);
            // 
            // groupBoxIPv4DnsAddressesStatic
            // 
            this.groupBoxIPv4DnsAddressesStatic.Controls.Add(this.textBoxIPv4DnsSecondary);
            this.groupBoxIPv4DnsAddressesStatic.Controls.Add(this.label1);
            this.groupBoxIPv4DnsAddressesStatic.Controls.Add(this.textBoxIPv4DnsPrimary);
            this.groupBoxIPv4DnsAddressesStatic.Controls.Add(this.label2);
            this.groupBoxIPv4DnsAddressesStatic.Location = new System.Drawing.Point(9, 32);
            this.groupBoxIPv4DnsAddressesStatic.Name = "groupBoxIPv4DnsAddressesStatic";
            this.groupBoxIPv4DnsAddressesStatic.Size = new System.Drawing.Size(358, 71);
            this.groupBoxIPv4DnsAddressesStatic.TabIndex = 9;
            this.groupBoxIPv4DnsAddressesStatic.TabStop = false;
            // 
            // textBoxIPv4DnsSecondary
            // 
            this.textBoxIPv4DnsSecondary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxIPv4DnsSecondary.Location = new System.Drawing.Point(120, 46);
            this.textBoxIPv4DnsSecondary.Name = "textBoxIPv4DnsSecondary";
            this.textBoxIPv4DnsSecondary.Size = new System.Drawing.Size(230, 20);
            this.textBoxIPv4DnsSecondary.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "&Alternate DNS server:";
            // 
            // textBoxIPv4DnsPrimary
            // 
            this.textBoxIPv4DnsPrimary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxIPv4DnsPrimary.Location = new System.Drawing.Point(120, 20);
            this.textBoxIPv4DnsPrimary.Name = "textBoxIPv4DnsPrimary";
            this.textBoxIPv4DnsPrimary.Size = new System.Drawing.Size(230, 20);
            this.textBoxIPv4DnsPrimary.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "&Preferred DNS server:";
            // 
            // radioButtonIPv4DnsAddressesDynamic
            // 
            this.radioButtonIPv4DnsAddressesDynamic.AutoSize = true;
            this.radioButtonIPv4DnsAddressesDynamic.Enabled = false;
            this.radioButtonIPv4DnsAddressesDynamic.Location = new System.Drawing.Point(16, 9);
            this.radioButtonIPv4DnsAddressesDynamic.Name = "radioButtonIPv4DnsAddressesDynamic";
            this.radioButtonIPv4DnsAddressesDynamic.Size = new System.Drawing.Size(218, 17);
            this.radioButtonIPv4DnsAddressesDynamic.TabIndex = 7;
            this.radioButtonIPv4DnsAddressesDynamic.Text = "O&btain DNS server address automatically";
            this.radioButtonIPv4DnsAddressesDynamic.UseVisualStyleBackColor = true;
            this.radioButtonIPv4DnsAddressesDynamic.CheckedChanged += new System.EventHandler(this.radioButtonIPv4DnsAddressesDynamic_CheckedChanged);
            // 
            // panelIPv4IPAddressSettings
            // 
            this.panelIPv4IPAddressSettings.Controls.Add(this.radioButtonIPv4IPAddressStatic);
            this.panelIPv4IPAddressSettings.Controls.Add(this.groupBoxIPv4AddressStatic);
            this.panelIPv4IPAddressSettings.Controls.Add(this.radioButtonIPv4IPAddressDynamic);
            this.panelIPv4IPAddressSettings.Location = new System.Drawing.Point(0, 0);
            this.panelIPv4IPAddressSettings.Name = "panelIPv4IPAddressSettings";
            this.panelIPv4IPAddressSettings.Size = new System.Drawing.Size(378, 136);
            this.panelIPv4IPAddressSettings.TabIndex = 4;
            // 
            // radioButtonIPv4IPAddressStatic
            // 
            this.radioButtonIPv4IPAddressStatic.AutoSize = true;
            this.radioButtonIPv4IPAddressStatic.Checked = true;
            this.radioButtonIPv4IPAddressStatic.Location = new System.Drawing.Point(16, 30);
            this.radioButtonIPv4IPAddressStatic.Name = "radioButtonIPv4IPAddressStatic";
            this.radioButtonIPv4IPAddressStatic.Size = new System.Drawing.Size(162, 17);
            this.radioButtonIPv4IPAddressStatic.TabIndex = 2;
            this.radioButtonIPv4IPAddressStatic.TabStop = true;
            this.radioButtonIPv4IPAddressStatic.Text = "U&se the following IP address:";
            this.radioButtonIPv4IPAddressStatic.UseVisualStyleBackColor = true;
            this.radioButtonIPv4IPAddressStatic.CheckedChanged += new System.EventHandler(this.radioButtonIPv4IPAddressDynamic_CheckedChanged);
            // 
            // groupBoxIPv4AddressStatic
            // 
            this.groupBoxIPv4AddressStatic.Controls.Add(this.textBoxIPv4DefaultGateway);
            this.groupBoxIPv4AddressStatic.Controls.Add(this.label3);
            this.groupBoxIPv4AddressStatic.Controls.Add(this.textBoxIPv4SubnetMask);
            this.groupBoxIPv4AddressStatic.Controls.Add(this.label4);
            this.groupBoxIPv4AddressStatic.Controls.Add(this.textBoxIPv4IPAddress);
            this.groupBoxIPv4AddressStatic.Controls.Add(this.label5);
            this.groupBoxIPv4AddressStatic.Location = new System.Drawing.Point(9, 32);
            this.groupBoxIPv4AddressStatic.Name = "groupBoxIPv4AddressStatic";
            this.groupBoxIPv4AddressStatic.Size = new System.Drawing.Size(358, 97);
            this.groupBoxIPv4AddressStatic.TabIndex = 3;
            this.groupBoxIPv4AddressStatic.TabStop = false;
            // 
            // textBoxIPv4DefaultGateway
            // 
            this.textBoxIPv4DefaultGateway.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxIPv4DefaultGateway.Location = new System.Drawing.Point(120, 72);
            this.textBoxIPv4DefaultGateway.Name = "textBoxIPv4DefaultGateway";
            this.textBoxIPv4DefaultGateway.Size = new System.Drawing.Size(230, 20);
            this.textBoxIPv4DefaultGateway.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "&Default gateway:";
            // 
            // textBoxIPv4SubnetMask
            // 
            this.textBoxIPv4SubnetMask.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxIPv4SubnetMask.Location = new System.Drawing.Point(120, 46);
            this.textBoxIPv4SubnetMask.Name = "textBoxIPv4SubnetMask";
            this.textBoxIPv4SubnetMask.Size = new System.Drawing.Size(230, 20);
            this.textBoxIPv4SubnetMask.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "S&ubnet mask:";
            // 
            // textBoxIPv4IPAddress
            // 
            this.textBoxIPv4IPAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxIPv4IPAddress.Location = new System.Drawing.Point(120, 20);
            this.textBoxIPv4IPAddress.Name = "textBoxIPv4IPAddress";
            this.textBoxIPv4IPAddress.Size = new System.Drawing.Size(230, 20);
            this.textBoxIPv4IPAddress.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "&IP address:";
            // 
            // radioButtonIPv4IPAddressDynamic
            // 
            this.radioButtonIPv4IPAddressDynamic.AutoSize = true;
            this.radioButtonIPv4IPAddressDynamic.Location = new System.Drawing.Point(16, 9);
            this.radioButtonIPv4IPAddressDynamic.Name = "radioButtonIPv4IPAddressDynamic";
            this.radioButtonIPv4IPAddressDynamic.Size = new System.Drawing.Size(188, 17);
            this.radioButtonIPv4IPAddressDynamic.TabIndex = 1;
            this.radioButtonIPv4IPAddressDynamic.Text = "&Obtain an IP address automatically";
            this.radioButtonIPv4IPAddressDynamic.UseVisualStyleBackColor = true;
            this.radioButtonIPv4IPAddressDynamic.CheckedChanged += new System.EventHandler(this.radioButtonIPv4IPAddressDynamic_CheckedChanged);
            // 
            // tabPageIPv6
            // 
            this.tabPageIPv6.Controls.Add(this.panelIPv6DnsAddressesSettings);
            this.tabPageIPv6.Controls.Add(this.panelIPv6IPAddressSettings);
            this.tabPageIPv6.Location = new System.Drawing.Point(4, 22);
            this.tabPageIPv6.Name = "tabPageIPv6";
            this.tabPageIPv6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageIPv6.Size = new System.Drawing.Size(378, 251);
            this.tabPageIPv6.TabIndex = 1;
            this.tabPageIPv6.Text = "IPv6";
            // 
            // panelIPv6DnsAddressesSettings
            // 
            this.panelIPv6DnsAddressesSettings.Controls.Add(this.radioButtonIPv6DnsAddressesStatic);
            this.panelIPv6DnsAddressesSettings.Controls.Add(this.groupBoxIPv6DnsAddressesStatic);
            this.panelIPv6DnsAddressesSettings.Controls.Add(this.radioButtonIPv6DnsAddressesDynamic);
            this.panelIPv6DnsAddressesSettings.Location = new System.Drawing.Point(0, 135);
            this.panelIPv6DnsAddressesSettings.Name = "panelIPv6DnsAddressesSettings";
            this.panelIPv6DnsAddressesSettings.Size = new System.Drawing.Size(378, 110);
            this.panelIPv6DnsAddressesSettings.TabIndex = 3;
            // 
            // radioButtonIPv6DnsAddressesStatic
            // 
            this.radioButtonIPv6DnsAddressesStatic.AutoSize = true;
            this.radioButtonIPv6DnsAddressesStatic.Checked = true;
            this.radioButtonIPv6DnsAddressesStatic.Location = new System.Drawing.Point(16, 30);
            this.radioButtonIPv6DnsAddressesStatic.Name = "radioButtonIPv6DnsAddressesStatic";
            this.radioButtonIPv6DnsAddressesStatic.Size = new System.Drawing.Size(218, 17);
            this.radioButtonIPv6DnsAddressesStatic.TabIndex = 19;
            this.radioButtonIPv6DnsAddressesStatic.TabStop = true;
            this.radioButtonIPv6DnsAddressesStatic.Text = "Us&e the following DNS server addresses:";
            this.radioButtonIPv6DnsAddressesStatic.UseVisualStyleBackColor = true;
            this.radioButtonIPv6DnsAddressesStatic.CheckedChanged += new System.EventHandler(this.radioButtonIPv6DnsAddressesDynamic_CheckedChanged);
            // 
            // groupBoxIPv6DnsAddressesStatic
            // 
            this.groupBoxIPv6DnsAddressesStatic.Controls.Add(this.textBoxIPv6DnsSecondary);
            this.groupBoxIPv6DnsAddressesStatic.Controls.Add(this.label12);
            this.groupBoxIPv6DnsAddressesStatic.Controls.Add(this.textBoxIPv6DnsPrimary);
            this.groupBoxIPv6DnsAddressesStatic.Controls.Add(this.label13);
            this.groupBoxIPv6DnsAddressesStatic.Location = new System.Drawing.Point(9, 32);
            this.groupBoxIPv6DnsAddressesStatic.Name = "groupBoxIPv6DnsAddressesStatic";
            this.groupBoxIPv6DnsAddressesStatic.Size = new System.Drawing.Size(358, 71);
            this.groupBoxIPv6DnsAddressesStatic.TabIndex = 20;
            this.groupBoxIPv6DnsAddressesStatic.TabStop = false;
            // 
            // textBoxIPv6DnsSecondary
            // 
            this.textBoxIPv6DnsSecondary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxIPv6DnsSecondary.Location = new System.Drawing.Point(120, 46);
            this.textBoxIPv6DnsSecondary.Name = "textBoxIPv6DnsSecondary";
            this.textBoxIPv6DnsSecondary.Size = new System.Drawing.Size(230, 20);
            this.textBoxIPv6DnsSecondary.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "&Alternate DNS server:";
            // 
            // textBoxIPv6DnsPrimary
            // 
            this.textBoxIPv6DnsPrimary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxIPv6DnsPrimary.Location = new System.Drawing.Point(120, 20);
            this.textBoxIPv6DnsPrimary.Name = "textBoxIPv6DnsPrimary";
            this.textBoxIPv6DnsPrimary.Size = new System.Drawing.Size(230, 20);
            this.textBoxIPv6DnsPrimary.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "&Preferred DNS server:";
            // 
            // radioButtonIPv6DnsAddressesDynamic
            // 
            this.radioButtonIPv6DnsAddressesDynamic.AutoSize = true;
            this.radioButtonIPv6DnsAddressesDynamic.Enabled = false;
            this.radioButtonIPv6DnsAddressesDynamic.Location = new System.Drawing.Point(16, 9);
            this.radioButtonIPv6DnsAddressesDynamic.Name = "radioButtonIPv6DnsAddressesDynamic";
            this.radioButtonIPv6DnsAddressesDynamic.Size = new System.Drawing.Size(218, 17);
            this.radioButtonIPv6DnsAddressesDynamic.TabIndex = 18;
            this.radioButtonIPv6DnsAddressesDynamic.Text = "O&btain DNS server address automatically";
            this.radioButtonIPv6DnsAddressesDynamic.UseVisualStyleBackColor = true;
            this.radioButtonIPv6DnsAddressesDynamic.CheckedChanged += new System.EventHandler(this.radioButtonIPv6DnsAddressesDynamic_CheckedChanged);
            // 
            // panelIPv6IPAddressSettings
            // 
            this.panelIPv6IPAddressSettings.Controls.Add(this.radioButtonIPv6IPAddressStatic);
            this.panelIPv6IPAddressSettings.Controls.Add(this.groupBoxIPv6AddressStatic);
            this.panelIPv6IPAddressSettings.Controls.Add(this.radioButtonIPv6IPAddressDynamic);
            this.panelIPv6IPAddressSettings.Location = new System.Drawing.Point(0, 0);
            this.panelIPv6IPAddressSettings.Name = "panelIPv6IPAddressSettings";
            this.panelIPv6IPAddressSettings.Size = new System.Drawing.Size(378, 136);
            this.panelIPv6IPAddressSettings.TabIndex = 1;
            // 
            // radioButtonIPv6IPAddressStatic
            // 
            this.radioButtonIPv6IPAddressStatic.AutoSize = true;
            this.radioButtonIPv6IPAddressStatic.Checked = true;
            this.radioButtonIPv6IPAddressStatic.Location = new System.Drawing.Point(16, 30);
            this.radioButtonIPv6IPAddressStatic.Name = "radioButtonIPv6IPAddressStatic";
            this.radioButtonIPv6IPAddressStatic.Size = new System.Drawing.Size(174, 17);
            this.radioButtonIPv6IPAddressStatic.TabIndex = 13;
            this.radioButtonIPv6IPAddressStatic.TabStop = true;
            this.radioButtonIPv6IPAddressStatic.Text = "U&se the following IPv6 address:";
            this.radioButtonIPv6IPAddressStatic.UseVisualStyleBackColor = true;
            this.radioButtonIPv6IPAddressStatic.CheckedChanged += new System.EventHandler(this.radioButtonIPv6IPAddressDynamic_CheckedChanged);
            // 
            // groupBoxIPv6AddressStatic
            // 
            this.groupBoxIPv6AddressStatic.Controls.Add(this.textBoxIPv6DefaultGateway);
            this.groupBoxIPv6AddressStatic.Controls.Add(this.label6);
            this.groupBoxIPv6AddressStatic.Controls.Add(this.textBoxIPv6SubnetPrefixLength);
            this.groupBoxIPv6AddressStatic.Controls.Add(this.label8);
            this.groupBoxIPv6AddressStatic.Controls.Add(this.textBoxIPv6IPAddress);
            this.groupBoxIPv6AddressStatic.Controls.Add(this.label9);
            this.groupBoxIPv6AddressStatic.Location = new System.Drawing.Point(9, 32);
            this.groupBoxIPv6AddressStatic.Name = "groupBoxIPv6AddressStatic";
            this.groupBoxIPv6AddressStatic.Size = new System.Drawing.Size(358, 97);
            this.groupBoxIPv6AddressStatic.TabIndex = 14;
            this.groupBoxIPv6AddressStatic.TabStop = false;
            // 
            // textBoxIPv6DefaultGateway
            // 
            this.textBoxIPv6DefaultGateway.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxIPv6DefaultGateway.Location = new System.Drawing.Point(120, 72);
            this.textBoxIPv6DefaultGateway.Name = "textBoxIPv6DefaultGateway";
            this.textBoxIPv6DefaultGateway.Size = new System.Drawing.Size(230, 20);
            this.textBoxIPv6DefaultGateway.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "&Default gateway:";
            // 
            // textBoxIPv6SubnetPrefixLength
            // 
            this.textBoxIPv6SubnetPrefixLength.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxIPv6SubnetPrefixLength.Location = new System.Drawing.Point(120, 46);
            this.textBoxIPv6SubnetPrefixLength.Name = "textBoxIPv6SubnetPrefixLength";
            this.textBoxIPv6SubnetPrefixLength.Size = new System.Drawing.Size(40, 20);
            this.textBoxIPv6SubnetPrefixLength.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "S&ubnet prefix length:";
            // 
            // textBoxIPv6IPAddress
            // 
            this.textBoxIPv6IPAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxIPv6IPAddress.Location = new System.Drawing.Point(120, 20);
            this.textBoxIPv6IPAddress.Name = "textBoxIPv6IPAddress";
            this.textBoxIPv6IPAddress.Size = new System.Drawing.Size(230, 20);
            this.textBoxIPv6IPAddress.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "&IPv6 address:";
            // 
            // radioButtonIPv6IPAddressDynamic
            // 
            this.radioButtonIPv6IPAddressDynamic.AutoSize = true;
            this.radioButtonIPv6IPAddressDynamic.Location = new System.Drawing.Point(16, 9);
            this.radioButtonIPv6IPAddressDynamic.Name = "radioButtonIPv6IPAddressDynamic";
            this.radioButtonIPv6IPAddressDynamic.Size = new System.Drawing.Size(200, 17);
            this.radioButtonIPv6IPAddressDynamic.TabIndex = 12;
            this.radioButtonIPv6IPAddressDynamic.Text = "&Obtain an IPv6 address automatically";
            this.radioButtonIPv6IPAddressDynamic.UseVisualStyleBackColor = true;
            this.radioButtonIPv6IPAddressDynamic.CheckedChanged += new System.EventHandler(this.radioButtonIPv6IPAddressDynamic_CheckedChanged);
            // 
            // textBoxMACAddress
            // 
            this.textBoxMACAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMACAddress.Location = new System.Drawing.Point(130, 19);
            this.textBoxMACAddress.Name = "textBoxMACAddress";
            this.textBoxMACAddress.Size = new System.Drawing.Size(232, 20);
            this.textBoxMACAddress.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "&MAC Address:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxMACAddress);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(15, 295);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(382, 53);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hardware";
            // 
            // MFNetworkConfigDialog
            // 
            this.AcceptButton = this.buttonUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(410, 679);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tabControlIPSettings);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonUpdate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MFNetworkConfigDialog";
            this.ShowInTaskbar = false;
            this.Text = "Network Configuration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MFNetworkConfigDialog_FormClosing);
            this.Load += new System.EventHandler(this.ConfigDialog_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControlIPSettings.ResumeLayout(false);
            this.tabPageIPv4.ResumeLayout(false);
            this.panelIPv4DnsAddressesSettings.ResumeLayout(false);
            this.panelIPv4DnsAddressesSettings.PerformLayout();
            this.groupBoxIPv4DnsAddressesStatic.ResumeLayout(false);
            this.groupBoxIPv4DnsAddressesStatic.PerformLayout();
            this.panelIPv4IPAddressSettings.ResumeLayout(false);
            this.panelIPv4IPAddressSettings.PerformLayout();
            this.groupBoxIPv4AddressStatic.ResumeLayout(false);
            this.groupBoxIPv4AddressStatic.PerformLayout();
            this.tabPageIPv6.ResumeLayout(false);
            this.panelIPv6DnsAddressesSettings.ResumeLayout(false);
            this.panelIPv6DnsAddressesSettings.PerformLayout();
            this.groupBoxIPv6DnsAddressesStatic.ResumeLayout(false);
            this.groupBoxIPv6DnsAddressesStatic.PerformLayout();
            this.panelIPv6IPAddressSettings.ResumeLayout(false);
            this.panelIPv6IPAddressSettings.PerformLayout();
            this.groupBoxIPv6AddressStatic.ResumeLayout(false);
            this.groupBoxIPv6AddressStatic.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxSSID;
        private System.Windows.Forms.Label labelSSID;
        private System.Windows.Forms.TextBox textBoxNetworkKey;
        private System.Windows.Forms.Label labelNetworkKey;
        private System.Windows.Forms.TextBox textBoxPassPhrase;
        private System.Windows.Forms.Label labelPassPhrase;
        private System.Windows.Forms.Label labelRadio;
        private System.Windows.Forms.Label labelEncryption;
        private System.Windows.Forms.Label labelAuthentication;
        private System.Windows.Forms.ComboBox comboBoxEncryption;
        private System.Windows.Forms.ComboBox comboBoxAuthentication;
        private System.Windows.Forms.CheckBox checkBoxEncryptConfigData;
        private System.Windows.Forms.CheckBox checkBox80211n;
        private System.Windows.Forms.CheckBox checkBox80211g;
        private System.Windows.Forms.CheckBox checkBox80211b;
        private System.Windows.Forms.CheckBox checkBox80211a;
        private System.Windows.Forms.ComboBox comboBoxNetKey;
        private System.Windows.Forms.TextBox textBoxReKeyInternal;
        private System.Windows.Forms.Label labelReKeyInternal;
        private System.Windows.Forms.TabControl tabControlIPSettings;
        private System.Windows.Forms.TabPage tabPageIPv4;
        private System.Windows.Forms.TabPage tabPageIPv6;
        private System.Windows.Forms.TextBox textBoxMACAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panelIPv6IPAddressSettings;
        private System.Windows.Forms.GroupBox groupBoxIPv6AddressStatic;
        private System.Windows.Forms.RadioButton radioButtonIPv6IPAddressStatic;
        private System.Windows.Forms.RadioButton radioButtonIPv6IPAddressDynamic;
        private System.Windows.Forms.TextBox textBoxIPv6DefaultGateway;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxIPv6SubnetPrefixLength;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxIPv6IPAddress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panelIPv6DnsAddressesSettings;
        private System.Windows.Forms.RadioButton radioButtonIPv6DnsAddressesStatic;
        private System.Windows.Forms.GroupBox groupBoxIPv6DnsAddressesStatic;
        private System.Windows.Forms.TextBox textBoxIPv6DnsSecondary;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxIPv6DnsPrimary;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton radioButtonIPv6DnsAddressesDynamic;
        private System.Windows.Forms.Panel panelIPv4DnsAddressesSettings;
        private System.Windows.Forms.RadioButton radioButtonIPv4DnsAddressesStatic;
        private System.Windows.Forms.GroupBox groupBoxIPv4DnsAddressesStatic;
        private System.Windows.Forms.TextBox textBoxIPv4DnsSecondary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIPv4DnsPrimary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonIPv4DnsAddressesDynamic;
        private System.Windows.Forms.Panel panelIPv4IPAddressSettings;
        private System.Windows.Forms.RadioButton radioButtonIPv4IPAddressStatic;
        private System.Windows.Forms.GroupBox groupBoxIPv4AddressStatic;
        private System.Windows.Forms.TextBox textBoxIPv4DefaultGateway;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxIPv4SubnetMask;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxIPv4IPAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButtonIPv4IPAddressDynamic;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}