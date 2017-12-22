using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace Contra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.InitializeComponent();
            Application.ApplicationExit += new EventHandler(this.OnApplicationExit);
            button1.TabStop = false;
            button2.TabStop = false;
            button3.TabStop = false;
            button5.TabStop = false;
            button6.TabStop = false;
            button17.TabStop = false;
            button18.TabStop = false;
            buttonChat.TabStop = false;
            helpbutton.TabStop = false;
            websitebutton.TabStop = false;
            RadioLocQuotes.TabStop = false;
            RadioEN.TabStop = false;
            MNew.TabStop = false;
            DefaultPics.TabStop = false;
            QSCheckBox.TabStop = false;
            WinCheckBox.TabStop = false;
            FogCheckBox.TabStop = false;
            if (File.Exists(path + "_tmpChunk.dat"))
            {
                File.Delete(path + "_tmpChunk.dat");
            }
            if (File.Exists(xppath + "_tmpChunk.dat"))
            {
                File.Delete(xppath + "_tmpChunk.dat");
            }
        }

        public static string userProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        public static string subFolder = @"Documents\Command and Conquer Generals Zero Hour Data\";
        public static string xpsubFolder = @"My Documents\Command and Conquer Generals Zero Hour Data\";
        public static string path = Path.Combine(userProfile, subFolder);
        public static string xppath = Path.Combine(userProfile, xpsubFolder);

        private bool button1WasClicked = false;

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

        public static string StartGenerals;
        private void StartFile(string FileName)
        {
            try
            {
                Process generals = new Process();
                generals.StartInfo.FileName = "generals.exe";
                generals.StartInfo.Verb = "runas";
                generals.StartInfo.WorkingDirectory = Path.GetDirectoryName("generals.exe");
                generals.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void StartFileQS(string FileName)
        {
            try
            {
                Process generals = new Process();
                generals.StartInfo.FileName = "generals.exe";
                generals.StartInfo.Arguments = "-quickstart";
                generals.StartInfo.Verb = "runas";
                generals.StartInfo.WorkingDirectory = Path.GetDirectoryName("generals.exe");
                generals.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                return;
            }
        }

        private void StartFileWin(string FileName)
        {
            try
            {
                Process generals = new Process();
                generals.StartInfo.FileName = "generals.exe";
                generals.StartInfo.Arguments = "-win";
                generals.StartInfo.Verb = "runas";
                generals.StartInfo.WorkingDirectory = Path.GetDirectoryName("generals.exe");
                generals.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void StartFileWinQS(string FileName)
        {
            try
            {
                Process generals = new Process();
                generals.StartInfo.FileName = "generals.exe";
                generals.StartInfo.Arguments = "-win -quickstart";
                generals.StartInfo.Verb = "runas";
                generals.StartInfo.WorkingDirectory = Path.GetDirectoryName("generals.exe");
                generals.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackgroundImage = (System.Drawing.Image)(Properties.Resources._button_exit_text);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }
        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackgroundImage = (System.Drawing.Image)(Properties.Resources._button_exit);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }
        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            button2.BackgroundImage = (System.Drawing.Image)(Properties.Resources._button_highlight);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }

        private void button2_Click(object sender, EventArgs e) //ExitButton
        {
            OnApplicationExit(sender, e);
        }

        public static string BigToCtr;
        public void Rename(string BigToCtr)
        {
            try
            {
                if (File.Exists("!Contra009Beta2.big"))
                {
                    File.Move("!Contra009Beta2.big", "!Contra009Beta2.ctr");
                }
                if (File.Exists("!Contra009Beta2EN.big"))
                {
                    File.Move("!Contra009Beta2EN.big", "!Contra009Beta2EN.ctr");
                }
                if (File.Exists("!Contra009Beta2RU.big"))
                {
                    File.Move("!Contra009Beta2RU.big", "!Contra009Beta2RU.ctr");
                }
                if (File.Exists("!Contra009Beta2VOrig.big"))
                {
                    File.Move("!Contra009Beta2VOrig.big", "!Contra009Beta2VOrig.ctr");
                }
                if (File.Exists("!Contra009Beta2VLoc.big"))
                {
                    File.Move("!Contra009Beta2VLoc.big", "!Contra009Beta2VLoc.ctr");
                }
                if (File.Exists("!Contra009Beta2MNew.big"))
                {
                    File.Move("!Contra009Beta2MNew.big", "!Contra009Beta2MNew.ctr");
                }
//                if (File.Exists("!Contra009Beta2MStandard.big"))
//                {
//                    File.Move("!Contra009Beta2MStandard.big", "!Contra009Beta2MStandard.ctr");
//                }
                if (File.Exists("!!Contra009FinalFogOFF.big"))
                {
                    File.Move("!!Contra009FinalFogOFF.big", "!!Contra009FinalFogOFF.ctr");
                }
                if (File.Exists("!!Contra009FinalOldGenPics.big"))
                {
                    File.Move("!!Contra009FinalOldGenPics.big", "!!Contra009FinalOldGenPics.ctr");
                }
                if (Directory.Exists(@"Data\Scripts1"))
                {
                    Directory.Move(@"Data\Scripts1", @"Data\Scripts");
                }
            }
            catch (Exception ex)
            {
                if (button1WasClicked == true)
                {
                    MessageBox.Show(ex.Message, "Error");
                    //return;
                    //MessageBox.Show("If you have one or more .big files opened, close them and try again. You also can't launch Contra if generals.exe is already running.", "Error");
                }
            }
            try
            {
                if (File.Exists("Install_Final.bmp") && File.Exists("Install_Final_ZHC.bmp"))
                {
                    File.Move("Install_Final.bmp", "Install_Final_Contra.bmp");
                    File.Move("Install_Final_ZHC.bmp", "Install_Final.bmp");
                }
                if (File.Exists("Install_Final_Contra.bmp") && File.Exists("Install_Final_ZHC.bmp"))
                {
                    File.Move("Install_Final_ZHC.bmp", "Install_Final.bmp");
                }
            }
            catch (Exception ex)
            {
                if (button1WasClicked == true)
                {
                    MessageBox.Show(ex.Message, "Error");
                    //return;
                }
            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackgroundImage = (System.Drawing.Image)(Properties.Resources._button_launch_text);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackgroundImage = (System.Drawing.Image)(Properties.Resources._button_launch);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }
        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            button1.BackgroundImage = (System.Drawing.Image)(Properties.Resources._button_highlight);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }

        private void button1_Click(object sender, EventArgs e) //LaunchButton
        {
            button1WasClicked = true;
            this.Rename(BigToCtr);
            try
            {
                if (File.Exists("!Contra009Beta2.ctr"))
                {
                    File.Move("!Contra009Beta2.ctr", "!Contra009Beta2.big");
                }
                if (RadioOrigQuotes.Checked)
                {
                    File.Move("!Contra009Beta2VOrig.ctr", "!Contra009Beta2VOrig.big");
                }
                if (RadioLocQuotes.Checked)
                {
                    File.Move("!Contra009Beta2VLoc.ctr", "!Contra009Beta2VLoc.big");
                }
                if (RadioEN.Checked)
                {
                    File.Move("!Contra009Beta2EN.ctr", "!Contra009Beta2EN.big");
                }
                if (RadioRU.Checked)
                {
                    File.Move("!Contra009Beta2RU.ctr", "!Contra009Beta2RU.big");
                }
//                if (MStandard.Checked)
//                {
//                    File.Move("!Contra009Beta2MStandard.ctr", "!Contra009Beta2MStandard.big");
//                }
                if (MNew.Checked)
                {
                    File.Move("!Contra009Beta2MNew.ctr", "!Contra009Beta2MNew.big");
                }
                if (!FogCheckBox.Checked)
                {
                    File.Move("!!Contra009FinalFogOff.ctr", "!!Contra009FinalFogOff.big");
                }
                if (GoofyPics.Checked)
                {
                    File.Move("!!Contra009FinalOldGenPics.ctr", "!!Contra009FinalOldGenPics.big");
                }
                if (Directory.Exists(@"Data\Scripts"))
                {
                    Directory.Move(@"Data\Scripts", @"Data\Scripts1");
                }
                if (WinCheckBox.Checked && QSCheckBox.Checked)
                {
                    this.StartFileWinQS(StartGenerals);
                }
                if (QSCheckBox.Checked && WinCheckBox.Checked == false)
                {
                    this.StartFileQS(StartGenerals);
                }
                if (WinCheckBox.Checked && QSCheckBox.Checked == false)
                {
                    this.StartFileWin(StartGenerals);
                }
                if (WinCheckBox.Checked == false && QSCheckBox.Checked == false)
                {
                    this.StartFile(StartGenerals);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                return;
            }
            try
            {
                if (File.Exists("Install_Final_Contra.bmp") && File.Exists("Install_Final_ZHC.bmp"))
                {
                    File.Move("Install_Final.bmp", "Install_Final_ZHC.bmp");
                    File.Move("Install_Final_Contra.bmp", "Install_Final.bmp");
                }
                if (File.Exists("Install_Final_Contra.bmp"))
                {
                    File.Move("Install_Final.bmp", "Install_Final_ZHC.bmp");
                    File.Move("Install_Final_Contra.bmp", "Install_Final.bmp");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                return;
            }
            return;
        }

        private void websitebutton_MouseEnter(object sender, EventArgs e)
        {
            websitebutton.BackgroundImage = (System.Drawing.Image)(Properties.Resources._button_website_text);
            websitebutton.ForeColor = SystemColors.ButtonHighlight;
            websitebutton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }
        private void websitebutton_MouseLeave(object sender, EventArgs e)
        {
            websitebutton.BackgroundImage = (System.Drawing.Image)(Properties.Resources._button_website);
            websitebutton.ForeColor = SystemColors.ButtonHighlight;
            websitebutton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }
        private void websitebutton_MouseDown(object sender, MouseEventArgs e)
        {
            websitebutton.BackgroundImage = (System.Drawing.Image)(Properties.Resources._button_highlight);
            websitebutton.ForeColor = SystemColors.ButtonHighlight;
            websitebutton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }
        private void websitebutton_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("http://contra.cncguild.net/oldsite/Eng/index.php");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.BackgroundImage = (System.Drawing.Image)(Properties.Resources._button_moddb_text);
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }
        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackgroundImage = (System.Drawing.Image)(Properties.Resources._button_moddb);
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }
        private void button5_MouseDown(object sender, MouseEventArgs e)
        {
            button5.BackgroundImage = (System.Drawing.Image)(Properties.Resources._button_highlight);
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }

        private void button5_Click(object sender, EventArgs e) //ModDBButton
        {
            try
            {
                Process.Start("http://www.moddb.com/mods/contra");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackgroundImage = (System.Drawing.Image)(Properties.Resources._button_readme_text);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }
        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackgroundImage = (System.Drawing.Image)(Properties.Resources._button_readme);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }
        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            button3.BackgroundImage = (System.Drawing.Image)(Properties.Resources._button_highlight);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }

        private void button3_Click(object sender, EventArgs e) //ReadMeButton
        {
            try
            {
                Process.Start("Readme_Contra.txt");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            button6.BackgroundImage = (System.Drawing.Image)(Properties.Resources._button_wb_text);
            button6.ForeColor = SystemColors.ButtonHighlight;
            button6.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }
        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.BackgroundImage = (System.Drawing.Image)(Properties.Resources._button_wb);
            button6.ForeColor = SystemColors.ButtonHighlight;
            button6.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }
        private void button6_MouseDown(object sender, MouseEventArgs e)
        {
            button6.BackgroundImage = (System.Drawing.Image)(Properties.Resources._button_highlight);
            button6.ForeColor = SystemColors.ButtonHighlight;
            button6.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }
        private void button6_Click(object sender, EventArgs e) //WorldBuilder
        {
            //this.Rename(BigToCtr);
            if (File.Exists("!Contra009Beta2.ctr"))
            {
                File.Move("!Contra009Beta2.ctr", "!Contra009Beta2.big");
            }
            if (File.Exists("!Contra009Beta2EN.ctr"))
            {
                File.Move("!Contra009Beta2EN.ctr", "!Contra009Beta2EN.big");
            }
            if (File.Exists("!Contra009Beta2VOrig.ctr"))
            {
                File.Move("!Contra009Beta2VOrig.ctr", "!Contra009Beta2VOrig.big");
            }
            Process wb = new Process();
            wb.StartInfo.Verb = "runas";
            try
            {
                if (File.Exists("WorldBuilder_Ctr.exe"))
                {
                  wb.StartInfo.FileName = "WorldBuilder_Ctr.exe";
                  wb.StartInfo.WorkingDirectory = Path.GetDirectoryName("WorldBuilder_Ctr.exe");
                  wb.Start();
                }
                else
                {
                  wb.StartInfo.FileName = "WorldBuilder.exe";
                  wb.StartInfo.WorkingDirectory = Path.GetDirectoryName("WorldBuilder.exe");
                  wb.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            return;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RadioEN.Checked = Properties.Settings.Default.LangEN;
            RadioRU.Checked = Properties.Settings.Default.LangRU;
            MNew.Checked = Properties.Settings.Default.MusicNew;
            MStandard.Checked = Properties.Settings.Default.MusicStandard;
            RadioOrigQuotes.Checked = Properties.Settings.Default.VoNew;
            RadioLocQuotes.Checked = Properties.Settings.Default.VoStandard;
            QSCheckBox.Checked = Properties.Settings.Default.Quickstart;
            WinCheckBox.Checked = Properties.Settings.Default.Windowed;
            DefaultPics.Checked = Properties.Settings.Default.GenPicDef;
            GoofyPics.Checked = Properties.Settings.Default.GenPicGoo;
            FogCheckBox.Checked = Properties.Settings.Default.Fog;
            AutoScaleMode = AutoScaleMode.Dpi;
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e) //MinimizeIcon
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void OnApplicationExit(object sender, EventArgs e) //AppExit
        {
            this.Rename(BigToCtr);
            Properties.Settings.Default.LangEN = RadioEN.Checked;
            Properties.Settings.Default.LangRU = RadioRU.Checked;
            Properties.Settings.Default.MusicNew = MNew.Checked;
            Properties.Settings.Default.MusicStandard = MStandard.Checked;
            Properties.Settings.Default.VoNew = RadioOrigQuotes.Checked;
            Properties.Settings.Default.VoStandard = RadioLocQuotes.Checked;
            Properties.Settings.Default.Quickstart = QSCheckBox.Checked;
            Properties.Settings.Default.Windowed = WinCheckBox.Checked;
            Properties.Settings.Default.GenPicDef = DefaultPics.Checked;
            Properties.Settings.Default.GenPicGoo = GoofyPics.Checked;
            Properties.Settings.Default.Fog = FogCheckBox.Checked;
            Properties.Settings.Default.Save();
            if (File.Exists(path + "_tmpChunk.dat"))
            {
                File.Delete(path + "_tmpChunk.dat");
            }
            if (File.Exists(xppath + "_tmpChunk.dat"))
            {
                File.Delete(xppath + "_tmpChunk.dat");
            }
            this.Close();
        }

        private void button18_Click(object sender, EventArgs e) //ExitIcon
        {
            OnApplicationExit(sender, e);
        }

        private void buttonChat_MouseEnter(object sender, EventArgs e)
        {
            buttonChat.BackgroundImage = (System.Drawing.Image)(Properties.Resources._button_discord_text);
            buttonChat.ForeColor = SystemColors.ButtonHighlight;
            buttonChat.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }
        private void buttonChat_MouseLeave(object sender, EventArgs e)
        {
            buttonChat.BackgroundImage = (System.Drawing.Image)(Properties.Resources._button_discord);
            buttonChat.ForeColor = SystemColors.ButtonHighlight;
            buttonChat.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }
        private void buttonChat_MouseDown(object sender, MouseEventArgs e)
        {
            buttonChat.BackgroundImage = (System.Drawing.Image)(Properties.Resources._button_highlight);
            buttonChat.ForeColor = SystemColors.ButtonHighlight;
            buttonChat.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }

        private void buttonChat_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("https://discordapp.com/invite/015E6KXXHmdWFXCtt");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void helpbutton_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("http://contra.cncguild.net/oldsite/Eng/trouble.php");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void helpbutton_MouseDown_1(object sender, MouseEventArgs e)
        {
            helpbutton.BackgroundImage = (System.Drawing.Image)(Properties.Resources._button_highlight);
            helpbutton.ForeColor = SystemColors.ButtonHighlight;
            helpbutton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }
        private void helpbutton_MouseEnter_1(object sender, EventArgs e)
        {
            helpbutton.BackgroundImage = (System.Drawing.Image)(Properties.Resources._button_help_text);
            helpbutton.ForeColor = SystemColors.ButtonHighlight;
            helpbutton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }
        private void helpbutton_MouseLeave_1(object sender, EventArgs e)
        {
            helpbutton.BackgroundImage = (System.Drawing.Image)(Properties.Resources._button_help);
            helpbutton.ForeColor = SystemColors.ButtonHighlight;
            helpbutton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }

        private void button6_Enter(object sender, EventArgs e)
        {
            button6.BackColor = System.Drawing.Color.Transparent;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void WinCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void voicespanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void languagepanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GoofyPics_CheckedChanged(object sender, EventArgs e)
        {

        }

        private string FindByDisplayName(RegistryKey parentKey, string name)
        {
            string[] nameList = parentKey.GetSubKeyNames();
            for (int i = 0; i < nameList.Length; i++)
            {
                RegistryKey regKey =  parentKey.OpenSubKey(nameList[i]);
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

        public static string GetTincInstalledPathConnect()//internal static string GetTincInstalledPath()
        {
            var TincInstalledPath = string.Empty;
            var TincRegistryPath = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall\tinc");
            if (TincRegistryPath != null)
            {
                TincInstalledPath = TincRegistryPath.GetValue("UninstallString", string.Empty) as string;
            }
            Process tinc = new Process();
            tinc.StartInfo.Arguments = "-n contravpn -D"; //tinc.StartInfo.Arguments = "-n contravpn start -d1 -D";
            tinc.StartInfo.FileName = "tincd.exe";
            TincInstalledPath = TincInstalledPath.Replace("\"", "");
            tinc.StartInfo.WorkingDirectory = Path.GetDirectoryName(TincInstalledPath);
        //    TincInstalledPath = TincInstalledPath.Remove(TincInstalledPath.Length - 15);
        //    TincInstalledPath = (TincInstalledPath + "\"");
       //     MessageBox.Show(TincInstalledPath);
            tinc.Start();

            if (string.IsNullOrEmpty(TincInstalledPath) || !Directory.Exists(TincInstalledPath))
            {
                TincRegistryPath = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\tinc");
                if (TincRegistryPath != null)
                {
                    TincInstalledPath = TincRegistryPath.GetValue("(Default)", string.Empty) as string;
                }
            }

            if (string.IsNullOrEmpty(TincInstalledPath) || !Directory.Exists(TincInstalledPath))
            {
                TincRegistryPath = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\WOW6432Node\tinc");
                if (TincRegistryPath != null)
                {
                    TincInstalledPath = TincRegistryPath.GetValue("(Default)", string.Empty) as string;
                }
            }

            //if (string.IsNullOrEmpty(TincInstalledPath) || !Directory.Exists(TincInstalledPath))
            //{
            //    TincRegistryPath = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\VisualStudio\11.0");
            //    if (TincRegistryPath != null)
            //    {
            //        TincInstalledPath = TincRegistryPath.GetValue("InstallDir", string.Empty) as string;
//                }
//            }
            return TincInstalledPath;
        }

        public static string GetTincInstalledPathEnterInvKey()//internal static string GetTincInstalledPath()
        {
            var TincInstalledPath = string.Empty;
            string asd = "contravpn";
            var TincRegistryPath = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall\tinc");
            if (TincRegistryPath != null)
            {
                TincInstalledPath = TincRegistryPath.GetValue("UninstallString", string.Empty) as string;
            }
            if (Directory.Exists(TincInstalledPath + asd))
            {
                Process tinc = new Process();
                tinc.StartInfo.Arguments = "join";   // tinc.StartInfo.Arguments = "-n contravpn start -d1 -D";
                tinc.StartInfo.FileName = "tinc.exe";
                TincInstalledPath = TincInstalledPath.Replace("\"", "");
                tinc.StartInfo.WorkingDirectory = Path.GetDirectoryName(TincInstalledPath);
                //    TincInstalledPath = TincInstalledPath.Remove(TincInstalledPath.Length - 15);
                //    TincInstalledPath = (TincInstalledPath + "\"");
                //     MessageBox.Show(TincInstalledPath);
                tinc.Start();
            }
            else MessageBox.Show("You already have an invite key.");

            if (string.IsNullOrEmpty(TincInstalledPath) || !Directory.Exists(TincInstalledPath))
            {
                TincRegistryPath = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\tinc");
                if (TincRegistryPath != null)
                {
                    TincInstalledPath = TincRegistryPath.GetValue("(Default)", string.Empty) as string;
                }
            }

            if (string.IsNullOrEmpty(TincInstalledPath) || !Directory.Exists(TincInstalledPath))
            {
                TincRegistryPath = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\WOW6432Node\tinc");
                if (TincRegistryPath != null)
                {
                    TincInstalledPath = TincRegistryPath.GetValue("(Default)", string.Empty) as string;
                }
            }

            //if (string.IsNullOrEmpty(TincInstalledPath) || !Directory.Exists(TincInstalledPath))
            //{
            //    TincRegistryPath = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\VisualStudio\11.0");
            //    if (TincRegistryPath != null)
            //    {
            //        TincInstalledPath = TincRegistryPath.GetValue("InstallDir", string.Empty) as string;
            //                }
            //            }
            return TincInstalledPath;
        }

        public static string GetTincInstalledPathOpenConsole()//internal static string GetTincInstalledPath()
        {
            var TincInstalledPath = string.Empty;
            var TincRegistryPath = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall\tinc");
            if (TincRegistryPath != null)
            {
                TincInstalledPath = TincRegistryPath.GetValue("UninstallString", string.Empty) as string;
            }
            Process tinc = new Process();
            tinc.StartInfo.Arguments = "-n contravpn";
            tinc.StartInfo.FileName = "tinc.exe";
            TincInstalledPath = TincInstalledPath.Replace("\"", "");
            tinc.StartInfo.WorkingDirectory = Path.GetDirectoryName(TincInstalledPath);
            //    TincInstalledPath = TincInstalledPath.Remove(TincInstalledPath.Length - 15);
            //    TincInstalledPath = (TincInstalledPath + "\"");
            //     MessageBox.Show(TincInstalledPath);
            tinc.Start();

            if (string.IsNullOrEmpty(TincInstalledPath) || !Directory.Exists(TincInstalledPath))
            {
                TincRegistryPath = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\tinc");
                if (TincRegistryPath != null)
                {
                    TincInstalledPath = TincRegistryPath.GetValue("(Default)", string.Empty) as string;
                }
            }

            if (string.IsNullOrEmpty(TincInstalledPath) || !Directory.Exists(TincInstalledPath))
            {
                TincRegistryPath = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\WOW6432Node\tinc");
                if (TincRegistryPath != null)
                {
                    TincInstalledPath = TincRegistryPath.GetValue("(Default)", string.Empty) as string;
                }
            }

            //if (string.IsNullOrEmpty(TincInstalledPath) || !Directory.Exists(TincInstalledPath))
            //{
            //    TincRegistryPath = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\VisualStudio\11.0");
            //    if (TincRegistryPath != null)
            //    {
            //        TincInstalledPath = TincRegistryPath.GetValue("InstallDir", string.Empty) as string;
            //                }
            //            }
            return TincInstalledPath;
        }

        public static string GetTincInstalledPathInvKey()//internal static string GetTincInstalledPath()
        {
            var TincInstalledPath = string.Empty;
            var TincRegistryPath = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall\tinc");
            if (TincRegistryPath != null)
            {
                TincInstalledPath = TincRegistryPath.GetValue("UninstallString", string.Empty) as string;
            }
            Process tinc = new Process();
            string InvKey = "+uZIDXy3mIXdBqCqWmBmAC3lXdz5+N5va/M7XEKc3II";
         //   tinc.StartInfo.Arguments = "join contra.nsupdate.info/" + (InvKey);
         //   tinc.StartInfo.FileName = "tinc.exe";
            TincInstalledPath = TincInstalledPath.Replace("\"", "");
            tinc.StartInfo.WorkingDirectory = Path.GetDirectoryName(TincInstalledPath);
            //    TincInstalledPath = TincInstalledPath.Remove(TincInstalledPath.Length - 15);
            //    TincInstalledPath = (TincInstalledPath + "\"");
            MessageBox.Show(TincInstalledPath);
            tinc.Start();

            if (string.IsNullOrEmpty(TincInstalledPath) || !Directory.Exists(TincInstalledPath))
            {
                TincRegistryPath = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\VisualStudio\14.0");
                if (TincRegistryPath != null)
                {
                    TincInstalledPath = TincRegistryPath.GetValue("InstallDir", string.Empty) as string;
                }
                //       MessageBox.Show(TincInstalledPath);
            }

            if (string.IsNullOrEmpty(TincInstalledPath) || !Directory.Exists(TincInstalledPath))
            {
                TincRegistryPath = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\WOW6432Node\Microsoft\VisualStudio\11.0\Debugger");
                if (TincRegistryPath != null)
                {
                    TincInstalledPath = TincRegistryPath.GetValue("FEQARuntimeImplDll", string.Empty) as string;
                }
                //       MessageBox.Show(TincInstalledPath);
            }

            if (string.IsNullOrEmpty(TincInstalledPath) || !Directory.Exists(TincInstalledPath))
            {
                TincRegistryPath = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\VisualStudio\11.0");
                if (TincRegistryPath != null)
                {
                    TincInstalledPath = TincRegistryPath.GetValue("InstallDir", string.Empty) as string;
                }
                //     MessageBox.Show(TincInstalledPath);
            }
            return TincInstalledPath;
        }

        private void DisplayMessageBoxText()
        {
            MessageBox.Show("Hello, world.");
        }

        private void buttonVPNstart_Click(object sender, EventArgs e)
        {
            try
            {
                GetTincInstalledPathConnect();
             //   tinc.StartInfo.WorkingDirectory = Path.GetDirectoryName(@"D:\Software\tinc\tinc.exe");
        //        RegistryKey key = Registry.LocalMachine.OpenSubKey(@"HKEY_USERS\S-1-5-21-3607405612-1459809242-4212064258-1000_Classes\Local Settings\Software\Microsoft\Windows\Shell\MuiCache").GetValue(@"D:\Software\tinc\tinc.exe");
    //            RegistryKey regKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall");
    //            string location = FindByDisplayName(regKey, "tinc");
                //DisplayMessageBoxText();

               // MessageBox.Show(TincInstalledPath);

                //System.Diagnostics.Process.Start(@"D:\Software\tinc\tinc.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void buttonVPNinvkey_Click(object sender, EventArgs e)
        {
            GetTincInstalledPathEnterInvKey();
        }

        private void buttonVPNconsole_Click(object sender, EventArgs e)
        {
            GetTincInstalledPathOpenConsole();
        }

        private void buttonVPNinvOK_Click(object sender, EventArgs e)
        {
            GetTincInstalledPathInvKey();

      //       TextBox invkeytextBox = (TextBox)sender;
  //          string invkey = invkeytextBox.Text;
            //invkey = Console.ReadLine();
            //getting notepad's process | at least one instance of notepad must be running
//            Process notepadProccess = Process.GetProcessesByName("tinc")[0];

            //getting notepad's textbox handle from the main window's handle
            //the textbox is called 'Edit'
//            IntPtr notepadTextbox = FindWindowEx(notepadProccess.MainWindowHandle, IntPtr.Zero, "Edit", null);
            //sending the message to the textbox
//            SendMessage(notepadTextbox, WM_SETTEXT, 0, invkeytextBox.Text);

         //   int invkey;
       //     invkey = Console.Read();
           // SendKeys.Send(invkey)
        }


        [DllImport("user32.dll")]
        public static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);

        //include SendMessage
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int uMsg, int wParam, string lParam);

        //this is a constant indicating the window that we want to send a text message
        const int WM_SETTEXT = 0X000C;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
