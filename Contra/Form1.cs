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
using System.Text.RegularExpressions;
using System.Timers;
using System.Net;
using System.Net.NetworkInformation;

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
            buttonVPNstart.TabStop = false;
            VPNMoreButton.TabStop = false;
            radioFlag_GB.TabStop = false;
            radioFlag_RU.TabStop = false;
            radioFlag_UA.TabStop = false;
            radioFlag_BG.TabStop = false;
            onlinePlayersBtn.TabStop = false;
            vpn_start.FlatAppearance.MouseOverBackColor = Color.Transparent;
            vpn_start.FlatAppearance.MouseDownBackColor = Color.Transparent;
            vpn_start.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            onlinePlayersBtn.Hide();
            whoIsOnline.Hide();

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
                if (File.Exists("generals.exe"))
                {
                    generals.StartInfo.WorkingDirectory = Path.GetDirectoryName("generals.exe");
                }
                else if (File.Exists(@"..\generals.exe"))
                {
                    generals.StartInfo.WorkingDirectory = Path.GetDirectoryName(@"..\generals.exe");
                }
                generals.Start();
            }
            catch (Exception ex)
            {
                string currentDir = Environment.CurrentDirectory;
                if (currentDir.Contains("Zero Hour Data") == true)
                {
                    if (Globals.GB_Checked == true)
                    {
                        MessageBox.Show("You have installed Contra in the wrong folder. Install it in the ZH folder which contains the \"generals.exe\"", "Error");
                    }
                    else if (Globals.RU_Checked == true)
                    {
                        MessageBox.Show("You have installed Contra in the wrong folder. Install it in the ZH folder which contains the \"generals.exe\"", "Error");
                    }
                    else if (Globals.UA_Checked == true)
                    {
                        MessageBox.Show("You have installed Contra in the wrong folder. Install it in the ZH folder which contains the \"generals.exe\"", "Error");
                    }
                    else if (Globals.BG_Checked == true)
                    {
                        MessageBox.Show("Инсталирали сте Contra в грешната папка. Инсталирайте в ZH папката, която съдържа \"generals.exe\"", "Грешка");
                    }
                }
                else
                {
                    MessageBox.Show(ex.Message, "Error");
                }
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
                if (File.Exists("generals.exe"))
                {
                    generals.StartInfo.WorkingDirectory = Path.GetDirectoryName("generals.exe");
                }
                else if (File.Exists(@"..\generals.exe"))
                {
                    generals.StartInfo.WorkingDirectory = Path.GetDirectoryName(@"..\generals.exe");
                }
                generals.Start();
            }
            catch (Exception ex)
            {
                string currentDir = Environment.CurrentDirectory;
                if (currentDir.Contains("Zero Hour Data") == true)
                {
                    if (Globals.GB_Checked == true)
                    {
                        MessageBox.Show("You have installed Contra in the wrong folder. Install it in the ZH folder which contains the \"generals.exe\"", "Error");
                    }
                    else if (Globals.RU_Checked == true)
                    {
                        MessageBox.Show("You have installed Contra in the wrong folder. Install it in the ZH folder which contains the \"generals.exe\"", "Error");
                    }
                    else if (Globals.UA_Checked == true)
                    {
                        MessageBox.Show("You have installed Contra in the wrong folder. Install it in the ZH folder which contains the \"generals.exe\"", "Error");
                    }
                    else if (Globals.BG_Checked == true)
                    {
                        MessageBox.Show("Инсталирали сте Contra в грешната папка. Инсталирайте в ZH папката, която съдържа \"generals.exe\"", "Грешка");
                    }
                }
                else
                {
                    MessageBox.Show(ex.Message, "Error");
                }
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
                if (File.Exists("generals.exe"))
                {
                    generals.StartInfo.WorkingDirectory = Path.GetDirectoryName("generals.exe");
                }
                else if (File.Exists(@"..\generals.exe"))
                {
                    generals.StartInfo.WorkingDirectory = Path.GetDirectoryName(@"..\generals.exe");
                }
                generals.Start();
            }
            catch (Exception ex)
            {
                string currentDir = Environment.CurrentDirectory;
                if (currentDir.Contains("Zero Hour Data") == true)
                {
                    if (Globals.GB_Checked == true)
                    {
                        MessageBox.Show("You have installed Contra in the wrong folder. Install it in the ZH folder which contains the \"generals.exe\"", "Error");
                    }
                    else if (Globals.RU_Checked == true)
                    {
                        MessageBox.Show("You have installed Contra in the wrong folder. Install it in the ZH folder which contains the \"generals.exe\"", "Error");
                    }
                    else if (Globals.UA_Checked == true)
                    {
                        MessageBox.Show("You have installed Contra in the wrong folder. Install it in the ZH folder which contains the \"generals.exe\"", "Error");
                    }
                    else if (Globals.BG_Checked == true)
                    {
                        MessageBox.Show("Инсталирали сте Contra в грешната папка. Инсталирайте в ZH папката, която съдържа \"generals.exe\"", "Грешка");
                    }
                }
                else
                {
                    MessageBox.Show(ex.Message, "Error");
                }
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
                if (File.Exists("generals.exe"))
                {
                    generals.StartInfo.WorkingDirectory = Path.GetDirectoryName("generals.exe");
                }
                else if (File.Exists(@"..\generals.exe"))
                {
                    generals.StartInfo.WorkingDirectory = Path.GetDirectoryName(@"..\generals.exe");
                }
                generals.Start();
            }
            catch (Exception ex)
            {
                string currentDir = Environment.CurrentDirectory;
                if (currentDir.Contains("Zero Hour Data") == true)
                {
                    if (Globals.GB_Checked == true)
                    {
                        MessageBox.Show("You have installed Contra in the wrong folder. Install it in the ZH folder which contains the \"generals.exe\"", "Error");
                    }
                    else if (Globals.RU_Checked == true)
                    {
                        MessageBox.Show("You have installed Contra in the wrong folder. Install it in the ZH folder which contains the \"generals.exe\"", "Error");
                    }
                    else if (Globals.UA_Checked == true)
                    {
                        MessageBox.Show("You have installed Contra in the wrong folder. Install it in the ZH folder which contains the \"generals.exe\"", "Error");
                    }
                    else if (Globals.BG_Checked == true)
                    {
                        MessageBox.Show("Инсталирали сте Contra в грешната папка. Инсталирайте в ZH папката, която съдържа \"generals.exe\"", "Грешка");
                    }
                }
                else
                {
                    MessageBox.Show(ex.Message, "Error");
                }
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
            string wb = "worldbuilder_ctr.exe";
            Process[] wbByName = Process.GetProcessesByName(wb.Substring(0, wb.LastIndexOf('.')));
            if (wbByName.Length > 0) //if wb is already running
            {
                MessageBox.Show("Mod files could not be unloaded since they are currently in use by World Builder. If you want to unload mod files, close World Builder and run the launcher again. Closing the launcher anyway.", "Error");
            }
            else
            {
                //nothing
            }
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
                else if (File.Exists(@"..\!Contra009Beta2.big"))
                {
                    File.Move(@"..\!Contra009Beta2.big", @"..\!Contra009Beta2.ctr");
                }
                if (File.Exists("!Contra009Beta2VOrig.big"))
                {
                    File.Move("!Contra009Beta2VOrig.big", "!Contra009Beta2VOrig.ctr");
                }
                else if (File.Exists(@"..\!Contra009Beta2VOrig.big"))
                {
                    File.Move(@"..\!Contra009Beta2VOrig.big", @"..\!Contra009Beta2VOrig.ctr");
                }
                if (File.Exists("!Contra009Beta2VLoc.big"))
                {
                    File.Move("!Contra009Beta2VLoc.big", "!Contra009Beta2VLoc.ctr");
                }
                else if (File.Exists(@"..\!Contra009Beta2VLoc.big"))
                {
                    File.Move(@"..\!Contra009Beta2VLoc.big", @"..\!Contra009Beta2VLoc.ctr");
                }
                if (File.Exists("!Contra009Beta2EN.big"))
                {
                    File.Move("!Contra009Beta2EN.big", "!Contra009Beta2EN.ctr");
                }
                else if (File.Exists(@"..\!Contra009Beta2EN.big"))
                {
                    File.Move(@"..\!Contra009Beta2EN.big", @"..\!Contra009Beta2EN.ctr");
                }
                if (File.Exists("!Contra009Beta2RU.big"))
                {
                    File.Move("!Contra009Beta2RU.big", "!Contra009Beta2RU.ctr");
                }
                else if (File.Exists(@"..\!Contra009Beta2RU.big"))
                {
                    File.Move(@"..\!Contra009Beta2RU.big", @"..\!Contra009Beta2RU.ctr");
                }
                if (File.Exists("!Contra009Beta2MNew.big"))
                {
                    File.Move("!Contra009Beta2MNew.big", "!Contra009Beta2MNew.ctr");
                }
                else if (File.Exists(@"..\!Contra009Beta2MNew.big"))
                {
                    File.Move(@"..\!Contra009Beta2MNew.big", @"..\!Contra009Beta2MNew.ctr");
                }
                if (File.Exists("!!Contra009FinalFogOff.big"))
                {
                    File.Move("!!Contra009FinalFogOff.big", "!!Contra009FinalFogOff.ctr");
                }
                else if (File.Exists(@"..\!!Contra009FinalFogOff.big"))
                {
                    File.Move(@"..\!!Contra009FinalFogOff.big", @"..\!!Contra009FinalFogOff.ctr");
                }
                if ((File.Exists("langdata1.dat")))
                {
                    File.Move("langdata1.dat", "langdata.dat");
                }
                else if ((File.Exists(@"..\langdata1.dat")))
                {
                    File.Move(@"..\langdata1.dat", @"..\langdata.dat");
                }
                if (File.Exists("!!Contra009FinalOldGenPics.big"))
                {
                    File.Move("!!Contra009FinalOldGenPics.big", "!!Contra009FinalOldGenPics.ctr");
                }
                else if (File.Exists(@"..\!!Contra009FinalOldGenPics.big"))
                {
                    File.Move(@"..\!!Contra009FinalOldGenPics.big", @"..\!!Contra009FinalOldGenPics.ctr");
                }
                if (Directory.Exists(@"Data\Scripts1"))
                {
                    Directory.Move(@"Data\Scripts1", @"Data\Scripts");
                }
                else if (Directory.Exists(@"..\Data\Scripts1"))
                {
                    Directory.Move(@"..\Data\Scripts1", @"..\Data\Scripts");
                }
                if (File.Exists("Install_Final.bmp") && File.Exists("Install_Final_ZHC.bmp"))
                {
                    File.Move("Install_Final.bmp", "Install_Final_Contra.bmp");
                    File.Move("Install_Final_ZHC.bmp", "Install_Final.bmp");
                }
                else if (File.Exists(@"..\Install_Final.bmp") && File.Exists(@"..\Install_Final_ZHC.bmp"))
                {
                    File.Move(@"..\Install_Final.bmp", @"..\Install_Final_Contra.bmp");
                    File.Move(@"..\Install_Final_ZHC.bmp", @"..\Install_Final.bmp");
                }
                if (File.Exists("Install_Final_Contra.bmp") && File.Exists("Install_Final_ZHC.bmp"))
                {
                    File.Move("Install_Final_ZHC.bmp", "Install_Final.bmp");
                }
                else if (File.Exists(@"..\Install_Final_Contra.bmp") && File.Exists("Install_Final_ZHC.bmp"))
                {
                    File.Move(@"..\Install_Final_ZHC.bmp", @"..\Install_Final.bmp");
                }
            }
            catch (Exception ex)
            {

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

        public void isWbRunning()
        {
            string wb = "worldbuilder_ctr.exe";
            Process[] wbByName = Process.GetProcessesByName(wb.Substring(0, wb.LastIndexOf('.')));
            if (wbByName.Length > 0) //if wb is already running
            {
                MessageBox.Show("Unit voices may not load correctly since World Builder is already running. Starting Contra anyway.", "Error");
            }
        }

        private void button1_Click(object sender, EventArgs e) //LaunchButton
        {
            this.Rename(BigToCtr);
            try
            {
                if (File.Exists("!Contra009Beta2.ctr"))
                {
                    File.Move("!Contra009Beta2.ctr", "!Contra009Beta2.big");
                }
                else if (File.Exists(@"..\!Contra009Beta2.ctr"))
                {
                    File.Move(@"..\!Contra009Beta2.ctr", @"..\!Contra009Beta2.big");
                }
                if ((RadioOrigQuotes.Checked) && (File.Exists("!Contra009Beta2VOrig.ctr")))
                {
                    File.Move("!Contra009Beta2VOrig.ctr", "!Contra009Beta2VOrig.big");
                }
                else if ((RadioOrigQuotes.Checked) && (File.Exists(@"..\!Contra009Beta2VOrig.ctr")))
                {
                    File.Move(@"..\!Contra009Beta2VOrig.ctr", @"..\!Contra009Beta2VOrig.big");
                }
                if ((RadioLocQuotes.Checked) && (File.Exists("!Contra009Beta2VLoc.ctr")))
                {
                    File.Move("!Contra009Beta2VLoc.ctr", "!Contra009Beta2VLoc.big");
                }
                else if ((RadioLocQuotes.Checked) && (File.Exists(@"..\!Contra009Beta2VLoc.ctr")))
                {
                    File.Move(@"..\!Contra009Beta2VLoc.ctr", @"..\!Contra009Beta2VLoc.big");
                }
                if ((RadioEN.Checked) && (File.Exists("!Contra009Beta2EN.ctr")))
                {
                    File.Move("!Contra009Beta2EN.ctr", "!Contra009Beta2EN.big");
                }
                else if ((RadioEN.Checked) && (File.Exists(@"..\!Contra009Beta2EN.ctr")))
                {
                    File.Move(@"..\!Contra009Beta2EN.ctr", @"..\!Contra009Beta2EN.big");
                }
                if ((RadioRU.Checked) && (File.Exists("!Contra009Beta2RU.ctr")))
                {
                    File.Move("!Contra009Beta2RU.ctr", "!Contra009Beta2RU.big");
                }
                else if ((RadioRU.Checked) && (File.Exists(@"..\!Contra009Beta2RU.ctr")))
                {
                    File.Move(@"..\!Contra009Beta2RU.ctr", @"..\!Contra009Beta2RU.big");
                }
                if ((MNew.Checked) && (File.Exists("!Contra009Beta2MNew.ctr")))
                {
                    File.Move("!Contra009Beta2MNew.ctr", "!Contra009Beta2MNew.big");
                }
                else if ((MNew.Checked) && (File.Exists(@"..\!Contra009Beta2MNew.ctr")))
                {
                    File.Move(@"..\!Contra009Beta2MNew.ctr", @"..\!Contra009Beta2MNew.big");
                }
                if ((Properties.Settings.Default.Fog == false) && (File.Exists("!!Contra009FinalFogOff.ctr")))
                {
                    File.Move("!!Contra009FinalFogOff.ctr", "!!Contra009FinalFogOff.big");
                }
                else if ((Properties.Settings.Default.Fog == false) && (File.Exists(@"..\!!Contra009FinalFogOff.ctr")))
                {
                    File.Move(@"..\!!Contra009FinalFogOff.ctr", @"..\!!Contra009FinalFogOff.big");
                }
                else if ((Properties.Settings.Default.Fog == true) && (File.Exists("!!Contra009FinalFogOff.big")))
                {
                    File.Move("!!Contra009FinalFogOff.big", "!!Contra009FinalFogOff.ctr");
                }
                else if ((Properties.Settings.Default.Fog == true) && (File.Exists(@"..\!!Contra009FinalFogOff.big")))
                {
                    File.Move(@"..\!!Contra009FinalFogOff.big", @"..\!!Contra009FinalFogOff.ctr");
                }
                if ((Properties.Settings.Default.LangF == false) && (File.Exists("langdata.dat")))
                {
                    File.Move("langdata.dat", "langdata1.dat");
                }
                else if ((Properties.Settings.Default.LangF == false) && (File.Exists(@"..\langdata.dat")))
                {
                    File.Move(@"..\langdata.dat", @"..\langdata1.dat");
                }
                else if ((Properties.Settings.Default.LangF == true) && (File.Exists("langdata1.dat")))
                {
                    File.Move("langdata1.dat", "langdata.dat");
                }
                else if ((Properties.Settings.Default.LangF == true) && (File.Exists(@"..\langdata1.dat")))
                {
                    File.Move(@"..\langdata1.dat", @"..\langdata.dat");
                }
                if ((GoofyPics.Checked) && (File.Exists("!!Contra009FinalOldGenPics.ctr")))
                {
                    File.Move("!!Contra009FinalOldGenPics.ctr", "!!Contra009FinalOldGenPics.big");
                }
                else if ((GoofyPics.Checked) && (File.Exists(@"..\!!Contra009FinalOldGenPics.ctr")))
                {
                    File.Move(@"..\!!Contra009FinalOldGenPics.ctr", @"..\!!Contra009FinalOldGenPics.big");
                }
                if (Directory.Exists(@"Data\Scripts"))
                {
                    Directory.Move(@"Data\Scripts", @"Data\Scripts1");
                }
                else if (Directory.Exists(@"..\Data\Scripts"))
                {
                    Directory.Move(@"..\Data\Scripts", @"..\Data\Scripts1");
                }
                if (File.Exists("Install_Final_Contra.bmp") && File.Exists("Install_Final_ZHC.bmp") && File.Exists("Install_Final.bmp"))
                {
                    File.Move("Install_Final.bmp", "Install_Final_ZHC.bmp");
                    File.Move("Install_Final_Contra.bmp", "Install_Final.bmp");
                }
                else if (File.Exists(@"..\Install_Final_Contra.bmp") && File.Exists(@"..\Install_Final_ZHC.bmp") && File.Exists(@"..\Install_Final.bmp"))
                {
                    File.Move(@"..\Install_Final.bmp", @"..\Install_Final_ZHC.bmp");
                    File.Move(@"..\Install_Final_Contra.bmp", @"..\Install_Final.bmp");
                }
                if (File.Exists("Install_Final_Contra.bmp") && File.Exists("Install_Final.bmp"))
                {
                    File.Move("Install_Final.bmp", "Install_Final_ZHC.bmp");
                    File.Move("Install_Final_Contra.bmp", "Install_Final.bmp");
                }
                else if (File.Exists(@"..\Install_Final_Contra.bmp") && File.Exists(@"..\Install_Final.bmp"))
                {
                    File.Move(@"..\Install_Final.bmp", @"..\Install_Final_ZHC.bmp");
                    File.Move(@"..\Install_Final_Contra.bmp", @"..\Install_Final.bmp");
                }
                if (WinCheckBox.Checked && QSCheckBox.Checked)
                {
                    isWbRunning();
                    this.StartFileWinQS(StartGenerals);
                }
                if (QSCheckBox.Checked && WinCheckBox.Checked == false)
                {
                    isWbRunning();
                    this.StartFileQS(StartGenerals);
                }
                if (WinCheckBox.Checked && QSCheckBox.Checked == false)
                {
                    isWbRunning();
                    this.StartFileWin(StartGenerals);
                }
                if (WinCheckBox.Checked == false && QSCheckBox.Checked == false)
                {
                    isWbRunning();
                    this.StartFile(StartGenerals);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
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
            else if (File.Exists(@"..\!Contra009Beta2.ctr"))
            {
                File.Move(@"..\!Contra009Beta2.ctr", @"..\!Contra009Beta2.big");
            }
            if (File.Exists("!Contra009Beta2EN.ctr"))
            {
                File.Move("!Contra009Beta2EN.ctr", "!Contra009Beta2EN.big");
            }
            else if (File.Exists(@"..\!Contra009Beta2EN.ctr"))
            {
                File.Move(@"..\!Contra009Beta2EN.ctr", @"..\!Contra009Beta2EN.big");
            }
            if (File.Exists("!Contra009Beta2VLoc.ctr"))
            {
                File.Move("!Contra009Beta2VLoc.ctr", "!Contra009Beta2VLoc.big");
            }
            else if (File.Exists(@"..\!Contra009Beta2VVLoc.ctr"))
            {
                File.Move(@"..\!Contra009Beta2VLoc.ctr", @"..\!Contra009Beta2VLoc.big");
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
                else if (File.Exists(@"..\WorldBuilder_Ctr.exe"))
                {
                    wb.StartInfo.FileName = "WorldBuilder_Ctr.exe";
                    wb.StartInfo.WorkingDirectory = Path.GetDirectoryName(@"..\WorldBuilder_Ctr.exe");
                    wb.Start();
                }
                else if (File.Exists("WorldBuilder.exe"))
                {
                    wb.StartInfo.FileName = "WorldBuilder.exe";
                    wb.StartInfo.WorkingDirectory = Path.GetDirectoryName("WorldBuilder.exe");
                    wb.Start();
                }
                else if (File.Exists(@"..\WorldBuilder.exe"))
                {
                    wb.StartInfo.FileName = "WorldBuilder.exe";
                    wb.StartInfo.WorkingDirectory = Path.GetDirectoryName(@"..\WorldBuilder.exe");
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
            //System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
            //ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));
            //resources.ApplyResources(this, "$this");
            //applyResourcesEN(resources, this.Controls);
        }

        private void applyResourcesEN(ComponentResourceManager resources, Control.ControlCollection ctls)
        {
            foreach (Control ctl in ctls)
            {
                resources.ApplyResources(ctl, ctl.Name);
                applyResourcesEN(resources, ctl.Controls);
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ru-RU");
            //ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));
            //resources.ApplyResources(this, "$this");
            //applyResourcesRU(resources, this.Controls);
        }

        private void applyResourcesRU(ComponentResourceManager resources, Control.ControlCollection ctls)
        {
            foreach (Control ctl in ctls)
            {
                resources.ApplyResources(ctl, ctl.Name);
                applyResourcesRU(resources, ctl.Controls);
            }
        }

        private void applyResourcesBG(ComponentResourceManager resources, Control.ControlCollection ctls)
        {
            foreach (Control ctl in ctls)
            {
                resources.ApplyResources(ctl, ctl.Name);
                applyResourcesBG(resources, ctl.Controls);
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //            Globals.tincpath = Properties.Settings.Default.tincpath;
            //            Globals.TincFound = Properties.Settings.Default.TincFound;
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
            //            FogCheckBox.Checked = Properties.Settings.Default.Fog;
            radioFlag_GB.Checked = Properties.Settings.Default.Flag_GB;
            radioFlag_RU.Checked = Properties.Settings.Default.Flag_RU;
            radioFlag_UA.Checked = Properties.Settings.Default.Flag_UA;
            radioFlag_BG.Checked = Properties.Settings.Default.Flag_BG;
            //            LangFilterCheckBox.Checked = Properties.Settings.Default.LangF;
            //Globals.FogFX_Checked = Properties.Settings.Default.Fog;
            //Globals.LangF_Checked = Properties.Settings.Default.LangF;
            AutoScaleMode = AutoScaleMode.Dpi;
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
            //            Properties.Settings.Default.Fog = FogCheckBox.Checked;
            Properties.Settings.Default.Flag_GB = radioFlag_GB.Checked;
            Properties.Settings.Default.Flag_RU = radioFlag_RU.Checked;
            Properties.Settings.Default.Flag_UA = radioFlag_UA.Checked;
            Properties.Settings.Default.Flag_BG = radioFlag_BG.Checked;
            //            Properties.Settings.Default.LangF = LangFilterCheckBox.Checked;
            //Properties.Settings.Default.Fog = Globals.FogFX_Checked;
            //Properties.Settings.Default.LangF = Globals.LangF_Checked;
            Properties.Settings.Default.Save();
            if (File.Exists(path + "_tmpChunk.dat"))
            {
                File.Delete(path + "_tmpChunk.dat");
            }
            if (File.Exists(xppath + "_tmpChunk.dat"))
            {
                File.Delete(xppath + "_tmpChunk.dat");
            }
            Process[] vpnprocesses = Process.GetProcessesByName("tincd");
            foreach (Process vpnprocess in vpnprocesses)
            {
                vpnprocess.Kill();
                vpnprocess.WaitForExit();
                vpnprocess.Dispose();
                //vpn_start.BackgroundImage = (System.Drawing.Image)(Properties.Resources.vpn_off);
                //labelVpnStatus.Text = "Off";
            }
            Properties.Settings.Default.IP_Label = "ContraVPN IP: none";
            this.Close();
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

        private void GoofyPics_CheckedChanged(object sender, EventArgs e)
        {

        }

        //**********TINC CODE START**********

        public void vpnOff()
        {
            if (InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    vpn_start.BackgroundImage = (System.Drawing.Image)(Properties.Resources.vpn_off);
                    onlinePlayersBtn.Hide();
                    whoIsOnline.Hide();
                    if (Globals.GB_Checked == true)
                    {
                        playersOnlineLabel.Text = "ContraVPN disabled";
                        labelVpnStatus.Text = "Off";
                        Properties.Settings.Default.IP_Label = "ContraVPN IP: none";
                    }
                    else if (Globals.RU_Checked == true)
                    {
                        playersOnlineLabel.Text = "ContraVPN disabled";
                        labelVpnStatus.Text = "Off";
                        Properties.Settings.Default.IP_Label = "ContraVPN IP: none";
                    }
                    else if (Globals.UA_Checked == true)
                    {
                        playersOnlineLabel.Text = "ContraVPN disabled";
                        labelVpnStatus.Text = "Off";
                        Properties.Settings.Default.IP_Label = "ContraVPN IP: none";
                    }
                    else if (Globals.BG_Checked == true)
                    {
                        playersOnlineLabel.Text = "ContraVPN изключен";
                        labelVpnStatus.Text = "Изкл.";
                        Properties.Settings.Default.IP_Label = "ContraVPN IP: none";
                    }
                }));
                return;
            }
        }

        public void vpnOffNoCond()
        {
            {
                vpn_start.BackgroundImage = (System.Drawing.Image)(Properties.Resources.vpn_off);
                onlinePlayersBtn.Hide();
                whoIsOnline.Hide();
                if (Globals.GB_Checked == true)
                {
                    playersOnlineLabel.Text = "ContraVPN disabled";
                    labelVpnStatus.Text = "Off";
                    Properties.Settings.Default.IP_Label = "ContraVPN IP: none";
                }
                else if (Globals.RU_Checked == true)
                {
                    playersOnlineLabel.Text = "ContraVPN disabled";
                    labelVpnStatus.Text = "Off";
                    Properties.Settings.Default.IP_Label = "ContraVPN IP: none";
                }
                else if (Globals.UA_Checked == true)
                {
                    playersOnlineLabel.Text = "ContraVPN disabled";
                    labelVpnStatus.Text = "Off";
                    Properties.Settings.Default.IP_Label = "ContraVPN IP: none";
                }
                else if (Globals.BG_Checked == true)
                {
                    playersOnlineLabel.Text = "ContraVPN изключен";
                    labelVpnStatus.Text = "Изкл.";
                    Properties.Settings.Default.IP_Label = "ContraVPN IP: none";
                }
                return;
            }
        }

        public void StartVPN()
        {
            Process tinc = new Process();
            //tinc.StartInfo.Arguments = "-n contravpn -D";
            tinc.StartInfo.Arguments = "--no-detach --config=. --debug=3 --pidfile=tinc.pid --option=AddressFamily=ipv4";
            // tinc.StartInfo.FileName = "tinc" + @"\" + "tincd.exe";
            tinc.StartInfo.FileName = "tincd.exe";
            tinc.StartInfo.UseShellExecute = true;
            //tinc.StartInfo.WorkingDirectory = Path.GetDirectoryName("tinc");
            tinc.StartInfo.WorkingDirectory = Environment.CurrentDirectory + @"\contravpn";
            if (File.Exists(@"contravpn\tinc.conf"))
            {
                tinc.Start();

                //check when tinc gets turned off
                tinc.EnableRaisingEvents = true;
                tinc.Exited += (sender, e) =>
                {
                    vpnOff();
                };

                string tincd = "tincd.exe";
                Process[] tincdByName = Process.GetProcessesByName(tincd.Substring(0, tincd.LastIndexOf('.')));
                if (tincdByName.Length > 0)
                {
                    vpn_start.BackgroundImage = (System.Drawing.Image)(Properties.Resources.vpn_on);
                    onlinePlayersBtn.Show();
                    whoIsOnline.Show();
                    if (Globals.GB_Checked == true)
                    {
                        labelVpnStatus.Text = "On";
                    }
                    else if (Globals.RU_Checked == true)
                    {
                        labelVpnStatus.Text = "On";
                    }
                    else if (Globals.UA_Checked == true)
                    {
                        labelVpnStatus.Text = "On";
                    }
                    else if (Globals.BG_Checked == true)
                    {
                        labelVpnStatus.Text = "Вкл.";
                    }
                    onlinePlayersBtn.PerformClick();
                }
            }

            else //if (!Directory.Exists(@"contravpn\contravpn"))
            {
                if (Globals.GB_Checked == true)
                {
                    MessageBox.Show("Cannot start ContraVPN because \"tinc.conf\" file was not found. Make sure you have entered your invitation link first (go to ContraVPN Settings > Invite).", "Error");
                }
                else if (Globals.RU_Checked == true)
                {
                    MessageBox.Show("Cannot start ContraVPN because \"hosts\" folder was not found. Make sure you have entered your invitation link first (go to ContraVPN Settings > Invite).", "Error");
                }
                else if (Globals.BG_Checked == true)
                {
                    MessageBox.Show("ContraVPN не можа да се стартира, защото \"hosts\" папката не беше намерена. Уверете се, че сте въвели ключа си за покана (отидете във VPN Настройки > Покана).", "Грешка");
                }
                vpnOffNoCond();
            }
        }

        public void StartVPN_NoWindow()
        {
            Process tinc = new Process();
            tinc.StartInfo.Arguments = "--no-detach --config=\"" + Environment.CurrentDirectory + "\\contravpn\" --debug=3 --pidfile=\"" + Environment.CurrentDirectory + "\\contravpn\\tinc.pid\" --logfile=\"" + Environment.CurrentDirectory + "\\contravpn\\tinc.log\" --option=AddressFamily=ipv4";
            tinc.StartInfo.FileName = Environment.CurrentDirectory + @"\contravpn\tincd.exe";
            tinc.StartInfo.UseShellExecute = false;
            tinc.StartInfo.CreateNoWindow = true;
            if (File.Exists(@"contravpn\tinc.conf"))
            {
                tinc.Start();

                //check when tinc gets turned off
                tinc.EnableRaisingEvents = true;
                tinc.Exited += (sender, e) =>
                {
                    vpnOff();
                };

                string tincd = "tincd.exe";
                Process[] tincdByName = Process.GetProcessesByName(tincd.Substring(0, tincd.LastIndexOf('.')));
                if (tincdByName.Length > 0)
                {
                    vpn_start.BackgroundImage = (System.Drawing.Image)(Properties.Resources.vpn_on);
                    onlinePlayersBtn.Show();
                    whoIsOnline.Show();
                    if (Globals.GB_Checked == true)
                    {
                        labelVpnStatus.Text = "On";
                    }
                    else if (Globals.RU_Checked == true)
                    {
                        labelVpnStatus.Text = "On";
                    }
                    else if (Globals.UA_Checked == true)
                    {
                        labelVpnStatus.Text = "On";
                    }
                    else if (Globals.BG_Checked == true)
                    {
                        labelVpnStatus.Text = "Вкл.";
                    }
                    onlinePlayersBtn.PerformClick();
                }
            }

            //else if (!Directory.Exists("tinc" + @"\contravpn"))
            else //if (!Directory.Exists("contravpn"))
            {
                if (Globals.GB_Checked == true)
                {
                    MessageBox.Show("Cannot start ContraVPN because \"tinc.conf\" file was not found. Make sure you have entered your invitation link first (go to ContraVPN Settings > Invite).", "Error");
                }
                else if (Globals.RU_Checked == true)
                {
                    MessageBox.Show("Cannot start ContraVPN because \"tinc.conf\" file was not found. Make sure you have entered your invitation link first. (go to ContraVPN Settings > Invite)", "Error");
                }
                else if (Globals.BG_Checked == true)
                {
                    MessageBox.Show("ContraVPN не можа да се стартира, защото файлът \"tinc.conf\" не беше намерен. Уверете се, че сте въвели ключа си за покана (отидете във VPN Настройки > Покана).", "Грешка");
                }
                vpnOffNoCond();
            }
        }

        private void buttonVPNstart_Click(object sender, EventArgs e)
        {
            try
            {
                string tincd = "tincd.exe";
                Process[] tincdByName = Process.GetProcessesByName(tincd.Substring(0, tincd.LastIndexOf('.')));
                if (tincdByName.Length > 0)
                {
                    if (Globals.GB_Checked == true)
                    {
                        MessageBox.Show("\"Tincd.exe\" is already running!");
                    }
                    else if (Globals.BG_Checked == true)
                    {
                        MessageBox.Show("\"Tincd.exe\" вече е отворен!");
                    }
                }
                else //if (tincdByName.Length == 0)
                {
                    StartVPN();
                }

                Process ipconfig = new Process();
                ipconfig.StartInfo.FileName = "cmd.exe";
                ipconfig.StartInfo.UseShellExecute = false;
                ipconfig.StartInfo.RedirectStandardInput = true;
                ipconfig.StartInfo.RedirectStandardOutput = true;
                ipconfig.StartInfo.CreateNoWindow = true;
                ipconfig.Start();
                ipconfig.StandardInput.WriteLine("ipconfig");
                ipconfig.StandardInput.Flush();
                ipconfig.StandardInput.Close();
                string s = ipconfig.StandardOutput.ReadToEnd();
                if (s.Contains("10.10.10.") == true)
                {
                    //shows everything ipconfig                    MessageBox.Show(s);
                    ipconfig.WaitForExit();
                    ipconfig.Close();
                    if (File.Exists(path + "Options.ini"))
                    {
                        List<string> found = new List<string>();
                        string line;
                        using (StringReader file = new StringReader(s))
                        {
                            while ((line = file.ReadLine()) != null)
                            {
                                if (line.Contains("10.10.10."))
                                {
                                    found.Add(line);
                                    s = line;
                                    s = s.Substring(s.IndexOf(':') + 1);
                                    Properties.Settings.Default.IP_Label = "ContraVPN IP: " + s;
                                    //                                                      MessageBox.Show(s); //shows tincIP
                                }
                            }
                        }

                    }
                    if (Directory.Exists(path))
                    {
                        string text = File.ReadAllText(path + "Options.ini");
                        if (!text.Contains("10.10.10."))
                        {
                            File.WriteAllText(path + "Options.ini", Regex.Replace(File.ReadAllText(path + "Options.ini"), "\r?\nIPAddress =.*", "\r\nIPAddress =" + s + "\r\n"));
                        }
                    }
                    else if (Directory.Exists(xppath))
                    {
                        string text = File.ReadAllText(xppath + "Options.ini");
                        if (!text.Contains("10.10.10."))
                        {
                            string AppendTincIP = Environment.NewLine + "UPnP = no";
                            File.AppendAllText(xppath + "Options.ini", AppendTincIP);
                        }
                    }
                }
                else Properties.Settings.Default.IP_Label = "ContraVPN IP: none";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }

        private void buttonVPNinvOK_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public string getCurrentCulture()
        {
            var culture = System.Globalization.CultureInfo.CurrentCulture;
            string cultureStr = culture.ToString();
            return cultureStr;
        }

        //public void checkLang()
        //{
        //    if (getCurrentCulture() == "en-US")
        //    {
        //        radioFlag_GB.Checked = true;
        //    }
        //    else if (getCurrentCulture() == "ru-RU")
        //    {
        //        radioFlag_RU.Checked = true;
        //    }
        //    else if (getCurrentCulture() == "uk-UA")
        //    {
        //        radioFlag_UA.Checked = true;
        //    }
        //    else if (getCurrentCulture() == "bg-BG")
        //    {
        //        radioFlag_BG.Checked = true;
        //    }
        //    else
        //    {
        //        radioFlag_GB.Checked = true;
        //    }
        //}

        private void Form1_Shown(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.FirstRun)
            {
                //Enable Tournament Mode (limit super weapons and super units) on first run.
                if (Directory.Exists(path))
                {
                    string text = File.ReadAllText(path + "Skirmish.ini");
                    {
                        if (text.Contains("SuperweaponRestrict = No"))
                        {
                            File.WriteAllText(path + "Skirmish.ini", File.ReadAllText(path + "Skirmish.ini").Replace("SuperweaponRestrict = No", "SuperweaponRestrict = Yes"));
                            //string fixedText = text.Replace("SuperweaponRestrict = No", "SuperweaponRestrict = Yes");
                            //File.WriteAllText("Skirmish.ini", fixedText);
                        }
                        else
                        {
                            //
                        }
                    }
                }

                //Check UPnP to yes by default on first run.
                if ((File.Exists("contravpn/tinc.conf")) && ((File.ReadAllText("contravpn/tinc.conf").Contains("UPnP")) == false))
                {
                    string AppendUPnP = Environment.NewLine + "UPnP = yes";
                    File.AppendAllText("contravpn/tinc.conf", AppendUPnP);
                }
                else if ((File.Exists("contravpn/tinc.conf")) && ((File.ReadAllText("contravpn/tinc.conf").Contains("UPnP = no")) == true))
                {
                    string text = File.ReadAllText("contravpn/tinc.conf");
                    text = text.Replace("UPnP = no", "UPnP = yes");
                    File.WriteAllText("contravpn/tinc.conf", text);
                }
                //else if ((File.Exists(Globals.tincpath + "/contravpn/tinc.conf")) && ((File.ReadAllText(Globals.tincpath + "/contravpn/tinc.conf").Contains("UPnP")) == false))
                //{
                //    string AppendUPnP = Environment.NewLine + "UPnP = yes";
                //    File.AppendAllText(Globals.tincpath + "/contravpn/tinc.conf", AppendUPnP);
                //}
                //else if ((File.Exists(Globals.tincpath + "/contravpn/tinc.conf")) && ((File.ReadAllText(Globals.tincpath + "/contravpn/tinc.conf").Contains("UPnP = no")) == true))
                //{
                //    string text = File.ReadAllText(Globals.tincpath + "/contravpn/tinc.conf");
                //    text = text.Replace("UPnP = no", "UPnP = yes");
                //    File.WriteAllText(Globals.tincpath + "/contravpn/tinc.conf", text);
                //}

                //Show message on first run.
                if (getCurrentCulture() == "en-US")
                {
                    MessageBox.Show("Welcome to Contra 009 Final! Since this is your first time running this launcher, we would like to let you know that you have a new opportunity to play Contra online via ContraVPN! We highly recommend you to join our Discord community!");
                    radioFlag_GB.Checked = true;
                }
                else if (getCurrentCulture() == "ru-RU")
                {
                    MessageBox.Show("Добро пожаловать в Contra 009 Final! Поскольку это Ваш первый запуск этого лаунчера, мы хотим сообщить Вам о том, что у Вас есть новая возможность играть в Contra онлайн через ContraVPN! Мы настоятельно рекомендуем Вам присоедениться к нашей группе Discord.");
                    radioFlag_RU.Checked = true;
                }
                else if (getCurrentCulture() == "uk-UA")
                {
                    MessageBox.Show("Ласкаво просимо до Contra 009 Final! Оскільки це Ваш перший запуск цього лаунчера, ми хочемо повідомити Вас про те, що у Вас є нова можливість відтворити Contra онлайн через ContraVPN! Ми максимально рекомендуємо Вам приєднатися до нашої спільноти Discord.");
                    radioFlag_UA.Checked = true;
                }
                else if (getCurrentCulture() == "bg-BG")
                {
                    MessageBox.Show("Добре дошли в Contra 009 Final! Тъй като това е първото Ви стартиране на Contra, бихме искали да знаете, че имате нова възможност да играете Contra онлайн чрез ContraVPN! Силно препоръчваме да се присъедините към нашата Discord общност! Еее... то и български имало бе! ;)");
                    radioFlag_BG.Checked = true;
                }
                else
                {
                    MessageBox.Show("Welcome to Contra 009 Final! Since this is your first time running this launcher, we would like to let you know that you have a new opportunity to play Contra online via ContraVPN! We highly recommend you to join our Discord community!");
                    radioFlag_GB.Checked = true;
                }
                Properties.Settings.Default.FirstRun = false;
                Properties.Settings.Default.Save();
            }
        }

        private void VPNMoreButton_Click(object sender, EventArgs e)
        {
            foreach (Form VPNForm in Application.OpenForms)
            {
                if (VPNForm is VPNForm)
                {
                    VPNForm.Close();
                    new VPNForm().Show();
                    return;
                }
            }
            new VPNForm().Show();

            //    VPNForm VPNForm = new VPNForm();
            //    if (VPNForm == null)
            //    {
            //       VPNForm.Show();
            //   }
        }

        private void buttonVPNstart_MouseEnter(object sender, EventArgs e)
        {
            buttonVPNstart.BackgroundImage = (System.Drawing.Image)(Properties.Resources._button_vpn_text);
            buttonVPNstart.ForeColor = SystemColors.ButtonHighlight;
            buttonVPNstart.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }
        private void buttonVPNstart_MouseLeave(object sender, EventArgs e)
        {
            buttonVPNstart.BackgroundImage = (System.Drawing.Image)(Properties.Resources._button_vpn);
            buttonVPNstart.ForeColor = SystemColors.ButtonHighlight;
            buttonVPNstart.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }
        private void buttonVPNstart_MouseDown(object sender, MouseEventArgs e)
        {
            buttonVPNstart.BackgroundImage = (System.Drawing.Image)(Properties.Resources._button_highlight);
            buttonVPNstart.ForeColor = SystemColors.ButtonHighlight;
            buttonVPNstart.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }

        private void VPNMoreButton_MouseEnter(object sender, EventArgs e)
        {
            VPNMoreButton.BackgroundImage = (System.Drawing.Image)(Properties.Resources._button_config_tr);
            VPNMoreButton.ForeColor = SystemColors.ButtonHighlight;
            VPNMoreButton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }
        private void VPNMoreButton_MouseLeave(object sender, EventArgs e)
        {
            VPNMoreButton.BackgroundImage = (System.Drawing.Image)(Properties.Resources._button_config);
            VPNMoreButton.ForeColor = SystemColors.ButtonHighlight;
            VPNMoreButton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }
        private void VPNMoreButton_MouseDown(object sender, MouseEventArgs e)
        {
            VPNMoreButton.BackgroundImage = (System.Drawing.Image)(Properties.Resources._button_sm_highlight);
            VPNMoreButton.ForeColor = SystemColors.ButtonHighlight;
            VPNMoreButton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }

        //private void ReceiveCheckedChanged(object sender, EventArgs e)
        //{
        //    CheckBox chk = sender as CheckBox;
        //    if (radioFlag_GB.Checked)
        //        Globals.GB_Checked = true; //MessageBox.Show("");//this.label1.Text = "Checked";
        //   // else
        //        //this.label1.Text = "UnChecked";
        //}

        private void radioFlag_GB_CheckedChanged(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));
            resources.ApplyResources(this, "$this");
            applyResourcesEN(resources, this.Controls);
            Globals.BG_Checked = false;
            Globals.RU_Checked = false;
            Globals.UA_Checked = false;
            Globals.GB_Checked = true;  //this.radioFlag_GB.CheckedChanged += new EventHandler(this.ReceiveCheckedChanged);
            //  toolTip_BG.Dispose();
            toolTip1.SetToolTip(RadioLocQuotes, "Units of all three factions will speak English.");
            toolTip1.SetToolTip(RadioOrigQuotes, "Each faction's units will speak their native language.");
            toolTip1.SetToolTip(RadioEN, "English in-game language.");
            toolTip1.SetToolTip(RadioRU, "Russian in-game language.");
            toolTip1.SetToolTip(MNew, "Use new soundtracks.");
            toolTip1.SetToolTip(MStandard, "Use standard Zero Hour soundtracks.");
            toolTip1.SetToolTip(DefaultPics, "Use default general portraits.");
            toolTip1.SetToolTip(GoofyPics, "Use funny general portraits.");
            toolTip1.SetToolTip(WinCheckBox, "Starts Contra in a window instead of full screen.");
            toolTip1.SetToolTip(QSCheckBox, "Disables intro and shellmap (game starts up faster).");
            toolTip1.SetToolTip(onlinePlayersBtn, "Refresh online players.");
            toolTip1.SetToolTip(whoIsOnline, "Show who is online.");
            toolTip1.SetToolTip(vpn_start, "Start/close ContraVPN.");
            //            toolTip1.SetToolTip(FogCheckBox, "Toggle fog (depth of field) effects on/off.\nThis effect adds a color layer at the top of the screen, depending on the map.");
            //            toolTip1.SetToolTip(LangFilterCheckBox, "Disabling the language filter will show bad words written by players in chat.");

            string tincd = "tincd.exe";
            Process[] tincdByName = Process.GetProcessesByName(tincd.Substring(0, tincd.LastIndexOf('.')));
            if (tincdByName.Length > 0) //if tinc is already running
            {
                vpn_start.BackgroundImage = (System.Drawing.Image)(Properties.Resources.vpn_on);
                onlinePlayersBtn.Show();
                whoIsOnline.Show();
                labelVpnStatus.Text = "On";
                //                playersOnlineLabel.Text = "ContraVPN disabled";
                onlinePlayersBtn.PerformClick();
            }
        }

        private void radioFlag_RU_CheckedChanged(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ru-RU");
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));
            resources.ApplyResources(this, "$this");
            applyResourcesRU(resources, this.Controls);
            Globals.GB_Checked = false;
            Globals.BG_Checked = false;
            Globals.UA_Checked = false;
            Globals.RU_Checked = true;
            toolTip1.SetToolTip(RadioLocQuotes, "Юниты всех трех фракций будут разговаривать на английском.");
            toolTip1.SetToolTip(RadioOrigQuotes, "Юниты каждой фракции будут разговаривать на их родном языке.");
            toolTip1.SetToolTip(RadioEN, "Английский язык.");
            toolTip1.SetToolTip(RadioRU, "Русский язык.");
            toolTip1.SetToolTip(MNew, "Включить новые саундтреки.");
            toolTip1.SetToolTip(MStandard, "Включить стандартные саундтреки Zero Hour.");
            toolTip1.SetToolTip(DefaultPics, "Включить портреты Генералов по умолчанию.");
            toolTip1.SetToolTip(GoofyPics, "Включить смешные портреты Генералов.");
            toolTip1.SetToolTip(WinCheckBox, "Запуск Contra в режиме окна вместо полноэкранного.");
            toolTip1.SetToolTip(QSCheckBox, "Отключает интро и шелмапу (игра запускается быстрее).");
            toolTip1.SetToolTip(onlinePlayersBtn, "Refresh online players.");
            toolTip1.SetToolTip(whoIsOnline, "Show who is online.");
            toolTip1.SetToolTip(vpn_start, "Start/close ContraVPN.");

            string tincd = "tincd.exe";
            Process[] tincdByName = Process.GetProcessesByName(tincd.Substring(0, tincd.LastIndexOf('.')));
            if (tincdByName.Length > 0) //if tinc is already running
            {
                vpn_start.BackgroundImage = (System.Drawing.Image)(Properties.Resources.vpn_on);
                onlinePlayersBtn.Show();
                whoIsOnline.Show();
                labelVpnStatus.Text = "On";
                //                playersOnlineLabel.Text = "ContraVPN disabled";
                onlinePlayersBtn.PerformClick();
            }
        }

        private void radioFlag_UA_CheckedChanged(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("uk-UA");
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));
            resources.ApplyResources(this, "$this");
            applyResourcesBG(resources, this.Controls);
            Globals.GB_Checked = false;
            Globals.RU_Checked = false;
            Globals.BG_Checked = false;
            Globals.UA_Checked = true;
            toolTip1.SetToolTip(RadioLocQuotes, "Юніти всіх трьох фракцій розмовлятимуть англійською.");
            toolTip1.SetToolTip(RadioOrigQuotes, "Юніти кожної фракції розмовлятимуть їхньою рідною мовою.");
            toolTip1.SetToolTip(RadioEN, "Англійська мова.");
            toolTip1.SetToolTip(RadioRU, "Російська мова.");
            toolTip1.SetToolTip(MNew, "Використовуйте нові саундтреки.");
            toolTip1.SetToolTip(MStandard, "Використовуйте стандартні саундтреки Zero Hour.");
            toolTip1.SetToolTip(DefaultPics, "Використовуйте портрети Генералів за замовчуванням.");
            toolTip1.SetToolTip(GoofyPics, "Використовуйте смішні портрети Генералів.");
            toolTip1.SetToolTip(WinCheckBox, "Запускає Contra у віконному режимі замість повноекранного.");
            toolTip1.SetToolTip(QSCheckBox, "Вимикає інтро і шелмапу (гра запускається швидше).");
            toolTip1.SetToolTip(onlinePlayersBtn, "Refresh online players.");
            toolTip1.SetToolTip(whoIsOnline, "Show who is online.");
            toolTip1.SetToolTip(vpn_start, "Start/close ContraVPN.");

            string tincd = "tincd.exe";
            Process[] tincdByName = Process.GetProcessesByName(tincd.Substring(0, tincd.LastIndexOf('.')));
            if (tincdByName.Length > 0) //if tinc is already running
            {
                vpn_start.BackgroundImage = (System.Drawing.Image)(Properties.Resources.vpn_on);
                onlinePlayersBtn.Show();
                whoIsOnline.Show();
                labelVpnStatus.Text = "On";
                //                playersOnlineLabel.Text = "ContraVPN disabled";
                onlinePlayersBtn.PerformClick();
            }
        }

        private void radioFlag_BG_CheckedChanged(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("bg-BG");
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));
            resources.ApplyResources(this, "$this");
            applyResourcesBG(resources, this.Controls);
            Globals.GB_Checked = false;
            Globals.RU_Checked = false;
            Globals.UA_Checked = false;
            Globals.BG_Checked = true;
            // toolTip1.Dispose();
            toolTip1.SetToolTip(RadioLocQuotes, "Единиците на трите фракции ще говорят на английски.");
            toolTip1.SetToolTip(RadioOrigQuotes, "Единиците на трите фракции ще говорят на техния роден език.");
            toolTip1.SetToolTip(RadioEN, "Английски език в играта.");
            toolTip1.SetToolTip(RadioRU, "Руски език в играта.");
            toolTip1.SetToolTip(MNew, "Използвайте новата музика.");
            toolTip1.SetToolTip(MStandard, "Използвайте стандартната музика в Zero Hour.");
            toolTip1.SetToolTip(DefaultPics, "Използвайте оригиналните генералски портрети.");
            toolTip1.SetToolTip(GoofyPics, "Използвайте забавните генералски портрети.");
            toolTip1.SetToolTip(WinCheckBox, "Стартира Contra в нов прозорец вместо на цял екран.");
            toolTip1.SetToolTip(QSCheckBox, "Изключва интрото и анимираната карта (шел-мапа). Играта стартира по-бързо.");
            toolTip1.SetToolTip(onlinePlayersBtn, "Обнови.");
            toolTip1.SetToolTip(whoIsOnline, "Покажи кои играчи са на линия.");
            toolTip1.SetToolTip(vpn_start, "Включи/изключи ContraVPN.");
            //toolTip1.SetToolTip(FogCheckBox, "Превключете ефекта \"дълбочина на рязкост\".\nТози ефект добавя цветен слой на върха на екрана, зависещ от атмосферата на картата. Например, мъгла.");
            //toolTip1.SetToolTip(LangFilterCheckBox, "Изключването на езиковия филтър ще спре да скрива лошите думи, написани от играчите.");

            string tincd = "tincd.exe";
            Process[] tincdByName = Process.GetProcessesByName(tincd.Substring(0, tincd.LastIndexOf('.')));
            if (tincdByName.Length > 0) //if tinc is already running
            {
                vpn_start.BackgroundImage = (System.Drawing.Image)(Properties.Resources.vpn_on);
                onlinePlayersBtn.Show();
                whoIsOnline.Show();
                labelVpnStatus.Text = "On";
                //                playersOnlineLabel.Text = "ContraVPN disabled";
                onlinePlayersBtn.PerformClick();
            }
        }

        private void LangFilterCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Resolution_Click(object sender, EventArgs e)
        {
            foreach (Form moreOptionsForm in Application.OpenForms)
            {
                if (moreOptionsForm is moreOptionsForm)
                {
                    moreOptionsForm.Close();
                    new moreOptionsForm().Show();
                    return;
                }
            }
            new moreOptionsForm().Show();
        }

        private void Resolution_MouseEnter(object sender, EventArgs e)
        {
            Resolution.ForeColor = Color.FromArgb(255, 210, 100);
        }

        private void Resolution_MouseDown(object sender, MouseEventArgs e)
        {
            Resolution.ForeColor = Color.FromArgb(255, 230, 160);
        }

        private void Resolution_MouseLeave(object sender, EventArgs e)
        {
            Resolution.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void button18_MouseEnter(object sender, EventArgs e)
        {
            button18.BackgroundImage = (System.Drawing.Image)(Properties.Resources.exit11);
        }

        private void button18_MouseLeave(object sender, EventArgs e)
        {
            button18.BackgroundImage = (System.Drawing.Image)(Properties.Resources.exit1);
        }

        private void button17_MouseEnter(object sender, EventArgs e)
        {
            button17.BackgroundImage = (System.Drawing.Image)(Properties.Resources.min11);
        }

        private void button17_MouseLeave(object sender, EventArgs e)
        {
            button17.BackgroundImage = (System.Drawing.Image)(Properties.Resources.min);
        }

        //Timer, waiting for reachable nodes to appear. //Activates when online players button is clicked and tincd is not started yet.
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;

            timer1.Interval = 1000;
            Process onlinePlayers = new Process();
            onlinePlayers.StartInfo.Arguments = "--config=\"" + Environment.CurrentDirectory + "\\contravpn\" --pidfile=\"" + Environment.CurrentDirectory + "\\contravpn\\tinc.pid\"";
            onlinePlayers.StartInfo.FileName = Environment.CurrentDirectory + @"\contravpn\tinc.exe";
            onlinePlayers.StartInfo.UseShellExecute = false;
            onlinePlayers.StartInfo.RedirectStandardInput = true;
            onlinePlayers.StartInfo.RedirectStandardOutput = true;
            onlinePlayers.StartInfo.CreateNoWindow = true;
            onlinePlayers.Start();
            onlinePlayers.StandardInput.WriteLine("dump reachable nodes");
            onlinePlayers.StandardInput.Flush();
            onlinePlayers.StandardInput.Close();
            string s = onlinePlayers.StandardOutput.ReadToEnd();
            if (s.Contains("id") == true)
            {
                int s2 = Regex.Matches(s, "id").Count;
                if (s.Contains("ctrvpntest") == true)
                {
                    s2 -= 1;
                }
                if (s.Contains("contravpn") == true)
                {
                    s2 -= 1;
                }
                //                s2 -= 1; //excluding local user
                if (Globals.GB_Checked == true)
                {
                    playersOnlineLabel.Text = "Players online: " + s2.ToString();
                }
                else if (Globals.RU_Checked == true)
                {
                    playersOnlineLabel.Text = "Players online: " + s2.ToString();
                }
                else if (Globals.UA_Checked == true)
                {
                    playersOnlineLabel.Text = "Players online: " + s2.ToString();
                }
                else if (Globals.BG_Checked == true)
                {
                    playersOnlineLabel.Text = "Играчи на линия: " + s2.ToString();
                }
                onlinePlayers.WaitForExit();
                onlinePlayers.Close();
            }
        }

        private void onlinePlayersBtn_Click(object sender, EventArgs e)
        {
            if (Globals.GB_Checked == true)
            {
                playersOnlineLabel.Text = "Loading...";
            }
            else if (Globals.RU_Checked == true)
            {
                playersOnlineLabel.Text = "Loading...";
            }
            else if (Globals.UA_Checked == true)
            {
                playersOnlineLabel.Text = "Loading...";
            }
            else if (Globals.BG_Checked == true)
            {
                playersOnlineLabel.Text = "Зарежда се...";
            }
            //string tincd = "tincd.exe";
            //Process[] tincdByName = Process.GetProcessesByName(tincd.Substring(0, tincd.LastIndexOf('.')));
            //if (tincdByName.Length > 0) //if tincd is already running
            //{
            timer1.Enabled = true; //Enable timer. Implementation is inside timer1_Tick()
            //}
        }

        private void onlinePlayersBtn_MouseDown(object sender, MouseEventArgs e)
        {
            onlinePlayersBtn.BackgroundImage = (System.Drawing.Image)(Properties.Resources.refresh);
            onlinePlayersBtn.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }

        private void onlinePlayersBtn_MouseEnter(object sender, EventArgs e)
        {
            onlinePlayersBtn.BackgroundImage = (System.Drawing.Image)(Properties.Resources.refresh_tr);
            onlinePlayersBtn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            onlinePlayersBtn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            onlinePlayersBtn.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }

        private void onlinePlayersBtn_MouseLeave(object sender, EventArgs e)
        {
            onlinePlayersBtn.BackgroundImage = (System.Drawing.Image)(Properties.Resources.refresh);
            onlinePlayersBtn.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }

        private void vpn_start_Click(object sender, EventArgs e)
        {
            //check if adapter is installed
            DisplayDnsConfiguration();
            if (Properties.Settings.Default.adapterExists == true)
            {
                //MessageBox.Show("The adapter already exists!");
            }
            else
            {
                try
                {
                    if (Globals.GB_Checked == true)
                    {
                        MessageBox.Show("TAP-Windows Adapter V9 is not installed. Starting setup...");
                    }
                    else if (Globals.RU_Checked == true)
                    {
                        MessageBox.Show("TAP-Windows Adapter V9 is not installed. Starting setup...");
                    }
                    else if (Globals.UA_Checked == true)
                    {
                        MessageBox.Show("TAP-Windows Adapter V9 is not installed. Starting setup...");
                    }
                    else if (Globals.BG_Checked == true)
                    {
                        MessageBox.Show("TAP-Windows Adapter V9 не е инсталиран. Стартиране на инсталацията...");
                    }
                    string path = Path.GetDirectoryName(Application.ExecutablePath);
                    Process adapter = new Process();
                    adapter.StartInfo.FileName = path + @"\contravpn\tap-windows-9.9.2_3.exe";
                    adapter.StartInfo.Arguments = "/S";
                    adapter.Start();
                    adapter.WaitForExit();
                    DisplayDnsConfiguration();
                    if (Properties.Settings.Default.adapterExists == true)
                    {
                        if (Globals.GB_Checked == true)
                        {
                            MessageBox.Show("TAP-Windows Adapter V9 has been installed successfully!");
                        }
                        else if (Globals.RU_Checked == true)
                        {
                            MessageBox.Show("TAP-Windows Adapter V9 has been installed successfully!");
                        }
                        else if (Globals.UA_Checked == true)
                        {
                            MessageBox.Show("TAP-Windows Adapter V9 has been installed successfully!");
                        }
                        else if (Globals.BG_Checked == true)
                        {
                            MessageBox.Show("TAP-Windows Adapter V9 беше инсталиран успешно!");
                        }
//                        DisplayDnsConfiguration();
//                        Properties.Settings.Default.adapterExists = true;
                    }
                    else
                    {
                        if (Globals.GB_Checked == true)
                        {
                            MessageBox.Show("There was a problem with the TAP-Windows Adapter V9 installation.");
                        }
                        else if (Globals.RU_Checked == true)
                        {
                            MessageBox.Show("There was a problem with the TAP-Windows Adapter V9 installation.");
                        }
                        else if (Globals.UA_Checked == true)
                        {
                            MessageBox.Show("There was a problem with the TAP-Windows Adapter V9 installation.");
                        }
                        else if (Globals.BG_Checked == true)
                        {
                            MessageBox.Show("Възникна проблем с инсталацията на TAP-Windows Adapter V9.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            try //check if tincd is running or not
            {
                string tincd = "tincd.exe";
                Process[] tincdByName = Process.GetProcessesByName(tincd.Substring(0, tincd.LastIndexOf('.')));
                if (tincdByName.Length > 0)
                {
                    Process[] vpnprocesses = Process.GetProcessesByName("tincd");
                    foreach (Process vpnprocess in vpnprocesses)
                    {
                        vpnprocess.Kill();
                        vpnprocess.WaitForExit();
                        vpnprocess.Dispose();

                        vpn_start.BackgroundImage = (System.Drawing.Image)(Properties.Resources.vpn_off);
                        onlinePlayersBtn.Hide();
                        whoIsOnline.Hide();
                        if (Globals.GB_Checked == true)
                        {
                            playersOnlineLabel.Text = "ContraVPN disabled";
                            labelVpnStatus.Text = "Off";
                        }
                        else if (Globals.RU_Checked == true)
                        {
                            playersOnlineLabel.Text = "ContraVPN disabled";
                            labelVpnStatus.Text = "Off";
                        }
                        else if (Globals.UA_Checked == true)
                        {
                            playersOnlineLabel.Text = "ContraVPN disabled";
                            labelVpnStatus.Text = "Off";
                        }
                        else if (Globals.BG_Checked == true)
                        {
                            playersOnlineLabel.Text = "ContraVPN изключен";
                            labelVpnStatus.Text = "Изкл.";
                        }
                        return;
                    }
                }
                else
                {
                    if (Globals.GB_Checked == true)
                    {
                        playersOnlineLabel.Text = "Loading...";
                    }
                    else if (Globals.RU_Checked == true)
                    {
                        playersOnlineLabel.Text = "Loading...";
                    }
                    else if (Globals.UA_Checked == true)
                    {
                        playersOnlineLabel.Text = "Loading...";
                    }
                    else if (Globals.BG_Checked == true)
                    {
                        playersOnlineLabel.Text = "Зарежда се...";
                    }
                    if (Properties.Settings.Default.ShowConsole == true)
                    {
                        StartVPN();
                    }
                    else
                    {
                        StartVPN_NoWindow();
                    }
                }

                Process ipconfig = new Process();
                ipconfig.StartInfo.FileName = "cmd.exe";
                ipconfig.StartInfo.UseShellExecute = false;
                ipconfig.StartInfo.RedirectStandardInput = true;
                ipconfig.StartInfo.RedirectStandardOutput = true;
                ipconfig.StartInfo.CreateNoWindow = true;
                ipconfig.Start();
                ipconfig.StandardInput.WriteLine("ipconfig");
                ipconfig.StandardInput.Flush();
                ipconfig.StandardInput.Close();
                string s = ipconfig.StandardOutput.ReadToEnd();
                if (s.Contains("10.10.10.") == true)
                {
                    //shows everything ipconfig                    MessageBox.Show(s);
                    ipconfig.WaitForExit();
                    ipconfig.Close();
                    if (File.Exists(path + "Options.ini"))
                    {
                        List<string> found = new List<string>();
                        string line;
                        using (StringReader file = new StringReader(s))
                        {
                            while ((line = file.ReadLine()) != null)
                            {
                                if (line.Contains("10.10.10."))
                                {
                                    found.Add(line);
                                    s = line;
                                    s = s.Substring(s.IndexOf(':') + 1);
                                    Properties.Settings.Default.IP_Label = "ContraVPN IP: " + s;
                                    //                                                     MessageBox.Show(s); //shows tincIP
                                }
                            }
                        }

                    }
                    if (Directory.Exists(path))
                    {
                        string text = File.ReadAllText(path + "Options.ini");
                        if (!text.Contains("10.10.10."))
                        {
                            File.WriteAllText(path + "Options.ini", Regex.Replace(File.ReadAllText(path + "Options.ini"), "\r?\nIPAddress =.*", "\r\nIPAddress =" + s + "\r\n"));
                        }
                    }
                    else if (Directory.Exists(xppath))
                    {
                        string text = File.ReadAllText(xppath + "Options.ini");
                        if (!text.Contains("10.10.10."))
                        {
                            string AppendTincIP = Environment.NewLine + "UPnP = no";
                            File.AppendAllText(xppath + "Options.ini", AppendTincIP);
                        }
                    }
                }
                else Properties.Settings.Default.IP_Label = "ContraVPN IP: none";
            }
            catch (Exception ex)
            {
                vpnOffNoCond();
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void whoIsOnline_Click(object sender, EventArgs e)
        {
            string tincd = "tincd.exe";
            Process[] tincdByName = Process.GetProcessesByName(tincd.Substring(0, tincd.LastIndexOf('.')));
            if (tincdByName.Length > 0) //if tincd is already running
            {
                Process onlinePlayers = new Process();
                onlinePlayers.StartInfo.Arguments = "--config=\"" + Environment.CurrentDirectory + "\\contravpn\" --pidfile=\"" + Environment.CurrentDirectory + "\\contravpn\\tinc.pid\"";
                onlinePlayers.StartInfo.FileName = Environment.CurrentDirectory + @"\contravpn\tinc.exe";
                onlinePlayers.StartInfo.UseShellExecute = false;
                onlinePlayers.StartInfo.RedirectStandardInput = true;
                onlinePlayers.StartInfo.RedirectStandardOutput = true;
                onlinePlayers.StartInfo.CreateNoWindow = true;
                onlinePlayers.Start();
                onlinePlayers.StandardInput.WriteLine("dump reachable nodes");
                onlinePlayers.StandardInput.Flush();
                onlinePlayers.StandardInput.Close();
                string s = onlinePlayers.StandardOutput.ReadToEnd();
                //                MessageBox.Show(s);

                string s_concat = "";
                Regex pattern = new Regex(@"([^\s]+) id");

                foreach (var match in pattern.Matches(s))
                {

                    string matchString = match.ToString();
                    //             string result = rgx.Replace(matchString, "");
                    //matchString = matchString.Replace("contravpn", "");
                    //matchString = matchString.Replace("ctrvpntest9", "");
                    //              matchString = Regex.Replace(matchString, pattern2, "");
                    if (!matchString.Contains("contravpn") && (!matchString.Contains("ctrvpntest9")))
                    {
                        s_concat += matchString;
                    }
                }
                //     s_concat = s_concat.Replace("  ", "\n");
                //    s_concat = s_concat.Replace(" ", "");
                //              s_concat = s_concat.Replace("  ", "\n");
                s_concat = s_concat.Replace("id", "\n");
                s_concat = s_concat.Replace("predatorbg", "PredatoR");
                s_concat = s_concat.Replace("ggpersun", "GG`PeRSuN^");
                s_concat = s_concat.Replace("armanis", "Armanis");
                s_concat = s_concat.Replace("maelstrom", "Maelstrom");
                s_concat = s_concat.Replace("wwb2", "WWB2");
                s_concat = s_concat.Replace("kinomoto", "The_Dark_One");
                if (Globals.GB_Checked == true)
                {
                    MessageBox.Show(s_concat, "Who is online?");
                }
                else if (Globals.RU_Checked == true)
                {
                    MessageBox.Show(s_concat, "Who is online?");
                }
                else if (Globals.UA_Checked == true)
                {
                    MessageBox.Show(s_concat, "Who is online?");
                }
                else if (Globals.BG_Checked == true)
                {
                    MessageBox.Show(s_concat, "Кой е онлайн?");
                }

                if (s.Contains("id") == true)
                {
                    int s2 = Regex.Matches(s, "id").Count;
                    if (s.Contains("ctrvpntest") == true)
                    {
                        s2 -= 1;
                    }
                    if (s.Contains("contravpn") == true)
                    {
                        s2 -= 1;
                    }
                    if (Globals.GB_Checked == true)
                    {
                        playersOnlineLabel.Text = "Players online: " + s2.ToString();
                    }
                    else if (Globals.RU_Checked == true)
                    {
                        playersOnlineLabel.Text = "Players online: " + s2.ToString();
                    }
                    else if (Globals.UA_Checked == true)
                    {
                        playersOnlineLabel.Text = "Players online: " + s2.ToString();
                    }
                    else if (Globals.BG_Checked == true)
                    {
                        playersOnlineLabel.Text = "Играчи на линия: " + s2.ToString();
                    }
                    onlinePlayers.WaitForExit();
                    onlinePlayers.Close();
                }
            }
        }

        private void whoIsOnline_MouseDown(object sender, MouseEventArgs e)
        {
            whoIsOnline.BackgroundImage = (System.Drawing.Image)(Properties.Resources.ppl);
            whoIsOnline.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }

        private void whoIsOnline_MouseEnter(object sender, EventArgs e)
        {
            whoIsOnline.BackgroundImage = (System.Drawing.Image)(Properties.Resources.ppl_tr);
            whoIsOnline.FlatAppearance.MouseOverBackColor = Color.Transparent;
            whoIsOnline.FlatAppearance.MouseDownBackColor = Color.Transparent;
            whoIsOnline.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }

        private void whoIsOnline_MouseLeave(object sender, EventArgs e)
        {
            whoIsOnline.BackgroundImage = (System.Drawing.Image)(Properties.Resources.ppl);
            whoIsOnline.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }

        private void radioFlag_GB_MouseEnter(object sender, EventArgs e)
        {
            radioFlag_GB.BackgroundImage = (System.Drawing.Image)(Properties.Resources.flag_gb_tr);
        }
        private void radioFlag_GB_MouseLeave(object sender, EventArgs e)
        {
            radioFlag_GB.BackgroundImage = (System.Drawing.Image)(Properties.Resources.flag_gb);
        }

        private void radioFlag_RU_MouseEnter(object sender, EventArgs e)
        {
            radioFlag_RU.BackgroundImage = (System.Drawing.Image)(Properties.Resources.flag_ru_tr);
        }
        private void radioFlag_RU_MouseLeave(object sender, EventArgs e)
        {
            radioFlag_RU.BackgroundImage = (System.Drawing.Image)(Properties.Resources.flag_ru);
        }

        private void radioFlag_UA_MouseEnter(object sender, EventArgs e)
        {
            radioFlag_UA.BackgroundImage = (System.Drawing.Image)(Properties.Resources.flag_ua_tr);
        }
        private void radioFlag_UA_MouseLeave(object sender, EventArgs e)
        {
            radioFlag_UA.BackgroundImage = (System.Drawing.Image)(Properties.Resources.flag_ua);
        }

        private void radioFlag_BG_MouseEnter(object sender, EventArgs e)
        {
            radioFlag_BG.BackgroundImage = (System.Drawing.Image)(Properties.Resources.flag_bg_tr);
        }
        private void radioFlag_BG_MouseLeave(object sender, EventArgs e)
        {
            radioFlag_BG.BackgroundImage = (System.Drawing.Image)(Properties.Resources.flag_bg);
        }

        public static void DisplayDnsConfiguration()
        {
            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface adapter in adapters)
            {
                IPInterfaceProperties properties = adapter.GetIPProperties();
                if (adapter.Description.Contains("TAP-Windows Adapter V9") == true && (adapter.Name.Contains("swr.netv2") == false && (adapter.Name.Contains("ContraVPN") == false)))
                {
                    DialogResult dialogResult = MessageBox.Show("Use adapter " + adapter.Name + " for ContraVPN?", "Choose Adapter", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Process cmd = new Process();
                        cmd.StartInfo.FileName = "cmd.exe";
                        cmd.StartInfo.UseShellExecute = false;
                        cmd.StartInfo.RedirectStandardInput = true;
                        cmd.StartInfo.RedirectStandardOutput = true;
                        cmd.StartInfo.CreateNoWindow = true;
                        cmd.Start();
                        cmd.StandardInput.WriteLine("netsh interface set interface name = " + adapter.Name + " newname = \"ContraVPN\"");
                        cmd.StandardInput.Flush();
                        cmd.StandardInput.Close();
                        Properties.Settings.Default.adapterExists = true;
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        Properties.Settings.Default.adapterExists = false;
                    }
                }
            }
        }
    }
}
