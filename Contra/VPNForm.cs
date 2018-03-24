using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace Contra
{
    public partial class VPNForm : Form
    {
        public VPNForm()
        {
            InitializeComponent();

            if ((File.Exists(GetTincInstalledPath() + "/contravpn/tinc.conf")) && ((File.ReadAllText(GetTincInstalledPath() + "/contravpn/tinc.conf").Contains("UPnP")) == false))
            {
                string AppendUPnP = Environment.NewLine + "UPnP = no";
                File.AppendAllText(GetTincInstalledPath() + "/contravpn/tinc.conf", AppendUPnP);
            }
            else if ((File.Exists(tincpath + "/contravpn/tinc.conf")) && ((File.ReadAllText(tincpath + "/contravpn/tinc.conf").Contains("UPnP")) == false))
            {
                string AppendUPnP = Environment.NewLine + "UPnP = no";
                File.AppendAllText(tincpath + "/contravpn/tinc.conf", AppendUPnP);
            }

            if ((File.Exists(GetTincInstalledPath() + "/contravpn/tinc.conf")) && ((File.ReadAllText(GetTincInstalledPath() + "/contravpn/tinc.conf").Contains("AutoConnect")) == false))
            {
                string AppendUPnP = Environment.NewLine + "AutoConnect = no";
                File.AppendAllText(GetTincInstalledPath() + "/contravpn/tinc.conf", AppendUPnP);
            }
            else if ((File.Exists(tincpath + "/contravpn/tinc.conf")) && ((File.ReadAllText(tincpath + "/contravpn/tinc.conf").Contains("AutoConnect")) == false))
            {
                string AppendUPnP = Environment.NewLine + "AutoConnect = no";
                File.AppendAllText(tincpath + "/contravpn/tinc.conf", AppendUPnP);
            }

            if ((File.Exists(GetTincInstalledPath() + "/contravpn/tinc.conf")) && ((File.ReadAllText(GetTincInstalledPath() + "/contravpn/tinc.conf").Contains("UPnP = no"))))
            {
                UPnPCheckBox.Checked = false;
            }
            else if ((File.Exists(GetTincInstalledPath() + "/contravpn/tinc.conf")) && (File.ReadAllText(GetTincInstalledPath() + "/contravpn/tinc.conf").Contains("UPnP = yes")))
            {
                UPnPCheckBox.Checked = true;
            }
            else if ((File.Exists(tincpath + "/contravpn/tinc.conf")) && ((File.ReadAllText(tincpath + "/contravpn/tinc.conf").Contains("UPnP = no"))))
            {
                UPnPCheckBox.Checked = false;
            }
            else if ((File.Exists(tincpath + "/contravpn/tinc.conf")) && (File.ReadAllText(tincpath + "/contravpn/tinc.conf").Contains("UPnP = yes")))
            {
                UPnPCheckBox.Checked = true;
            }

            if ((File.Exists(GetTincInstalledPath() + "/contravpn/tinc.conf")) && (File.ReadAllText(GetTincInstalledPath() + "/contravpn/tinc.conf").Contains("AutoConnect = no")))
            {
                AutoConnectCheckBox.Checked = false;
            }
            else if ((File.Exists(GetTincInstalledPath() + "/contravpn/tinc.conf")) && (File.ReadAllText(GetTincInstalledPath() + "/contravpn/tinc.conf").Contains("AutoConnect = yes")))
            {
                AutoConnectCheckBox.Checked = true;
            }
            else if ((File.Exists(tincpath + "/contravpn/tinc.conf")) && (File.ReadAllText(tincpath + "/contravpn/tinc.conf").Contains("AutoConnect = no")))
            {
                AutoConnectCheckBox.Checked = false;
            }
            else if ((File.Exists(tincpath + "/contravpn/tinc.conf")) && (File.ReadAllText(tincpath + "/contravpn/tinc.conf").Contains("AutoConnect = yes")))
            {
                AutoConnectCheckBox.Checked = true;
            }
        }

        Form1 Form1_Instance = new Form1();

        const int WM_NCLBUTTONDBLCLK = 0xA3;
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_NCLBUTTONDBLCLK)
                return;

            base.WndProc(ref m);
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }
            base.WndProc(ref m);
        }

        //**********TINC CODE START**********

        [DllImport("user32.dll")]
        public static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);

        //include SendMessage
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int uMsg, int wParam, string lParam);

        //this is a constant indicating the window that we want to send a text message
        const int WM_SETTEXT = 0X000C;

        private string FindByDisplayName(RegistryKey parentKey, string name)
        {
            string[] nameList = parentKey.GetSubKeyNames();
            for (int i = 0; i < nameList.Length; i++)
            {
                RegistryKey regKey = parentKey.OpenSubKey(nameList[i]);
                try
                {
                    if (regKey.GetValue("DisplayName").ToString() == name)
                    {
                        return regKey.GetValue("InstallLocation").ToString();
                    }
                }
                catch { }
            }
            return "";
        }

        public static string tincpath;

        public string GetTincInstalledPath()
        {
            var TincInstalledPath = string.Empty;
            var TincRegistryPath = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\tinc");
            if (TincRegistryPath != null)
            {
                TincInstalledPath = TincRegistryPath.GetValue(null, string.Empty) as string;
            }
            if (string.IsNullOrEmpty(TincInstalledPath) || !Directory.Exists(TincInstalledPath))
            {
                TincRegistryPath = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\WOW6432Node\tinc");
                if (TincRegistryPath != null)
                {
                    TincInstalledPath = TincRegistryPath.GetValue("", string.Empty) as string;
                }
            }
            //if (Properties.Settings.Default.TincFound == true)
            //{
            //    tincpath = TincInstalledPath;
            //}
            return TincInstalledPath;
        }

        private void OnApplicationExit(object sender, EventArgs e) //VPNWindowExit
        {
            this.Close();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            OnApplicationExit(sender, e);
        }

        private void UPnPCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if ((File.Exists(GetTincInstalledPath() + "/contravpn/tinc.conf")))
            {
                GetTincInstalledPath();
                string tincconf = File.ReadAllText(GetTincInstalledPath() + "/contravpn/tinc.conf");
                if (UPnPCheckBox.Checked)
                {
                    tincconf = tincconf.Replace("UPnP = no", "UPnP = yes");
                    File.WriteAllText(GetTincInstalledPath() + "/contravpn/tinc.conf", tincconf);
                }
                else if (!UPnPCheckBox.Checked)
                {
                    tincconf = tincconf.Replace("UPnP = yes", "UPnP = no");
                    File.WriteAllText(GetTincInstalledPath() + "/contravpn/tinc.conf", tincconf);
                }
            }
            else if (File.Exists(tincpath + "/contravpn/tinc.conf"))
            {
                string tincconf = File.ReadAllText(tincpath + "/contravpn/tinc.conf");
                if (UPnPCheckBox.Checked)
                {
                    tincconf = tincconf.Replace("UPnP = no", "UPnP = yes");
                    File.WriteAllText(tincpath + "/contravpn/tinc.conf", tincconf);
                }
                else if (!UPnPCheckBox.Checked)
                {
                    tincconf = tincconf.Replace("UPnP = yes", "UPnP = no");
                    File.WriteAllText(tincpath + "/contravpn/tinc.conf", tincconf);
                }
            }
            // else MessageBox.Show("\"tinc.conf\" not found! Toggling UPnP on/off has no effect.", "Error");
        }

        private void AutoConnectCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if ((File.Exists(GetTincInstalledPath() + "/contravpn/tinc.conf")))
            {
                GetTincInstalledPath();
                string tincconf = File.ReadAllText(GetTincInstalledPath() + "/contravpn/tinc.conf");
                if (AutoConnectCheckBox.Checked)
                {
                    tincconf = tincconf.Replace("AutoConnect = no", "AutoConnect = yes");
                    File.WriteAllText(GetTincInstalledPath() + "/contravpn/tinc.conf", tincconf);
                }
                else if (!AutoConnectCheckBox.Checked)
                {
                    tincconf = tincconf.Replace("AutoConnect = yes", "AutoConnect = no");
                    File.WriteAllText(GetTincInstalledPath() + "/contravpn/tinc.conf", tincconf);
                }
            }
            else if (File.Exists(tincpath + "/contravpn/tinc.conf"))
            {
                string tincconf = File.ReadAllText(tincpath + "/contravpn/tinc.conf");
                if (AutoConnectCheckBox.Checked)
                {
                    tincconf = tincconf.Replace("AutoConnect = no", "AutoConnect = yes");
                    File.WriteAllText(tincpath + "/contravpn/tinc.conf", tincconf);
                }
                else if (!AutoConnectCheckBox.Checked)
                {
                    tincconf = tincconf.Replace("AutoConnect = yes", "AutoConnect = no");
                    File.WriteAllText(tincpath + "/contravpn/tinc.conf", tincconf);
                }
            }
            //else MessageBox.Show("\"tinc.conf\" not found! Toggling AutoConnect on/off has no effect.", "Error");
        }

        private void buttonVPNdebuglog_Click(object sender, EventArgs e)
        {
            try
            {
                Form1_Instance.GetTincInstalledPath_Registry_OpenDebugLog();
            }
            catch (Exception)
            {
                Form1_Instance.GetTincInstalledPath_User_OpenDebugLog();
            }
        }

        private void buttonVPNinvkey_Click(object sender, EventArgs e)
        {
            try
            {
                Form1_Instance.GetTincInstalledPath_Registry_EnterInvKey();
            }
            catch (Exception)
            {
                Form1_Instance.GetTincInstalledPath_User_EnterInvKey();
            }
        }

        private void buttonVPNconsole_Click(object sender, EventArgs e)
        {
            try
            {
                Form1_Instance.GetTincInstalledPath_Registry_OpenConsole();
            }
            catch (Exception)
            {
                Form1_Instance.GetTincInstalledPath_User_OpenConsole();
            }
        }
    }
}
