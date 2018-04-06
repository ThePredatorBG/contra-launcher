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
using System.Diagnostics;
using Microsoft.Win32;

namespace Contra
{
    public partial class VPNForm : Form
    {
        public VPNForm()
        {
            InitializeComponent();
            buttonVPNdebuglog.TabStop = false;
            buttonVPNinvkey.TabStop = false;
            buttonVPNconsole.TabStop = false;

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

        private bool TincFound;

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

        //Form1 Form1_Instance = new Form1();
        Form1 form1;
        public VPNForm(Form1 frm)
        {
            form1 = frm;
            InitializeComponent();

        }

        private void buttonVPNdebuglog_Click(object sender, EventArgs e)
        {
            try
            {
                GetTincInstalledPath_Registry_OpenDebugLog();
            }
            catch (Exception)
            {
                GetTincInstalledPath_User_OpenDebugLog();
            }
        }

        public void GetTincInstalledPath_Registry_EnterInvKey()
        {
            GetTincInstalledPath();
            if (Directory.Exists(GetTincInstalledPath() + @"\contravpn"))
            {
                MessageBox.Show("Found existing \"contravpn\" folder, looks like you have already been invited.");
            }
            else if (!Directory.Exists(GetTincInstalledPath() + @"\contravpn"))
            {
                MessageBox.Show("You can request an invite key on our Discord's #contravpn channel.");
//                Process tinc = new Process();
//                tinc.StartInfo.Arguments = "join";
//                tinc.StartInfo.FileName = "tinc.exe";
                InvitePanel.Show();
//                GetTincInstalledPath().Replace("\"", "");
//                tinc.StartInfo.WorkingDirectory = Path.GetDirectoryName(GetTincInstalledPath() + @"\");
//                tinc.Start();
            }
        }

        public void GetTincInstalledPath_Registry_OpenConsole()
        {
            GetTincInstalledPath();
            Process tinc = new Process();
            tinc.StartInfo.Arguments = "-n contravpn";
            tinc.StartInfo.FileName = "tinc.exe";
            GetTincInstalledPath().Replace("\"", "");
            tinc.StartInfo.WorkingDirectory = Path.GetDirectoryName(GetTincInstalledPath() + @"\");
            if (Directory.Exists(GetTincInstalledPath() + @"\contravpn"))
            {
                tinc.Start();
            }
            else if (!Directory.Exists(GetTincInstalledPath() + @"\contravpn"))
            {
                MessageBox.Show("The \"contravpn\" folder does not exist yet. Most commands will not execute.");
                tinc.Start();
            }
        }

        public void GetTincInstalledPath_Registry_OpenDebugLog()
        {
            GetTincInstalledPath();
            Process tinc = new Process();
            tinc.StartInfo.Arguments = "-n contravpn log 3";
            tinc.StartInfo.FileName = "tinc.exe";
            GetTincInstalledPath().Replace("\"", "");
            tinc.StartInfo.WorkingDirectory = Path.GetDirectoryName(GetTincInstalledPath() + @"\");
            if (Directory.Exists(GetTincInstalledPath() + @"\contravpn"))
            {
                tinc.Start();
            }
            else if (!Directory.Exists(GetTincInstalledPath() + @"\contravpn"))
            {
                MessageBox.Show("The \"contravpn\" folder does not exist yet. Most commands will not execute.");
                tinc.Start();
            }
        }

        private void buttonVPNinvkey_Click(object sender, EventArgs e)
        {
            try
            {
                GetTincInstalledPath_Registry_EnterInvKey();
            }
            catch (Exception)
            {
                GetTincInstalledPath_User_EnterInvKey();
            }
        }

        public void GetTincInstalledPath_User_EnterInvKey()
        {
            TincFound = Properties.Settings.Default.TincFound;
            var TincInstalledPath = string.Empty;
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (TincFound == false)
            {
                MessageBox.Show("\"tinc.exe\" not found! Select tinc installation directory.", "Error");
                fbd.Description = "Select tinc installation directory.";
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    var tincpath = fbd.SelectedPath;
                    TincInstalledPath = tincpath;
                    Properties.Settings.Default.tincpath = fbd.SelectedPath;
                    Properties.Settings.Default.Save();
                    Process tinc = new Process();
                    tinc.StartInfo.Arguments = "join";
                    tinc.StartInfo.FileName = "tinc.exe";
                    tinc.StartInfo.WorkingDirectory = Path.GetDirectoryName(TincInstalledPath + @"\tinc.exe");
                    if (File.Exists(tincpath + @"\tinc.exe"))
                    {
                        if (Directory.Exists(tincpath + @"\contravpn"))
                        {
                            MessageBox.Show("Found existing \"contravpn\" folder, looks like you have already been invited.");
                        }
                        else if (!Directory.Exists(tincpath + @"\contravpn"))
                        {
                            MessageBox.Show("You can request an invite key on our Discord's #contravpn channel.");
                            InvitePanel.Show(); //tinc.Start();
                            Properties.Settings.Default.TincFound = true;
                            Properties.Settings.Default.Save();
                        }
                    }
                    else if (!File.Exists(tincpath + @"\tinc.exe"))
                    {
                        MessageBox.Show("\"tinc.exe\" not found there!", "Error");
                        Properties.Settings.Default.TincFound = false;
                        Properties.Settings.Default.Save();
                    }
                }
            }
            else if ((TincFound == true))
            {
                Process tinc = new Process();
                tinc.StartInfo.Arguments = "join";
                tinc.StartInfo.FileName = "tinc.exe";
                tinc.StartInfo.WorkingDirectory = Path.GetDirectoryName(tincpath + @"\tinc.exe");
                if (File.Exists(tincpath + @"\tinc.exe"))
                {
                    if (Directory.Exists(tincpath + @"\contravpn"))
                    {
                        MessageBox.Show("Found existing \"contravpn\" folder, looks like you have already been invited.");
                    }
                    else if (!Directory.Exists(tincpath + @"\contravpn"))
                    {
                        MessageBox.Show("To receive an invite key, mention @tet on Discord and request one.");
                        tinc.Start();
                        Properties.Settings.Default.TincFound = true;
                        Properties.Settings.Default.Save();
                    }
                }
                else if (!File.Exists(tincpath + @"\tinc.exe"))
                {
                    MessageBox.Show("\"tinc.exe\" not found there!", "Error");
                    Properties.Settings.Default.TincFound = false;
                    Properties.Settings.Default.Save();
                }
            }
        }

        public void GetTincInstalledPath_User_OpenConsole()
        {
            TincFound = Properties.Settings.Default.TincFound;
            var TincInstalledPath = string.Empty;
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (TincFound == false)
            {
                MessageBox.Show("\"tinc.exe\" not found! Select tinc installation directory.", "Error");
                fbd.Description = "Select tinc installation directory.";
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    var tincpath = fbd.SelectedPath;
                    TincInstalledPath = tincpath;
                    Properties.Settings.Default.tincpath = fbd.SelectedPath;
                    Properties.Settings.Default.Save();
                    Process tinc = new Process();
                    tinc.StartInfo.Arguments = "-n contravpn";
                    tinc.StartInfo.FileName = "tinc.exe";
                    tinc.StartInfo.WorkingDirectory = Path.GetDirectoryName(TincInstalledPath + @"\tinc.exe");
                    if (File.Exists(tincpath + @"\tinc.exe"))
                    {
                        if (Directory.Exists(tincpath + @"\contravpn"))
                        {
                            tinc.Start();
                            Properties.Settings.Default.TincFound = true;
                            Properties.Settings.Default.Save();
                        }
                        else if (!Directory.Exists(tincpath + @"\contravpn"))
                        {
                            MessageBox.Show("The \"contravpn\" folder does not exist yet. Most commands will not execute.");
                            tinc.Start();
                            Properties.Settings.Default.TincFound = true;
                            Properties.Settings.Default.Save();
                        }
                    }
                    else
                    {
                        MessageBox.Show("\"tinc.exe\" not found there!", "Error");
                        Properties.Settings.Default.TincFound = false;
                        Properties.Settings.Default.Save();
                    }
                }
            }
            else if ((TincFound == true))
            {
                Process tinc = new Process();
                tinc.StartInfo.Arguments = "-n contravpn";
                tinc.StartInfo.FileName = "tinc.exe";
                tinc.StartInfo.WorkingDirectory = Path.GetDirectoryName(tincpath + @"\tinc.exe");
                if (File.Exists(tincpath + @"\tinc.exe"))
                {
                    if (Directory.Exists(tincpath + @"\contravpn"))
                    {
                        tinc.Start();
                        Properties.Settings.Default.TincFound = true;
                        Properties.Settings.Default.Save();
                    }
                    else if (!Directory.Exists(tincpath + @"\contravpn"))
                    {
                        MessageBox.Show("The \"contravpn\" folder does not exist yet. Most commands will not execute.");
                        tinc.Start();
                        Properties.Settings.Default.TincFound = true;
                        Properties.Settings.Default.Save();
                    }
                }
                else
                {
                    MessageBox.Show("\"tinc.exe\" not found there!", "Error");
                    Properties.Settings.Default.TincFound = false;
                    Properties.Settings.Default.Save();
                }
            }
        }

        public void GetTincInstalledPath_User_OpenDebugLog()
        {
            TincFound = Properties.Settings.Default.TincFound;
            var TincInstalledPath = string.Empty;
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (TincFound == false)
            {
                MessageBox.Show("\"tinc.exe\" not found! Select tinc installation directory.", "Error");
                fbd.Description = "Select tinc installation directory.";
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    var tincpath = fbd.SelectedPath;
                    TincInstalledPath = tincpath;
                    Properties.Settings.Default.tincpath = fbd.SelectedPath;
                    Properties.Settings.Default.Save();
                    Process tinc = new Process();
                    tinc.StartInfo.Arguments = "-n contravpn log 3";
                    tinc.StartInfo.FileName = "tinc.exe";
                    tinc.StartInfo.WorkingDirectory = Path.GetDirectoryName(TincInstalledPath + @"\tinc.exe");
                    if (File.Exists(tincpath + @"\tinc.exe"))
                    {
                        if (Directory.Exists(tincpath + @"\contravpn"))
                        {
                            tinc.Start();
                            Properties.Settings.Default.TincFound = true;
                            Properties.Settings.Default.Save();
                        }
                        else if (!Directory.Exists(tincpath + @"\contravpn"))
                        {
                            MessageBox.Show("The \"contravpn\" folder does not exist yet. Most commands will not execute.");
                            tinc.Start();
                            Properties.Settings.Default.TincFound = true;
                            Properties.Settings.Default.Save();
                        }
                    }
                    else
                    {
                        MessageBox.Show("\"tinc.exe\" not found there!", "Error");
                        Properties.Settings.Default.TincFound = false;
                        Properties.Settings.Default.Save();
                    }
                }
            }
            else if ((TincFound == true))
            {
                Process tinc = new Process();
                tinc.StartInfo.Arguments = "-n contravpn";
                tinc.StartInfo.FileName = "tinc.exe";
                tinc.StartInfo.WorkingDirectory = Path.GetDirectoryName(tincpath + @"\tinc.exe");
                if (File.Exists(tincpath + @"\tinc.exe"))
                {
                    if (Directory.Exists(tincpath + @"\contravpn"))
                    {
                        tinc.Start();
                        Properties.Settings.Default.TincFound = true;
                        Properties.Settings.Default.Save();
                    }
                    else if (!Directory.Exists(tincpath + @"\contravpn"))
                    {
                        MessageBox.Show("The \"contravpn\" folder does not exist yet. Most commands will not execute.");
                        tinc.Start();
                        Properties.Settings.Default.TincFound = true;
                        Properties.Settings.Default.Save();
                    }
                }
                else
                {
                    MessageBox.Show("\"tinc.exe\" not found there!", "Error");
                    Properties.Settings.Default.TincFound = false;
                    Properties.Settings.Default.Save();
                }
            }
        }

        private void buttonVPNconsole_Click(object sender, EventArgs e)
        {
            try
            {
                GetTincInstalledPath_Registry_OpenConsole();
            }
            catch (Exception)
            {
                GetTincInstalledPath_User_OpenConsole(); //Form1_Instance.GetTincInstalledPath_User_OpenConsole();
            }
        }

        private void buttonVPNinvkey_MouseEnter(object sender, EventArgs e)
        {
            buttonVPNinvkey.BackgroundImage = (System.Drawing.Image)(Properties.Resources._button_invite_tr);
            buttonVPNinvkey.ForeColor = SystemColors.ButtonHighlight;
            buttonVPNinvkey.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }
        private void buttonVPNinvkey_MouseLeave(object sender, EventArgs e)
        {
            buttonVPNinvkey.BackgroundImage = (System.Drawing.Image)(Properties.Resources._button_invite);
            buttonVPNinvkey.ForeColor = SystemColors.ButtonHighlight;
            buttonVPNinvkey.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }
        private void buttonVPNinvkey_MouseDown(object sender, MouseEventArgs e)
        {
            buttonVPNinvkey.BackgroundImage = (System.Drawing.Image)(Properties.Resources._button_sm_highlight);
            buttonVPNinvkey.ForeColor = SystemColors.ButtonHighlight;
            buttonVPNinvkey.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }

        private void buttonVPNconsole_MouseEnter(object sender, EventArgs e)
        {
            buttonVPNconsole.BackgroundImage = (System.Drawing.Image)(Properties.Resources._button_console_tr);
            buttonVPNconsole.ForeColor = SystemColors.ButtonHighlight;
            buttonVPNconsole.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }
        private void buttonVPNconsole_MouseLeave(object sender, EventArgs e)
        {
            buttonVPNconsole.BackgroundImage = (System.Drawing.Image)(Properties.Resources._button_console);
            buttonVPNconsole.ForeColor = SystemColors.ButtonHighlight;
            buttonVPNconsole.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }
        private void buttonVPNconsole_MouseDown(object sender, MouseEventArgs e)
        {
            buttonVPNconsole.BackgroundImage = (System.Drawing.Image)(Properties.Resources._button_sm_highlight);
            buttonVPNconsole.ForeColor = SystemColors.ButtonHighlight;
            buttonVPNconsole.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }

        private void buttonVPNdebuglog_MouseEnter(object sender, EventArgs e)
        {
            buttonVPNdebuglog.BackgroundImage = (System.Drawing.Image)(Properties.Resources._button_log_tr);
            buttonVPNdebuglog.ForeColor = SystemColors.ButtonHighlight;
            buttonVPNdebuglog.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }
        private void buttonVPNdebuglog_MouseLeave(object sender, EventArgs e)
        {
            buttonVPNdebuglog.BackgroundImage = (System.Drawing.Image)(Properties.Resources._button_log);
            buttonVPNdebuglog.ForeColor = SystemColors.ButtonHighlight;
            buttonVPNdebuglog.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }
        private void buttonVPNdebuglog_MouseDown(object sender, MouseEventArgs e)
        {
            buttonVPNdebuglog.BackgroundImage = (System.Drawing.Image)(Properties.Resources._button_sm_highlight);
            buttonVPNdebuglog.ForeColor = SystemColors.ButtonHighlight;
            buttonVPNdebuglog.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }

        private void buttonVPNinvclose_Click(object sender, EventArgs e)
        {
            InvitePanel.Visible = false;
        }

       // string InviteInput;

        private void buttonVPNinvOK_Click(object sender, EventArgs e)
        {
            Process tinc = new Process();
            tinc.StartInfo.Arguments = "join" + invkeytextBox.Text;
            if (invkeytextBox.Text.StartsWith("contra.nsupdate.info"))
            {
                tinc.StartInfo.FileName = "tinc.exe";
                GetTincInstalledPath().Replace("\"", "");
                tinc.StartInfo.WorkingDirectory = Path.GetDirectoryName(GetTincInstalledPath() + @"\");
                tinc.Start();
            }
            else MessageBox.Show("Invalid input.");
        }

        private void invkeytextBox_TextChanged(object sender, EventArgs e)
        {
            buttonVPNinvOK.Enabled = true;
         //   string InviteInput = invkeytextBox.Text;
        }
    }
}
