using System;
using System.Globalization;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.CodeDom.Compiler;
using System.Data;
using System.Drawing;
using System.Text;
using System.Net;
using System.Windows.Forms;
using Microsoft.NetMicroFramework.Tools;
using Microsoft.NetMicroFramework.Tools.MFDeployTool.Engine;
using Microsoft.NetMicroFramework.Tools.MFDeployTool.PlugIns;

namespace Microsoft.NetMicroFramework.Tools.MFDeployTool
{
    internal partial class MFNetworkConfigDialog : Form
    {
        MFNetworkConfiguration m_cfg;
        MFNetworkConfigurationExtended m_cfgExt;
        MFWirelessConfiguration m_wirelessCfg;
        MFConfigHelper m_cfgHelper;

        public MFNetworkConfigDialog(MFDevice device)
        {
            m_cfg = new MFNetworkConfiguration(device);
            m_cfgExt = new MFNetworkConfigurationExtended(device);
            m_cfgHelper = new MFConfigHelper(device);
            m_wirelessCfg = new MFWirelessConfiguration(device);

            InitializeComponent();
        }

        private string MacToDashedHex(byte []mac_addr)
        {
            string str = "";

            for (int i = 0; i < mac_addr.Length; i++)
            {
                str += string.Format("{0:x02}-", mac_addr[i]);
            }
            return str.TrimEnd('-');
        }

        private byte[] DashedHexToMac(string mac, int maxlen)
        {
            string[] dd = mac.Split(new char[] { ':', '-' }, StringSplitOptions.RemoveEmptyEntries);

            if (dd.Length > maxlen) throw new MFInvalidMacAddressException();

            byte[] data = new byte[dd.Length];

            try
            {
                for (int i = 0; i < dd.Length; i++)
                {
                    data[i] = byte.Parse(dd[i], NumberStyles.HexNumber);
                }
            }
            catch
            {
                throw new MFInvalidMacAddressException();
            }

            return data;
        }


        private void ConfigDialog_Load(System.Object sender, System.EventArgs e)
        {
            m_cfg.Load();

            m_cfgHelper.MaintainConnection = true;

            textBoxIPv4IPAddress.Text                   = m_cfg.IpAddress.ToString();
            textBoxIPv4SubnetMask.Text                  = m_cfg.SubNetMask.ToString();
            textBoxIPv4DefaultGateway.Text              = m_cfg.Gateway.ToString();
            radioButtonIPv4IPAddressDynamic.Checked     = m_cfg.EnableDhcpForIpAddress;
            radioButtonIPv4DnsAddressesDynamic.Checked  = m_cfg.EnableDhcpForDnsAddresses;
            textBoxIPv4DnsPrimary.Text                  = m_cfg.PrimaryDns.ToString();
            textBoxIPv4DnsSecondary.Text                = m_cfg.SecondaryDns.ToString();
            textBoxMACAddress.Text                      = MacToDashedHex(m_cfg.MacAddress);

            if (m_cfg.EnableExtendedConfiguration)
            {
                m_cfgExt.Load();
                if (m_cfgExt.EnableIPv6)
                {
                    textBoxIPv6IPAddress.Text                  = m_cfgExt.IPv6IpAddress.ToString();
                    textBoxIPv6SubnetPrefixLength.Text         = m_cfgExt.IPv6SubnetPrefixLength.ToString();
                    textBoxIPv6DefaultGateway.Text             = m_cfgExt.IPv6Gateway.ToString();
                    radioButtonIPv6IPAddressDynamic.Checked    = m_cfgExt.EnableDhcpForIPv6IpAddress;
                    radioButtonIPv6DnsAddressesDynamic.Checked = m_cfgExt.EnableDhcpForIPv6DnsAddresses;
                    textBoxIPv6DnsPrimary.Text                 = m_cfgExt.IPv6PrimaryDns.ToString();
                    textBoxIPv6DnsSecondary.Text               = m_cfgExt.IPv6SecondaryDns.ToString();
                }
            }
            else
            {
                tabControlIPSettings.Controls.Remove(tabPageIPv6);
            }

            if (m_cfg.ConfigurationType == MFNetworkConfiguration.NetworkConfigType.Wireless)
            {
                EnableWireless(true);
                m_wirelessCfg.Load();
                textBoxPassPhrase.Text = m_wirelessCfg.PassPhrase;
                int index = (int)Math.Log(m_wirelessCfg.NetworkKeyLength / 8.0, 2);
                comboBoxNetKey.SelectedIndex = (index < comboBoxNetKey.Items.Count && index > 0 ? index : comboBoxNetKey.Items.Count-1);
                textBoxNetworkKey.Text = m_wirelessCfg.NetworkKey;
                textBoxReKeyInternal.Text = m_wirelessCfg.ReKeyInternal;
                textBoxSSID.Text = m_wirelessCfg.SSID;
                checkBox80211a.Checked = ((m_wirelessCfg.Radio & (int)MFWirelessConfiguration.RadioTypes.a) != 0);
                checkBox80211b.Checked = ((m_wirelessCfg.Radio & (int)MFWirelessConfiguration.RadioTypes.b) != 0);
                checkBox80211g.Checked = ((m_wirelessCfg.Radio & (int)MFWirelessConfiguration.RadioTypes.g) != 0);
                checkBox80211n.Checked = ((m_wirelessCfg.Radio & (int)MFWirelessConfiguration.RadioTypes.n) != 0);

                try
                {
                    comboBoxAuthentication.SelectedIndex = m_wirelessCfg.Authentication;
                    comboBoxEncryption.SelectedIndex = m_wirelessCfg.Encryption;                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, Properties.Resources.NetworkTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                checkBoxEncryptConfigData.Checked = m_wirelessCfg.UseEncryption;
            }
            else
            {
                EnableWireless(false);
            }
        }


        private bool CheckStringToIpAddress(string name, TextBox tb, out IPAddress ip, System.Net.Sockets.AddressFamily addressFamily)
        {
            ip = null;
            if (!IPAddress.TryParse(tb.Text, out ip) || (ip.AddressFamily != addressFamily))
            { 
                MessageBox.Show(this, string.Format(Properties.Resources.ErrorInvalidX, name), Properties.Resources.TitleErrorInput, MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb.Focus();
                tb.SelectAll();
                return false;
            }

            return true;
        }

        private bool SaveData()
        {
            IPAddress ip;

            if (!CheckStringToIpAddress(Properties.Resources.IpAddress          , textBoxIPv4IPAddress     , out ip, System.Net.Sockets.AddressFamily.InterNetwork)) return false;
            m_cfg.IpAddress = ip;
            if (!CheckStringToIpAddress(Properties.Resources.SubnetMask         , textBoxIPv4SubnetMask    , out ip, System.Net.Sockets.AddressFamily.InterNetwork)) return false;
            m_cfg.SubNetMask = ip;
            if (!CheckStringToIpAddress(Properties.Resources.DefaultGateway     , textBoxIPv4DefaultGateway, out ip, System.Net.Sockets.AddressFamily.InterNetwork)) return false;
            m_cfg.Gateway = ip;
            if (!CheckStringToIpAddress(Properties.Resources.PrimaryDnsAddress  , textBoxIPv4DnsPrimary    , out ip, System.Net.Sockets.AddressFamily.InterNetwork)) return false;
            m_cfg.PrimaryDns = ip;
            if (!CheckStringToIpAddress(Properties.Resources.SecondaryDnsAddress, textBoxIPv4DnsSecondary  , out ip, System.Net.Sockets.AddressFamily.InterNetwork)) return false;
            m_cfg.SecondaryDns = ip;

            if (m_cfg.EnableExtendedConfiguration && m_cfgExt.EnableIPv6)
            {
                if (!CheckStringToIpAddress(Properties.Resources.IpAddress          , textBoxIPv6IPAddress     , out ip, System.Net.Sockets.AddressFamily.InterNetworkV6)) return false;
                m_cfgExt.IPv6IpAddress = ip;

                byte subnetPrefixLength;
                if (byte.TryParse(textBoxIPv6SubnetPrefixLength.Text, out subnetPrefixLength) && subnetPrefixLength <= 128)
                {
                    m_cfgExt.IPv6SubnetPrefixLength = subnetPrefixLength;
                }
                else
                {
                    MessageBox.Show(this, string.Format(Properties.Resources.ErrorInvalidX, Properties.Resources.SubnetPrefixLength), Properties.Resources.TitleErrorInput, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    textBoxIPv6SubnetPrefixLength.Focus();
                    textBoxIPv6SubnetPrefixLength.SelectAll();

                    return false;
                }

                if (!CheckStringToIpAddress(Properties.Resources.DefaultGateway     , textBoxIPv6DefaultGateway, out ip, System.Net.Sockets.AddressFamily.InterNetworkV6)) return false;
                m_cfgExt.IPv6Gateway = ip;
                if (!CheckStringToIpAddress(Properties.Resources.PrimaryDnsAddress  , textBoxIPv6DnsPrimary    , out ip, System.Net.Sockets.AddressFamily.InterNetworkV6)) return false;
                m_cfgExt.IPv6PrimaryDns = ip;
                if (!CheckStringToIpAddress(Properties.Resources.SecondaryDnsAddress, textBoxIPv6DnsSecondary  , out ip, System.Net.Sockets.AddressFamily.InterNetworkV6)) return false;
                m_cfgExt.IPv6SecondaryDns = ip;

                m_cfgExt.EnableDhcpForIPv6IpAddress = radioButtonIPv6IPAddressDynamic.Checked;
                m_cfgExt.EnableDhcpForIPv6DnsAddresses = radioButtonIPv6DnsAddressesDynamic.Checked;
            }

            try
            {
                m_cfg.MacAddress = DashedHexToMac(textBoxMACAddress.Text, m_cfg.MaxMacAddressLength);
            }
            catch (FormatException)
            {
                MessageBox.Show(this, string.Format(Properties.Resources.ErrorInvalidX, Properties.Resources.MacAddress), Properties.Resources.TitleErrorInput, MessageBoxButtons.OK, MessageBoxIcon.Error);

                textBoxMACAddress.Focus();
                textBoxMACAddress.SelectAll();

                return false;
            }

            m_cfg.EnableDhcpForIpAddress = radioButtonIPv4IPAddressDynamic.Checked;
            m_cfg.EnableDhcpForDnsAddresses = radioButtonIPv4DnsAddressesDynamic.Checked;

            return true;
        }

        private bool ValidateWirelessData()
        {
            object tbCurrent = null;

            try
            {
                m_wirelessCfg.Authentication = comboBoxAuthentication.SelectedIndex;
                m_wirelessCfg.Encryption = comboBoxEncryption.SelectedIndex;
                m_wirelessCfg.Radio = (checkBox80211a.Checked ? (int)MFWirelessConfiguration.RadioTypes.a : 0) | 
                                      (checkBox80211b.Checked ? (int)MFWirelessConfiguration.RadioTypes.b : 0) | 
                                      (checkBox80211g.Checked ? (int)MFWirelessConfiguration.RadioTypes.g : 0) | 
                                      (checkBox80211n.Checked ? (int)MFWirelessConfiguration.RadioTypes.n : 0);
                m_wirelessCfg.UseEncryption = checkBoxEncryptConfigData.Checked;

                tbCurrent = textBoxPassPhrase;
                m_wirelessCfg.PassPhrase = textBoxPassPhrase.Text;
                m_wirelessCfg.NetworkKeyLength = (int)(Math.Pow(2.0, comboBoxNetKey.SelectedIndex) * 8);
                tbCurrent = textBoxNetworkKey;
                m_wirelessCfg.NetworkKey = textBoxNetworkKey.Text;
                m_wirelessCfg.ReKeyLength = textBoxReKeyInternal.Text.Length / 2;
                tbCurrent = textBoxReKeyInternal;
                m_wirelessCfg.ReKeyInternal = textBoxReKeyInternal.Text;
                tbCurrent = textBoxSSID;
                m_wirelessCfg.SSID = textBoxSSID.Text;

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, Properties.Resources.TitleErrorInput, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                if (tbCurrent != null && tbCurrent is TextBox)
                {
                    ((TextBox)tbCurrent).Focus();
                    ((TextBox)tbCurrent).Select(0, ((TextBox)tbCurrent).Text.Length);
                }
            }

            return false;
        }

        private void buttonUpdate_Click(System.Object sender, System.EventArgs e)
        {            
            Cursor old = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            Exception ex = null;

            try
            {
                if (!SaveData()) return;


                m_cfgHelper.MaintainConnection = false;


                if (m_cfg.ConfigurationType == MFNetworkConfiguration.NetworkConfigType.Wireless)
                {
                    if (ValidateWirelessData())
                    {
                        m_wirelessCfg.Save();
                        m_cfg.SwapConfigBuffer(m_wirelessCfg.m_cfgHelper);
                    }
                    else
                    {
                        return;
                    }
                }

                if (m_cfg.EnableExtendedConfiguration)
                {
                    m_cfgExt.Save();
                    m_cfg.SwapConfigBuffer(m_cfgExt.m_cfgHelper);
                }

                m_cfg.Save();

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception e1)
            {
                /// First, we throw System.Exception from SaveData(), so we are ending up catching essentially
                /// all exceptions here.
                /// And then, failing to catch an exception here would abruptly end NetworkDialog's message loop,
                /// not a good termination scenario, instead we should communicate this to user, and give user
                /// option either to correct the reason, or press "Cancel". Exceptions are thrown usually for
                /// bad data, invalid format of data, or some issue in the device.
                ex = e1;
            }
            finally
            {
                Cursor.Current = old;
            }

            if (ex != null)
            {
                MessageBox.Show(this, ex.Message, Properties.Resources.NetworkTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonCancel_Click(System.Object sender, System.EventArgs e)
        {
            m_cfgHelper.MaintainConnection = false;
        }

        private void MFNetworkConfigDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (m_cfgHelper != null)
            {
                m_cfgHelper.Dispose();
            }
        }

        private void EnableWireless(bool enable)
        {
            comboBoxAuthentication.Enabled = enable;
            comboBoxEncryption.Enabled = enable;
            checkBox80211a.Enabled = enable;
            checkBox80211b.Enabled = enable;
            checkBox80211g.Enabled = enable;
            checkBox80211n.Enabled = enable;
            textBoxPassPhrase.Enabled = enable;
            textBoxNetworkKey.Enabled = enable;
            textBoxReKeyInternal.Enabled = enable;
            textBoxSSID.Enabled = enable;
            labelAuthentication.Enabled = enable;
            labelEncryption.Enabled = enable;
            labelRadio.Enabled = enable;
            labelPassPhrase.Enabled = enable;
            labelNetworkKey.Enabled = enable;
            labelReKeyInternal.Enabled = enable;
            labelSSID.Enabled = enable;
            checkBoxEncryptConfigData.Enabled = enable;
            comboBoxNetKey.Enabled = enable;
            comboBoxAuthentication.SelectedIndex = 0;
            comboBoxEncryption.SelectedIndex = 0;
            comboBoxNetKey.SelectedIndex = 0;

            checkBox80211a.Checked = false;
            checkBox80211b.Checked = false;
            checkBox80211g.Checked = false;
            checkBox80211n.Checked = false;

            if (enable)
            {
                m_cfg.ConfigurationType = MFNetworkConfiguration.NetworkConfigType.Wireless;
            }
            else
            {
                m_cfg.ConfigurationType = MFNetworkConfiguration.NetworkConfigType.Generic;
            }
        }

        private void comboBoxNetKey_SelectionChangeCommitted(object sender, EventArgs e)
        {
            switch(comboBoxNetKey.SelectedIndex)
            {
                case 0: // 64-bit
                    textBoxNetworkKey.MaxLength = 16; //8 bytes
                    break;
                case 1: // 128-bit
                    textBoxNetworkKey.MaxLength = 32; //16 bytes
                    break;
                case 2: // 256-bit
                    textBoxNetworkKey.MaxLength = 64; //32 bytes
                    break;
                case 3: // 512-bit
                    textBoxNetworkKey.MaxLength = 128; //64 bytes
                    break;
                case 4: // 1024-bit
                    textBoxNetworkKey.MaxLength = 256; //128 bytes
                    break;
                case 5: // 2048-bit
                    textBoxNetworkKey.MaxLength = 512; //256 bytes
                    break;
            }
            if (textBoxNetworkKey.Text.Length > textBoxNetworkKey.MaxLength)
            {
                textBoxNetworkKey.Text = textBoxNetworkKey.Text.Substring(0, textBoxNetworkKey.MaxLength);
            }
        }

        private void radioButtonIPv4IPAddressDynamic_CheckedChanged(object sender, EventArgs e)
        {
            bool fEnable = radioButtonIPv4IPAddressDynamic.Checked;

            if (!fEnable)
            {
                radioButtonIPv4DnsAddressesDynamic.Enabled = false;
                radioButtonIPv4DnsAddressesStatic.Checked = true;
            }
            else
            {
                radioButtonIPv4DnsAddressesDynamic.Enabled = true;
            }

            textBoxIPv4IPAddress.Enabled = !fEnable;
            textBoxIPv4SubnetMask.Enabled = !fEnable;
            textBoxIPv4DefaultGateway.Enabled = !fEnable;
        }

        private void radioButtonIPv4DnsAddressesDynamic_CheckedChanged(object sender, EventArgs e)
        {
            bool fEnable = radioButtonIPv4DnsAddressesDynamic.Checked;

            textBoxIPv4DnsPrimary.Enabled = !fEnable;
            textBoxIPv4DnsSecondary.Enabled = !fEnable;
        }

        private void radioButtonIPv6IPAddressDynamic_CheckedChanged(object sender, EventArgs e)
        {
            bool fEnable = radioButtonIPv6IPAddressDynamic.Checked;

            if (!fEnable)
            {
                radioButtonIPv6DnsAddressesDynamic.Enabled = false;
                radioButtonIPv6DnsAddressesStatic.Checked = true;
            }
            else
            {
                radioButtonIPv6DnsAddressesDynamic.Enabled = true;
            }

            textBoxIPv6IPAddress.Enabled = !fEnable;
            textBoxIPv6SubnetPrefixLength.Enabled = !fEnable;
            textBoxIPv6DefaultGateway.Enabled = !fEnable;
        }

        private void radioButtonIPv6DnsAddressesDynamic_CheckedChanged(object sender, EventArgs e)
        {
            bool fEnable = radioButtonIPv6DnsAddressesDynamic.Checked;

            textBoxIPv6DnsPrimary.Enabled = !fEnable;
            textBoxIPv6DnsSecondary.Enabled = !fEnable;
        }

    }
}