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

            if (Globals.GB_Checked == true)
            {
                toolTip2.SetToolTip(UPnPCheckBox, "Search for local UPnP-IGD devices, this can improve connectivity if UPnP is enabled on your router.\nRequires miniupnpc support (tinc distributed by Contra has this, official does not).");
                toolTip2.SetToolTip(AutoConnectCheckBox, "Automatically set up meta connections to other nodes.\nThis allows you to retain connection with other players even if contravpn node goes down.\nOnly works with nodes that have open ports.");
            }
            else if (Globals.BG_Checked == true)
            {
                toolTip2.SetToolTip(UPnPCheckBox, "Търсете за локални UPnP-IGD устройства. Това може да подобри свързаността, ако UPnP е включен на вашия рутер.\nИзисква поддръжка на miniupnpc (tinc разпространен от Contra има това, официалният - не).");
                toolTip2.SetToolTip(AutoConnectCheckBox, "Автоматично настройване на мета-връзки към други възли.\nТова Ви позволява да запазите връзката си с другите играчи, дори когато contravpn възелът е офлайн.\nРаботи само с възли, които имат отворени портове.");
            }

            if ((File.Exists(GetTincInstalledPath() + "/contravpn/tinc.conf")) && ((File.ReadAllText(GetTincInstalledPath() + "/contravpn/tinc.conf").Contains("UPnP")) == false))
            {
                string AppendUPnP = Environment.NewLine + "UPnP = no";
                File.AppendAllText(GetTincInstalledPath() + "/contravpn/tinc.conf", AppendUPnP);
            }
            else if ((File.Exists(Globals.tincpath + "/contravpn/tinc.conf")) && ((File.ReadAllText(Globals.tincpath + "/contravpn/tinc.conf").Contains("UPnP")) == false))
            {
                string AppendUPnP = Environment.NewLine + "UPnP = no";
                File.AppendAllText(Globals.tincpath + "/contravpn/tinc.conf", AppendUPnP);
            }

            if ((File.Exists(GetTincInstalledPath() + "/contravpn/tinc.conf")) && ((File.ReadAllText(GetTincInstalledPath() + "/contravpn/tinc.conf").Contains("AutoConnect")) == false))
            {
                string AppendUPnP = Environment.NewLine + "AutoConnect = no";
                File.AppendAllText(GetTincInstalledPath() + "/contravpn/tinc.conf", AppendUPnP);
            }
            else if ((File.Exists(Globals.tincpath + "/contravpn/tinc.conf")) && ((File.ReadAllText(Globals.tincpath + "/contravpn/tinc.conf").Contains("AutoConnect")) == false))
            {
                string AppendUPnP = Environment.NewLine + "AutoConnect = no";
                File.AppendAllText(Globals.tincpath + "/contravpn/tinc.conf", AppendUPnP);
            }

            if ((File.Exists(GetTincInstalledPath() + "/contravpn/tinc.conf")) && ((File.ReadAllText(GetTincInstalledPath() + "/contravpn/tinc.conf").Contains("UPnP = no"))))
            {
                UPnPCheckBox.Checked = false;
            }
            else if ((File.Exists(GetTincInstalledPath() + "/contravpn/tinc.conf")) && (File.ReadAllText(GetTincInstalledPath() + "/contravpn/tinc.conf").Contains("UPnP = yes")))
            {
                UPnPCheckBox.Checked = true;
            }
            else if ((File.Exists(Globals.tincpath + "/contravpn/tinc.conf")) && ((File.ReadAllText(Globals.tincpath + "/contravpn/tinc.conf").Contains("UPnP = no"))))
            {
                UPnPCheckBox.Checked = false;
            }
            else if ((File.Exists(Globals.tincpath + "/contravpn/tinc.conf")) && (File.ReadAllText(Globals.tincpath + "/contravpn/tinc.conf").Contains("UPnP = yes")))
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
            else if ((File.Exists(Globals.tincpath + "/contravpn/tinc.conf")) && (File.ReadAllText(Globals.tincpath + "/contravpn/tinc.conf").Contains("AutoConnect = no")))
            {
                AutoConnectCheckBox.Checked = false;
            }
            else if ((File.Exists(Globals.tincpath + "/contravpn/tinc.conf")) && (File.ReadAllText(Globals.tincpath + "/contravpn/tinc.conf").Contains("AutoConnect = yes")))
            {
                AutoConnectCheckBox.Checked = true;
            }
        }

        public string getCurrentCulture()
        {
            var culture = System.Globalization.CultureInfo.CurrentCulture;
            string cultureStr = culture.ToString();
            return cultureStr;
        }

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
            else if (File.Exists(Globals.tincpath + "/contravpn/tinc.conf"))
            {
                string tincconf = File.ReadAllText(Globals.tincpath + "/contravpn/tinc.conf");
                if (UPnPCheckBox.Checked)
                {
                    tincconf = tincconf.Replace("UPnP = no", "UPnP = yes");
                    File.WriteAllText(Globals.tincpath + "/contravpn/tinc.conf", tincconf);
                }
                else if (!UPnPCheckBox.Checked)
                {
                    tincconf = tincconf.Replace("UPnP = yes", "UPnP = no");
                    File.WriteAllText(Globals.tincpath + "/contravpn/tinc.conf", tincconf);
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
            else if (File.Exists(Globals.tincpath + "/contravpn/tinc.conf"))
            {
                string tincconf = File.ReadAllText(Globals.tincpath + "/contravpn/tinc.conf");
                if (AutoConnectCheckBox.Checked)
                {
                    tincconf = tincconf.Replace("AutoConnect = no", "AutoConnect = yes");
                    File.WriteAllText(Globals.tincpath + "/contravpn/tinc.conf", tincconf);
                }
                else if (!AutoConnectCheckBox.Checked)
                {
                    tincconf = tincconf.Replace("AutoConnect = yes", "AutoConnect = no");
                    File.WriteAllText(Globals.tincpath + "/contravpn/tinc.conf", tincconf);
                }
            }
            //else MessageBox.Show("\"tinc.conf\" not found! Toggling AutoConnect on/off has no effect.", "Error");
        }

        //Form1 Form1_Instance = new Form1();
        Form1 form1;
        public VPNForm(Form1 form1)
        {
            //form1 = frm;
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
                if (getCurrentCulture() == "en-US")
                {
                    MessageBox.Show("Found existing \"contravpn\" folder, looks like you have already been invited.");
                }
                else if (getCurrentCulture() == "ru-RU")
                {
                    MessageBox.Show("Found existing \"contravpn\" folder, looks like you have already been invited.");
                }
                else if (getCurrentCulture() == "bg-BG")
                {
                    MessageBox.Show("Намерена е съществуваща папка с име \"contravpn\". Изглежда, че вече сте били поканени.");
                }
            }
            else// if (!Directory.Exists(GetTincInstalledPath() + @"\contravpn"))
            {
                if (getCurrentCulture() == "en-US")
                {
                    MessageBox.Show("You can request an invite key on our Discord's #contravpn channel.");
                }
                else if (getCurrentCulture() == "ru-RU")
                {
                    MessageBox.Show("You can request an invite key on our Discord's #contravpn channel.");
                }
                else if (getCurrentCulture() == "bg-BG")
                {
                    MessageBox.Show("Можете да поискате покана в #contravpn канала ни в Discord.");
                }
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
            else
            {
                if (getCurrentCulture() == "en-US")
                {
                    MessageBox.Show("The \"contravpn\" folder does not exist yet. Most commands will not execute.");
                }
                else if (getCurrentCulture() == "ru-RU")
                {
                    MessageBox.Show("The \"contravpn\" folder does not exist yet. Most commands will not execute.");
                }
                else if (getCurrentCulture() == "bg-BG")
                {
                    MessageBox.Show("\"contravpn\" папката още не съществува. Повечето команди няма да се изпълнят.");
                }
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
            else
            {
                if (getCurrentCulture() == "en-US")
                {
                    MessageBox.Show("The \"contravpn\" folder does not exist yet. Most commands will not execute.");
                }
                else if (getCurrentCulture() == "ru-RU")
                {
                    MessageBox.Show("The \"contravpn\" folder does not exist yet. Most commands will not execute.");
                }
                else if (getCurrentCulture() == "bg-BG")
                {
                    MessageBox.Show("\"contravpn\" папката още не съществува. Повечето команди няма да се изпълнят.");
                }
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
            Globals.TincFound = Properties.Settings.Default.TincFound;
            //var TincInstalledPath = string.Empty;
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (Globals.TincFound == false)
            {
                MessageBox.Show("\"tinc.exe\" not found! Select tinc installation directory.", "Error");
                fbd.Description = "Select tinc installation directory.";
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    var tincpath = fbd.SelectedPath;
                    //TincInstalledPath = tincpath;
                    Properties.Settings.Default.tincpath = fbd.SelectedPath;
                    Properties.Settings.Default.Save();
                    Process tinc = new Process();
                    tinc.StartInfo.Arguments = "join";
                    tinc.StartInfo.FileName = "tinc.exe";
                    tinc.StartInfo.WorkingDirectory = Path.GetDirectoryName(Globals.tincpath + @"\tinc.exe");
                    if (File.Exists(Globals.tincpath + @"\tinc.exe"))
                    {
                        if (Directory.Exists(Globals.tincpath + @"\contravpn"))
                        {
                            MessageBox.Show("Found existing \"contravpn\" folder, looks like you have already been invited.");
                        }
                        else if (!Directory.Exists(Globals.tincpath + @"\contravpn"))
                        {
                            MessageBox.Show("You can request an invite key on our Discord's #contravpn channel.");
                            InvitePanel.Show(); //tinc.Start();
                            Properties.Settings.Default.TincFound = true;
                            Properties.Settings.Default.Save();
                        }
                    }
                    else if (!File.Exists(Globals.tincpath + @"\tinc.exe"))
                    {
                        MessageBox.Show("\"tinc.exe\" not found there!", "Error");
                        Properties.Settings.Default.TincFound = false;
                        Properties.Settings.Default.Save();
                    }
                }
            }
            else if ((Globals.TincFound == true))
            {
                Process tinc = new Process();
                tinc.StartInfo.Arguments = "join";
                tinc.StartInfo.FileName = "tinc.exe";
                tinc.StartInfo.WorkingDirectory = Path.GetDirectoryName(Globals.tincpath + @"\tinc.exe");
                if (File.Exists(Globals.tincpath + @"\tinc.exe"))
                {
                    if (Directory.Exists(Globals.tincpath + @"\contravpn"))
                    {
                        MessageBox.Show("Found existing \"contravpn\" folder, looks like you have already been invited.");
                    }
                    else if (!Directory.Exists(Globals.tincpath + @"\contravpn"))
                    {
                        MessageBox.Show("To receive an invite key, mention @tet on Discord and request one.");
                        tinc.Start();
                        Properties.Settings.Default.TincFound = true;
                        Properties.Settings.Default.Save();
                    }
                }
                else if (!File.Exists(Globals.tincpath + @"\tinc.exe"))
                {
                    MessageBox.Show("\"tinc.exe\" not found there!", "Error");
                    Properties.Settings.Default.TincFound = false;
                    Properties.Settings.Default.Save();
                }
            }
        }

        public void GetTincInstalledPath_User_OpenConsole()
        {
            Globals.TincFound = Properties.Settings.Default.TincFound;
            //var TincInstalledPath = string.Empty;
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (Globals.TincFound == false)
            {
                MessageBox.Show("\"tinc.exe\" not found! Select tinc installation directory.", "Error");
                fbd.Description = "Select tinc installation directory.";
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    var tincpath = fbd.SelectedPath;
                    //TincInstalledPath = tincpath;
                    Properties.Settings.Default.tincpath = fbd.SelectedPath;
                    Properties.Settings.Default.Save();
                    Process tinc = new Process();
                    tinc.StartInfo.Arguments = "-n contravpn";
                    tinc.StartInfo.FileName = "tinc.exe";
                    tinc.StartInfo.WorkingDirectory = Path.GetDirectoryName(Globals.tincpath + @"\tinc.exe");
                    if (File.Exists(Globals.tincpath + @"\tinc.exe"))
                    {
                        if (Directory.Exists(Globals.tincpath + @"\contravpn"))
                        {
                            tinc.Start();
                            Properties.Settings.Default.TincFound = true;
                            Properties.Settings.Default.Save();
                        }
                        else if (!Directory.Exists(Globals.tincpath + @"\contravpn"))
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
            else if ((Globals.TincFound == true))
            {
                Process tinc = new Process();
                tinc.StartInfo.Arguments = "-n contravpn";
                tinc.StartInfo.FileName = "tinc.exe";
                tinc.StartInfo.WorkingDirectory = Path.GetDirectoryName(Globals.tincpath + @"\tinc.exe");
                if (File.Exists(Globals.tincpath + @"\tinc.exe"))
                {
                    if (Directory.Exists(Globals.tincpath + @"\contravpn"))
                    {
                        tinc.Start();
                        Properties.Settings.Default.TincFound = true;
                        Properties.Settings.Default.Save();
                    }
                    else if (!Directory.Exists(Globals.tincpath + @"\contravpn"))
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
            Globals.TincFound = Properties.Settings.Default.TincFound;
            //var TincInstalledPath = string.Empty;
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (Globals.TincFound == false)
            {
                MessageBox.Show("\"tinc.exe\" not found! Select tinc installation directory.", "Error");
                fbd.Description = "Select tinc installation directory.";
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    var tincpath = fbd.SelectedPath;
                    //TincInstalledPath = tincpath;
                    Properties.Settings.Default.tincpath = fbd.SelectedPath;
                    Properties.Settings.Default.Save();
                    Process tinc = new Process();
                    tinc.StartInfo.Arguments = "-n contravpn log 3";
                    tinc.StartInfo.FileName = "tinc.exe";
                    tinc.StartInfo.WorkingDirectory = Path.GetDirectoryName(Globals.tincpath + @"\tinc.exe");
                    if (File.Exists(Globals.tincpath + @"\tinc.exe"))
                    {
                        if (Directory.Exists(Globals.tincpath + @"\contravpn"))
                        {
                            tinc.Start();
                            Properties.Settings.Default.TincFound = true;
                            Properties.Settings.Default.Save();
                        }
                        else if (!Directory.Exists(Globals.tincpath + @"\contravpn"))
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
            else if ((Globals.TincFound == true))
            {
                Process tinc = new Process();
                tinc.StartInfo.Arguments = "-n contravpn";
                tinc.StartInfo.FileName = "tinc.exe";
                tinc.StartInfo.WorkingDirectory = Path.GetDirectoryName(Globals.tincpath + @"\tinc.exe");
                if (File.Exists(Globals.tincpath + @"\tinc.exe"))
                {
                    if (Directory.Exists(Globals.tincpath + @"\contravpn"))
                    {
                        tinc.Start();
                        Properties.Settings.Default.TincFound = true;
                        Properties.Settings.Default.Save();
                    }
                    else if (!Directory.Exists(Globals.tincpath + @"\contravpn"))
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

        private void buttonVPNinvOK_Click(object sender, EventArgs e)
        {
            Process tinc = new Process();
            tinc.StartInfo.Arguments = "-n contravpn join " + invkeytextBox.Text;
            if (invkeytextBox.Text.StartsWith("contra.nsupdate.info"))
            {
                tinc.StartInfo.FileName = GetTincInstalledPath() + @"\" + "tinc.exe";
                tinc.StartInfo.UseShellExecute = false;
                tinc.StartInfo.RedirectStandardOutput = true;
                tinc.StartInfo.RedirectStandardError = true;
                tinc.StartInfo.CreateNoWindow = true;
                GetTincInstalledPath().Replace("\"", "");
                //tinc.StartInfo.WorkingDirectory = Path.GetDirectoryName(GetTincInstalledPath() + @"\");

                if (File.Exists(GetTincInstalledPath() + @"\tinc.exe"))
                {
                    tinc.Start();
                    string s = tinc.StandardError.ReadToEnd();
                    string s2 = tinc.StandardOutput.ReadToEnd();
                    if (s.Contains("accepted") || s2.Contains("accepted") == true)
                    {
                        if (getCurrentCulture() == "en-US")
                        {
                            MessageBox.Show("Invitation successfully accepted!");
                        }
                        else if (getCurrentCulture() == "ru-RU")
                        {
                            MessageBox.Show("Invitation successfully accepted!");
                        }
                        else if (getCurrentCulture() == "bg-BG")
                        {
                            MessageBox.Show("Поканата е приета успешно!");
                        }
                    }
                    else
                    {
                        if (getCurrentCulture() == "en-US")
                        {
                            MessageBox.Show("Invitation cancelled.\nMake sure this invite key is valid, not already used, or has not expired.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (getCurrentCulture() == "ru-RU")
                        {
                            MessageBox.Show("Invitation cancelled.\nMake sure this invite key is valid, not already used, or has not expired.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (getCurrentCulture() == "bg-BG")
                        {
                            MessageBox.Show("Поканата беше отказана.\nУбедете се, че вашият ключ е валиден, не е вече използван, или не е изтекъл.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        if (!File.Exists(GetTincInstalledPath() + @"\tinc.conf"))
                        {
                            try
                            {
                                Directory.Delete(GetTincInstalledPath() + @"\" + "contravpn");
                            }
                            catch
                            {

                            }
                        }
                    }
                    InvitePanel.Visible = false;
                }
                else
                {
                    if (getCurrentCulture() == "en-US")
                    {
                        MessageBox.Show("Tinc directory not found.", "Error");
                    }
                    if (getCurrentCulture() == "ru-RU")
                    {
                        MessageBox.Show("Tinc directory not found.", "Error");
                    }
                    if (getCurrentCulture() == "bg-BG")
                    {
                        MessageBox.Show("Tinc директорията не беше намерена.", "Грешка");
                    }
                }
            }
            else
            {
                if (Globals.GB_Checked == true) //(getCurrentCulture() == "en-US")
                {
                    MessageBox.Show("Invalid input.", "Error");
                }
                else if (Globals.RU_Checked == true) //(getCurrentCulture() == "ru-RU")
                {
                    MessageBox.Show("Invalid input.", "Error");
                }
                else if (Globals.BG_Checked == true) //(getCurrentCulture() == "bg-BG")
                {
                    MessageBox.Show("Невалиден вход.", "Грешка");
                }
            }
        }

        private void invkeytextBox_TextChanged(object sender, EventArgs e)
        {
            buttonVPNinvOK.Enabled = true;
        }
    }
}
