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
            LangFilterCheckBox.TabStop = false;
            buttonVPNstart.TabStop = false;
            VPNMoreButton.TabStop = false;

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

        public bool CheckBoxChecked
        {
            get { return radioFlag_GB.Checked; }
            set { radioFlag_GB.Checked = value; }
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
                if (button1WasClicked == true)
                {
                    MessageBox.Show(ex.Message, "Error");
                    //return;
                    //MessageBox.Show("If you have one or more .big files opened, close them and try again. You also can't launch Contra if generals.exe is already running.", "Error");
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
                if ((!FogCheckBox.Checked) && (File.Exists("!!Contra009FinalFogOff.ctr")))
                {
                    File.Move("!!Contra009FinalFogOff.ctr", "!!Contra009FinalFogOff.big");
                }
                else if ((!FogCheckBox.Checked) && (File.Exists(@"..\!!Contra009FinalFogOff.ctr")))
                {
                    File.Move(@"..\!!Contra009FinalFogOff.ctr", @"..\!!Contra009FinalFogOff.big");
                }
                if ((!LangFilterCheckBox.Checked) && (File.Exists("langdata.dat")))
                {
                    File.Move("langdata.dat", "langdata1.dat");
                }
                else if ((!LangFilterCheckBox.Checked) && (File.Exists(@"..\langdata1.dat")))
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
                if (File.Exists("Install_Final_Contra.bmp") && File.Exists("Install_Final_ZHC.bmp"))
                {
                    File.Move("Install_Final.bmp", "Install_Final_ZHC.bmp");
                    File.Move("Install_Final_Contra.bmp", "Install_Final.bmp");
                }
                else if (File.Exists(@"..\Install_Final_Contra.bmp") && File.Exists(@"..\Install_Final_ZHC.bmp"))
                {
                    File.Move(@"..\Install_Final.bmp", @"..\Install_Final_ZHC.bmp");
                    File.Move(@"..\Install_Final_Contra.bmp", @"..\Install_Final.bmp");
                }
                if (File.Exists("Install_Final_Contra.bmp"))
                {
                    File.Move("Install_Final.bmp", "Install_Final_ZHC.bmp");
                    File.Move("Install_Final_Contra.bmp", "Install_Final.bmp");
                }
                else if (File.Exists(@"..\Install_Final_Contra.bmp"))
                {
                    File.Move(@"..\Install_Final.bmp", @"..\Install_Final_ZHC.bmp");
                    File.Move(@"..\Install_Final_Contra.bmp", @"..\Install_Final.bmp");
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

            //try
            //{
            //    if (File.Exists("Install_Final_Contra.bmp") && File.Exists("Install_Final_ZHC.bmp"))
            //    {
            //        File.Move("Install_Final.bmp", "Install_Final_ZHC.bmp");
            //        File.Move("Install_Final_Contra.bmp", "Install_Final.bmp");
            //    }
            //    if (File.Exists("Install_Final_Contra.bmp"))
            //    {
            //        File.Move("Install_Final.bmp", "Install_Final_ZHC.bmp");
            //        File.Move("Install_Final_Contra.bmp", "Install_Final.bmp");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error");
            //    return;
            //}
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
            if (File.Exists("!Contra009Beta2VOrig.ctr"))
            {
                File.Move("!Contra009Beta2VOrig.ctr", "!Contra009Beta2VOrig.big");
            }
            else if (File.Exists(@"..\!Contra009Beta2VOrig.ctr"))
            {
                File.Move(@"..\!Contra009Beta2VOrig.ctr", @"..\!Contra009Beta2VOrig.big");
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
            Globals.tincpath = Properties.Settings.Default.tincpath;
            Globals.TincFound = Properties.Settings.Default.TincFound;
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
            radioFlag_GB.Checked = Properties.Settings.Default.Flag_GB;
            radioFlag_RU.Checked = Properties.Settings.Default.Flag_RU;
            radioFlag_UA.Checked = Properties.Settings.Default.Flag_UA;
            radioFlag_BG.Checked = Properties.Settings.Default.Flag_BG;
            LangFilterCheckBox.Checked = Properties.Settings.Default.LangF;
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
            Properties.Settings.Default.Flag_GB = radioFlag_GB.Checked;
            Properties.Settings.Default.Flag_RU = radioFlag_RU.Checked;
            Properties.Settings.Default.Flag_UA = radioFlag_UA.Checked;
            Properties.Settings.Default.Flag_BG = radioFlag_BG.Checked;
            Properties.Settings.Default.LangF = LangFilterCheckBox.Checked;
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

        public void GetTincInstalledPath_Registry_StartVPN()
        {
            GetTincInstalledPath();
            Process tinc = new Process();
            tinc.StartInfo.Arguments = "-n contravpn -D";
            tinc.StartInfo.FileName = "tincd.exe";
            GetTincInstalledPath().Replace("\"", "");
            tinc.StartInfo.WorkingDirectory = Path.GetDirectoryName(GetTincInstalledPath() + @"\");
            if (Directory.Exists(GetTincInstalledPath() + @"\contravpn"))
            {
                tinc.Start();
            }
            else if (!Directory.Exists(GetTincInstalledPath()))
            {
                GetTincInstalledPath_User_StartVPN();
            }
            else if (!Directory.Exists(GetTincInstalledPath() + @"\contravpn"))
            {
                if (getCurrentCulture() == "en-US")
                {
                    MessageBox.Show("Cannot start ContraVPN because \"contravpn\" folder was not found. Make sure you have entered your invitation link first.", "Error");
                }
                else if (getCurrentCulture() == "ru-RU")
                {
                    MessageBox.Show("Cannot start ContraVPN because \"contravpn\" folder was not found. Make sure you have entered your invitation link first.", "Error");
                }
                else if (getCurrentCulture() == "bg-BG")
                {
                    MessageBox.Show("ContraVPN не можа да се стартира, защото \"contravpn\" папката не беше намерена. Убедете се, че сте въвели ключа си за покана.", "Грешка");
                }
                //tinc.Start();
                //GetTincInstalledPath_User_StartVPN();
            }
        }

        public void GetTincInstalledPath_User_StartVPN()
        {
            Globals.TincFound = Properties.Settings.Default.TincFound;
            //var TincInstalledPath = string.Empty;
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (Globals.TincFound == false)
            {
                MessageBox.Show("\"tincd.exe\" not found! Select tinc installation directory.", "Error");
                fbd.Description = "Select tinc installation directory.";
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    var tincpath = fbd.SelectedPath;
                    //TincInstalledPath = tincpath;
                    Properties.Settings.Default.tincpath = fbd.SelectedPath;
                    Properties.Settings.Default.Save();
                    Process tinc = new Process();
                    tinc.StartInfo.Arguments = "-n contravpn -D";
                    tinc.StartInfo.FileName = "tincd.exe";
                    tinc.StartInfo.WorkingDirectory = Path.GetDirectoryName(tincpath + @"\tincd.exe");
                    if (File.Exists(tincpath + @"\tincd.exe"))
                    {
                        if (Directory.Exists(tincpath + @"\contravpn"))
                        {
                            tinc.Start();
                            Properties.Settings.Default.TincFound = true;
                            Properties.Settings.Default.Save();
                        }
                        else if (!Directory.Exists(tincpath + @"\contravpn"))
                        {
                            MessageBox.Show("Cannot start ContraVPN because \"contravpn\" folder was not found. Make sure you have entered your invitation link first.", "Error");
                            //                            tinc.Start();
                            Properties.Settings.Default.TincFound = true;
                            Properties.Settings.Default.Save();
                        }
                    }
                    else
                    {
                        MessageBox.Show("\"tincd.exe\" not found there!", "Error");
                        Properties.Settings.Default.TincFound = false;
                        Properties.Settings.Default.Save();
                    }
                }
            }
            else if ((Globals.TincFound == true))
            {
                Process tinc = new Process();
                tinc.StartInfo.Arguments = "-n contravpn -D";
                tinc.StartInfo.FileName = "tincd.exe";
                tinc.StartInfo.WorkingDirectory = Path.GetDirectoryName(Globals.tincpath + @"\tincd.exe");
                if (File.Exists(Globals.tincpath + @"\tincd.exe"))
                {
                    if (Directory.Exists(Globals.tincpath + @"\contravpn"))
                    {
                        tinc.Start();
                        Properties.Settings.Default.TincFound = true;
                        Properties.Settings.Default.Save();
                    }
                    else if (!Directory.Exists(Globals.tincpath + @"\contravpn"))
                    {
                        MessageBox.Show("Cannot start ContraVPN because \"contravpn\" folder was not found. Make sure you have entered your invitation link first.", "Error");
                        //                        tinc.Start();
                        Properties.Settings.Default.TincFound = true;
                        Properties.Settings.Default.Save();
                    }
                }
                else
                {
                    MessageBox.Show("\"tincd.exe\" not found there!", "Error");
                    Properties.Settings.Default.TincFound = false;
                    Properties.Settings.Default.Save();
                }
            }
        }

        private void buttonVPNstart_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    GetTincInstalledPath_Registry_StartVPN();
                
            //}
            //catch (Exception)
            //{
            //    GetTincInstalledPath_User_StartVPN();
            //}
            try
            {
                GetTincInstalledPath_Registry_StartVPN();

                //Process[] pname = Process.GetProcessesByName("tincd");
                //if (pname.Length != 0)
                //{
                //    MessageBox.Show("runs");
                //}

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
//                                    MessageBox.Show(s); //shows tincIP
                                }
                            }
                        }

                    }
                    if (Directory.Exists(path))
                    {
                        string text = File.ReadAllText(path + "Options.ini");
                        if (!text.Contains("10.10.10."))
                        {
                            //Regex rgx = new Regex(text);
                            //string result = rgx.Replace("^IPAddress.*$", "IPaddress = " + s);
                            //File.WriteAllText(path + "Options.ini", text);

                            File.WriteAllText(path + "Options.ini", Regex.Replace(File.ReadAllText(path + "Options.ini"), "\r?\nIPAddress =.*", "\r\nIPAddress =" + s + "\r\n"));

                            //Regex.Replace(text, "\r?\nIPAddress =.*", "\nIPAddress = " + s);
                            //File.WriteAllText(path + "Options.ini", text);

                            //text = text.Replace("IPAddress =", "IPAddress =" + s + " ;"); //adds ip next to = .... 192
                            //File.WriteAllText(path + "Options.ini", text);

                       //     string AppendTincIP = Environment.NewLine + "IPAddressWithtincIP";
                       //     File.AppendAllText(xppath + "Options.ini", AppendTincIP);
                        }
                    }
  //deletes all text after this                  //text = text.Remove(text.IndexOf(s));

                  //  Regex.Replace(text, @"(^|\n).IPAddress.\n?", "", RegexOptions.Multiline);

                  //  string result = Regex.Replace(text, ".*IPAddress =.*", "replacement string");

                    //string[] lines = System.IO.File.ReadAllLines(path + "Options.ini");
                    //lines[0] = "IPAddress =" + s;
                    //System.IO.File.WriteAllLines(path + "Options.ini", lines);

                    else if (Directory.Exists(xppath))
                    {
                        string text = File.ReadAllText(xppath + "Options.ini");
                        if (!text.Contains("10.10.10."))
                        {
                            //Regex.Replace(text, ".*IPAddress*.", "IPAddressWithtincIP");
                            //text = text.Replace("IPAddress =", "IPAddress =" + s + " ;"); //adds ip next to = .... 192
                            string AppendTincIP = Environment.NewLine + "UPnP = no";
                            File.AppendAllText(xppath + "Options.ini", AppendTincIP);
                        }
                    }
                }



                //else MessageBox.Show("not found tinc ip");

                //if (File.Exists("tincd.exe")) GetTincInstalledPath_Registry_StartVPN();
                //else GetTincInstalledPath_User_StartVPN();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }

        //private void buttonVPNinvkey_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        GetTincInstalledPath_Registry_EnterInvKey();
        //    }
        //    catch (Exception)
        //    {
        //        GetTincInstalledPath_User_EnterInvKey();
        //    }
        //    //catch (Exception ex)
        //    //{
        //    //    MessageBox.Show(ex.Message, "Error");
        //    //}
        //}

        //private void buttonVPNconsole_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        GetTincInstalledPath_Registry_OpenConsole();
        //    }
        //    catch (Exception)
        //    {
        //        GetTincInstalledPath_User_OpenConsole();
        //    }
        //    //catch (Exception ex)
        //    //{
        //    //    MessageBox.Show(ex.Message, "Error");
        //    //}
        //}

        private void buttonVPNinvOK_Click(object sender, EventArgs e)
        {
            //GetTincInstalledPathInvKey();

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public string getCurrentCulture()
        {
            var culture = System.Globalization.CultureInfo.CurrentCulture;
            string cultureStr = culture.ToString();
            return cultureStr;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.FirstRun)
            {
                if (getCurrentCulture() == "en-US") //radioFlag_GB.Checked == true)
                {
                    MessageBox.Show("Welcome to Contra 009 Final! Since this is your first time running this launcher, we would like to let you know that you have a new opportunity to play Contra online via ContraVPN! We highly recommend you to join our Discord community!");
                }
                else if (getCurrentCulture() == "ru-RU")
                {
                    MessageBox.Show("Welcome to Contra 009 Final! Since this is your first time running this launcher, we would like to let you know that you have a new opportunity to play Contra online via ContraVPN! We highly recommend you to join our Discord community!");
                }
                else if (getCurrentCulture() == "bg-BG")
                {
                    MessageBox.Show("Добре дошли в Contra 009 Final! Тъй като това е първото Ви стартиране на Contra, бихме искали да знаете, че имате нова възможност да играете Contra онлайн чрез ContraVPN! Силно препоръчваме да се присъедините към нашата Discord общност! Еее... то и български имало бе! ;)");
                }
                Properties.Settings.Default.FirstRun = false;
                Properties.Settings.Default.Save();
            }
        }

        //private void buttonVPNdebuglog_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        GetTincInstalledPath_Registry_OpenDebugLog();
        //    }
        //    catch (Exception)
        //    {
        //        GetTincInstalledPath_User_OpenDebugLog();
        //    }
        //}

        private void VPNMoreButton_Click(object sender, EventArgs e)
        {
            foreach (Form VPNForm in Application.OpenForms)
            {
                if (VPNForm is VPNForm)
                {
                    VPNForm.Close();
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

        private void ReceiveCheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = sender as CheckBox;
            if (radioFlag_GB.Checked)
                Globals.GB_Checked = true; //MessageBox.Show("");//this.label1.Text = "Checked";
           // else
                //this.label1.Text = "UnChecked";
        }

        private void radioFlag_GB_CheckedChanged(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));
            resources.ApplyResources(this, "$this");
            applyResourcesEN(resources, this.Controls);
            Globals.BG_Checked = false;
            Globals.RU_Checked = false;
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
            toolTip1.SetToolTip(FogCheckBox, "Toggle fog (depth of field) effects on/off.\nThis effect adds a color layer at the top of the screen, depending on the map.");
            toolTip1.SetToolTip(LangFilterCheckBox, "Disabling the language filter will show bad words written by players in chat.");
        }

        private void radioFlag_RU_CheckedChanged(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ru-RU");
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));
            resources.ApplyResources(this, "$this");
            applyResourcesRU(resources, this.Controls);
            Globals.GB_Checked = false;
            Globals.BG_Checked = false;
            Globals.RU_Checked = true;
        }

        private void radioFlag_UA_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioFlag_BG_CheckedChanged(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("bg-BG");
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));
            resources.ApplyResources(this, "$this");
            applyResourcesBG(resources, this.Controls);
            Globals.GB_Checked = false;
            Globals.RU_Checked = false;
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
            toolTip1.SetToolTip(FogCheckBox, "Превключете ефекта \"дълбочина на рязкост\".\nТози ефект добавя цветен слой на върха на екрана, зависещ от атмосферата на картата. Например, мъгла.");
            toolTip1.SetToolTip(LangFilterCheckBox, "Изключването на езиковия филтър ще спре да скрива лошите думи, написани от играчите.");
        }

        private void LangFilterCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
