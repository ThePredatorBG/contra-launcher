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
            portTextBox.Text = Properties.Settings.Default.PortNumber;
            buttonVPNdebuglog.TabStop = false;
            buttonVPNinvkey.TabStop = false;
            buttonVPNconsole.TabStop = false;
            button17.TabStop = false;
            button18.TabStop = false;
            UPnPCheckBox.TabStop = false;
            AutoConnectCheckBox.TabStop = false;
            portTextBox.TabStop = false;
            portOkButton.TabStop = false;
            IP_Label.Text = Properties.Settings.Default.IP_Label;

            if (Globals.GB_Checked == true)
            {
                toolTip2.SetToolTip(UPnPCheckBox, "Search for local UPnP-IGD devices, this can improve connectivity if UPnP is enabled on your router.\nRequires miniupnpc support (tinc distributed by Contra has this, official does not).");
                toolTip2.SetToolTip(AutoConnectCheckBox, "Automatically set up meta connections to other nodes.\nThis allows you to retain connection with other players even if contravpn node goes down.\nOnly works with nodes that have open ports.");
                toolTip2.SetToolTip(showConsoleCheckBox, "Toggle on/off showing console when starting VPN.");
            }
            else if (Globals.RU_Checked == true)
            {
                toolTip2.SetToolTip(UPnPCheckBox, "Поиск локальных устройств UPnP-IGD, это может улучшить связь, если в вашем маршрутизаторе будет включено UPnP.\nНужна поддержка miniupnpc (tinc, что распространяется Contra, это не официально).");
                toolTip2.SetToolTip(AutoConnectCheckBox, "Автоматическая установка мета-соеденения с другими узлами.\nПозволяет сохранять связь с другими игроками, даже если узел ContraVPN выключен.\nРаботает только с узлами, которые имеют открытые порты.");
                toolTip2.SetToolTip(showConsoleCheckBox, "Toggle showing console when starting VPN on/off.");
            }
            else if (Globals.UA_Checked == true)
            {
                toolTip2.SetToolTip(UPnPCheckBox, "Пошук локальних пристроїв UPnP-IGD, це може покращити зв*язок, якщо у вашому маршрутизаторі буде ввімкнено UPnP.\nПотрібна підтримка miniupnpc (tinc, що розповсюджується Contra, це не офіційно).");
                toolTip2.SetToolTip(AutoConnectCheckBox, "Автоматично встановлювати мета-з*єднання з іншими вузлами.\nЦе дозволяє зберігати зв*язок з іншими гравцями, навіть якщо ContraVPN вузол знижується.\nПрацює тільки з вузлами, котрі мають відкриті порти.");
                toolTip2.SetToolTip(showConsoleCheckBox, "Toggle showing console when starting VPN on/off.");
            }
            else if (Globals.BG_Checked == true)
            {
                toolTip2.SetToolTip(UPnPCheckBox, "Търсете за локални UPnP-IGD устройства. Това може да подобри свързаността, ако UPnP е включен на вашия маршрутизатор.\nИзисква поддръжка на miniupnpc (tinc разпространен от Contra има това, официалният - не).");
                toolTip2.SetToolTip(AutoConnectCheckBox, "Автоматично настройване на мета-връзки към други възли.\nТова Ви позволява да запазите връзката си с другите играчи, дори когато contravpn възелът е офлайн.\nРаботи само с възли, които имат отворени портове.");
                toolTip2.SetToolTip(showConsoleCheckBox, "Превключете показване на конзолата при стартиране на ContraVPN.");
            }

            if ((File.Exists("contravpn/tinc.conf")) && ((File.ReadAllText("contravpn/tinc.conf").Contains("UPnP")) == false))
            {
                string AppendUPnP = Environment.NewLine + "UPnP = no";
                File.AppendAllText("contravpn/tinc.conf", AppendUPnP);
            }
            //else if ((File.Exists(Globals.tincpath + "/contravpn/tinc.conf")) && ((File.ReadAllText(Globals.tincpath + "/contravpn/tinc.conf").Contains("UPnP")) == false))
            //{
            //    string AppendUPnP = Environment.NewLine + "UPnP = no";
            //    File.AppendAllText(Globals.tincpath + "/contravpn/tinc.conf", AppendUPnP);
            //}

            if ((File.Exists("contravpn/tinc.conf")) && ((File.ReadAllText("contravpn/tinc.conf").Contains("AutoConnect")) == false))
            {
                string AppendUPnP = Environment.NewLine + "AutoConnect = no";
                File.AppendAllText("contravpn/tinc.conf", AppendUPnP);
            }
            //else if ((File.Exists(Globals.tincpath + "/contravpn/tinc.conf")) && ((File.ReadAllText(Globals.tincpath + "/contravpn/tinc.conf").Contains("AutoConnect")) == false))
            //{
            //    string AppendUPnP = Environment.NewLine + "AutoConnect = no";
            //    File.AppendAllText(Globals.tincpath + "/contravpn/tinc.conf", AppendUPnP);
            //}

            //Read from tinc.conf and check/uncheck our checkboxes depending on content:
            if ((File.Exists("contravpn/tinc.conf")) && ((File.ReadAllText("contravpn/tinc.conf").Contains("UPnP = no"))))
            {
                UPnPCheckBox.Checked = false;
            }
            else if ((File.Exists("contravpn/tinc.conf")) && (File.ReadAllText("contravpn/tinc.conf").Contains("UPnP = yes")))
            {
                UPnPCheckBox.Checked = true;
            }
            //else if ((File.Exists(Globals.tincpath + "/contravpn/tinc.conf")) && ((File.ReadAllText(Globals.tincpath + "/contravpn/tinc.conf").Contains("UPnP = no"))))
            //{
            //    UPnPCheckBox.Checked = false;
            //}
            //else if ((File.Exists(Globals.tincpath + "/contravpn/tinc.conf")) && (File.ReadAllText(Globals.tincpath + "/contravpn/tinc.conf").Contains("UPnP = yes")))
            //{
            //    UPnPCheckBox.Checked = true;
            //}

            if ((File.Exists("contravpn/tinc.conf")) && (File.ReadAllText("contravpn/tinc.conf").Contains("AutoConnect = no")))
            {
                AutoConnectCheckBox.Checked = false;
            }
            else if ((File.Exists("contravpn/tinc.conf")) && (File.ReadAllText("contravpn/tinc.conf").Contains("AutoConnect = yes")))
            {
                AutoConnectCheckBox.Checked = true;
            }
            //else if ((File.Exists(Globals.tincpath + "/contravpn/tinc.conf")) && (File.ReadAllText(Globals.tincpath + "/contravpn/tinc.conf").Contains("AutoConnect = no")))
            //{
            //    AutoConnectCheckBox.Checked = false;
            //}
            //else if ((File.Exists(Globals.tincpath + "/contravpn/tinc.conf")) && (File.ReadAllText(Globals.tincpath + "/contravpn/tinc.conf").Contains("AutoConnect = yes")))
            //{
            //    AutoConnectCheckBox.Checked = true;
            //}
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

        private void OnApplicationExit(object sender, EventArgs e) //VPNWindowExit
        {
            Properties.Settings.Default.ShowConsole = showConsoleCheckBox.Checked;
            Properties.Settings.Default.Save();
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
            if ((File.Exists("contravpn/tinc.conf")))
            {
                string tincconf = File.ReadAllText("contravpn/tinc.conf");
                if (UPnPCheckBox.Checked)
                {
                    tincconf = tincconf.Replace("UPnP = no", "UPnP = yes");
                    File.WriteAllText("contravpn/tinc.conf", tincconf);
                }
                else if (!UPnPCheckBox.Checked)
                {
                    tincconf = tincconf.Replace("UPnP = yes", "UPnP = no");
                    File.WriteAllText("contravpn/tinc.conf", tincconf);
                }
            }
            //else if (File.Exists(Globals.tincpath + "/contravpn/tinc.conf"))
            //{
            //    string tincconf = File.ReadAllText(Globals.tincpath + "/contravpn/tinc.conf");
            //    if (UPnPCheckBox.Checked)
            //    {
            //        tincconf = tincconf.Replace("UPnP = no", "UPnP = yes");
            //        File.WriteAllText(Globals.tincpath + "/contravpn/tinc.conf", tincconf);
            //    }
            //    else if (!UPnPCheckBox.Checked)
            //    {
            //        tincconf = tincconf.Replace("UPnP = yes", "UPnP = no");
            //        File.WriteAllText(Globals.tincpath + "/contravpn/tinc.conf", tincconf);
            //    }
            //}

            // else MessageBox.Show("\"tinc.conf\" not found! Toggling UPnP on/off has no effect.", "Error");
        }

        private void AutoConnectCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if ((File.Exists("contravpn/tinc.conf")))
            {
                string tincconf = File.ReadAllText("contravpn/tinc.conf");
                if (AutoConnectCheckBox.Checked)
                {
                    tincconf = tincconf.Replace("AutoConnect = no", "AutoConnect = yes");
                    File.WriteAllText("contravpn/tinc.conf", tincconf);
                }
                else if (!AutoConnectCheckBox.Checked)
                {
                    tincconf = tincconf.Replace("AutoConnect = yes", "AutoConnect = no");
                    File.WriteAllText("contravpn/tinc.conf", tincconf);
                }
            }
            //else if (File.Exists(Globals.tincpath + "/contravpn/tinc.conf"))
            //{
            //    string tincconf = File.ReadAllText(Globals.tincpath + "/contravpn/tinc.conf");
            //    if (AutoConnectCheckBox.Checked)
            //    {
            //        tincconf = tincconf.Replace("AutoConnect = no", "AutoConnect = yes");
            //        File.WriteAllText(Globals.tincpath + "/contravpn/tinc.conf", tincconf);
            //    }
            //    else if (!AutoConnectCheckBox.Checked)
            //    {
            //        tincconf = tincconf.Replace("AutoConnect = yes", "AutoConnect = no");
            //        File.WriteAllText(Globals.tincpath + "/contravpn/tinc.conf", tincconf);
            //    }
            //}

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
                OpenDebugLog();
            }
            catch (Exception)
            {
                OpenDebugLog();
            }
        }

        public void EnterInvKey()
        {
            if (File.Exists(Environment.CurrentDirectory + @"\contravpn\tinc.conf"))
            {
                if (Globals.GB_Checked == true)
                {
                    MessageBox.Show("Found existing \"tinc.conf\" file, looks like you have already been invited.");
                }
                else if (Globals.RU_Checked == true)
                {
                    MessageBox.Show("Найдено существующую папку \"tinc.conf\", похоже, что Вас уже пригласили.");
                }
                else if (Globals.UA_Checked == true)
                {
                    MessageBox.Show("Знайдено існуючу папку \"tinc.conf\", схоже, що Вас вже запросили.");
                }
                else if (Globals.BG_Checked == true)
                {
                    MessageBox.Show("Намерен е съществуващ файл с име \"tinc.conf\". Изглежда, че вече сте били поканени.");
                }
            }
            else// if (!Directory.Exists("tinc" + @"\contravpn"))
            {
                if (Globals.GB_Checked == true)
                {
                    MessageBox.Show("You can request an invite key on our Discord's #contravpn channel.");
                }
                else if (Globals.RU_Checked == true)
                {
                    MessageBox.Show("Вы можете получить ключ приглашения на нашем канале #contravpn Discord.");
                }
                else if (Globals.UA_Checked == true)
                {
                    MessageBox.Show("Ви можете отримати ключ запрошення на нашому каналі #contravpn Discord.");
                }
                else if (Globals.BG_Checked == true)
                {
                    MessageBox.Show("Можете да поискате покана в #contravpn канала ни в Discord.");
                }
                Process.Start("https://discord.gg/015E6KXXHmdWFXCtt");
//                Process tinc = new Process();
//                tinc.StartInfo.Arguments = "join";
//                tinc.StartInfo.FileName = "tinc.exe";
                InvitePanel.Show();
//                "tinc".Replace("\"", "");
//                tinc.StartInfo.WorkingDirectory = Path.GetDirectoryName("tinc" + @"\");
//                tinc.Start();
            }
        }

        public void OpenConsole()
        {
            Process tinc = new Process();
            tinc.StartInfo.Arguments = "--config=. --pidfile=tinc.pid";
            tinc.StartInfo.FileName = "tinc.exe";
            tinc.StartInfo.WorkingDirectory = Environment.CurrentDirectory + @"\contravpn";
            if (Directory.Exists(Environment.CurrentDirectory + @"\contravpn\"))
            {
                tinc.Start();
            }
            else
            {
                if (Globals.GB_Checked == true)
                {
                    MessageBox.Show("The \"tinc.conf\" file does not exist yet. Most commands will not execute.");
                }
                else if (Globals.RU_Checked == true)
                {
                    MessageBox.Show("Папка \"tinc.conf\" еще не существует. Большинство команд выполняться не будут.");
                }
                else if (Globals.UA_Checked == true)
                {
                    MessageBox.Show("Папка \"tinc.conf\" ще не існує. Більшість команд не виконуватимуться.");
                }
                else if (Globals.BG_Checked == true)
                {
                    MessageBox.Show("Файлът \"tinc.conf\" още не съществува. Повечето команди няма да се изпълнят.");
                }
                tinc.Start();
            }
        }

        public void OpenDebugLog()
        {
            Process debugLog = new Process();
            debugLog.StartInfo.FileName = "tinc.log";
            debugLog.StartInfo.WorkingDirectory = Environment.CurrentDirectory + @"\contravpn";
            //if (File.Exists("tinc" + @"\contravpn" + "contravpn.log"))
            if (File.Exists(Environment.CurrentDirectory + @"\contravpn\tinc.log"))
            {
                debugLog.Start();
            }
            else if (!File.Exists(Environment.CurrentDirectory + @"\contravpn\tinc.log"))
            {
                if (Globals.GB_Checked == true)
                {
                    MessageBox.Show("The \"tinc.log\" does not exist yet!", "Error");
                }
                else if (Globals.RU_Checked == true)
                {
                    MessageBox.Show("\"tinc.log\" еще не существует!", "Ошибка");
                }
                else if (Globals.UA_Checked == true)
                {
                    MessageBox.Show("\"tinc.log\" ще не існує!", "Помилка");
                }
                else if (Globals.BG_Checked == true)
                {
                    MessageBox.Show("\"tinc.log\" още не съществува!", "Грешка");
                }
            }
            else
            {
                if (Globals.GB_Checked == true)
                {
                    MessageBox.Show("The \"contravpn\" folder does not exist yet!", "Error");
                }
                else if (Globals.RU_Checked == true)
                {
                    MessageBox.Show("Папка \"contravpn\" еще не существует!", "Ошибка");
                }
                else if (Globals.UA_Checked == true)
                {
                    MessageBox.Show("Папка \"contravpn\" ще не існує!", "Помилка");
                }
                else if (Globals.BG_Checked == true)
                {
                    MessageBox.Show("\"contravpn\" папката още не съществува!", "Грешка");
                }
            }
        }

        private void buttonVPNinvkey_Click(object sender, EventArgs e)
        {
            try
            {
                EnterInvKey();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void buttonVPNconsole_Click(object sender, EventArgs e)
        {
            try
            {
                OpenConsole();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
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
            tinc.StartInfo.Arguments = "--batch --force --config=\"" + Environment.CurrentDirectory + "\\contravpn\" join " + invkeytextBox.Text;
            if (invkeytextBox.Text.StartsWith("contra.nsupdate.info"))
            {
                tinc.StartInfo.FileName = Environment.CurrentDirectory + @"\contravpn\tinc.exe";
                tinc.StartInfo.UseShellExecute = false;
                tinc.StartInfo.RedirectStandardOutput = true;
                tinc.StartInfo.RedirectStandardError = true;
                tinc.StartInfo.CreateNoWindow = true;
//                "tinc".Replace("\"", "");
                tinc.StartInfo.WorkingDirectory = Path.GetDirectoryName(@"contravpn\");

                if (File.Exists(@"contravpn\tinc.exe"))
                {
                    tinc.Start();
                    string s = tinc.StandardError.ReadToEnd();
                    string s2 = tinc.StandardOutput.ReadToEnd();
                    if (s.Contains("accepted") || s2.Contains("accepted") == true)
                    {
                        if (Globals.GB_Checked == true)
                        {
                            MessageBox.Show("Invitation successfully accepted!");
                        }
                        else if (Globals.RU_Checked == true)
                        {
                            MessageBox.Show("Приглашение успешно принято!");
                        }
                        else if (Globals.UA_Checked == true)
                        {
                            MessageBox.Show("Запрошення успішно прийнято!");
                        }
                        else if (Globals.BG_Checked == true)
                        {
                            MessageBox.Show("Поканата е приета успешно!");
                        }
                    }
                    else
                    {
                        if (Globals.GB_Checked == true)
                        {
                            MessageBox.Show("Invitation cancelled.\nMake sure this invite key is valid, not already used, or has not expired.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (Globals.RU_Checked == true)
                        {
                            MessageBox.Show("Приглашение отменено.\nУбедитесь, что ключ приглашения действителен, не используется или его срок действия не истек.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (Globals.UA_Checked == true)
                        {
                            MessageBox.Show("Запрошення скасовано.\nПереконайтеся, що цей ключ запрошення дійсний, чи ще не використовується або його термін дії не минув.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (Globals.BG_Checked == true)
                        {
                            MessageBox.Show("Поканата беше отказана.\nУбедете се, че вашият ключ е валиден, не е вече използван, или не е изтекъл.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        //if (!File.Exists(@"contravpn\tinc.conf"))
                        //{
                        //    try
                        //    {
                        //        Directory.Delete("tinc" + @"\" + "contravpn");
                        //    }
                        //    catch
                        //    {

                        //    }
                        //}
                    }
                    InvitePanel.Visible = false;
                }
                else
                {
                    if (Globals.GB_Checked == true)
                    {
                        MessageBox.Show("\"contravpn\" directory not found.", "Error");
                    }
                    else if (Globals.RU_Checked == true)
                    {
                        MessageBox.Show("Каталог \"contravpn\" не найден.", "Ошибка");
                    }
                    else if (Globals.UA_Checked == true)
                    {
                        MessageBox.Show("Каталог \"contravpn\" не знайдено.", "Помилка");
                    }
                    else if (Globals.BG_Checked == true)
                    {
                        MessageBox.Show("\"contravpn\" директорията не беше намерена.", "Грешка");
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
                    MessageBox.Show("Неправильные данные.", "Ошибка");
                }
                else if (Globals.UA_Checked == true)
                {
                    MessageBox.Show("Неправильні дані.", "Помилка");
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

        private void portOkButton_Click(object sender, EventArgs e)
        {
            int parsedValue;
            if ((!int.TryParse(portTextBox.Text, out parsedValue)) || parsedValue > 65535 || parsedValue < 1)
                //reverse logic (!int.TryParse), so "<" is ">" and vice versa, or in other words - this condition determines when the input is incorrect
            {
                if (Globals.GB_Checked == true)
                {
                    MessageBox.Show("The field takes only number input, between 1 and 65535.", "Error");
                }
                else if (Globals.RU_Checked == true)
                {
                    MessageBox.Show("Порт занимает только количество входов, от 1 до 65535.", "Ошибка");
                }
                else if (Globals.UA_Checked == true)
                {
                    MessageBox.Show("Порт займає лише кількість входів, від 1 до 65535.", "Помилка");
                }
                else if (Globals.BG_Checked == true)
                {
                    MessageBox.Show("Полето приема само цифри, между 1 и 65535.", "Грешка");
                }
                return;
            }

            Process tinc = new Process();
            tinc.StartInfo.Arguments = "--config=\"" + Environment.CurrentDirectory + "\\contravpn\"";
            tinc.StartInfo.FileName = Environment.CurrentDirectory + @"\contravpn\tinc.exe";
            tinc.StartInfo.UseShellExecute = false;
            tinc.StartInfo.RedirectStandardInput = true;
            tinc.StartInfo.RedirectStandardOutput = true;
            tinc.StartInfo.CreateNoWindow = true;
            tinc.Start();
            tinc.StandardInput.WriteLine("set ListenAddress * " + portTextBox.Text);
            tinc.StandardInput.Flush();
            tinc.StandardInput.Close();
            tinc.WaitForExit();
            tinc.Close();

            if (Globals.GB_Checked == true)
            {
                MessageBox.Show("Listening port changed!");
            }
            else if (Globals.RU_Checked == true)
            {
                MessageBox.Show("Порт изменен!");
            }
            else if (Globals.UA_Checked == true)
            {
                MessageBox.Show("Порт змінений!");
            }
            else if (Globals.BG_Checked == true)
            {
                MessageBox.Show("Портът е успешно променен!");
            }
            Properties.Settings.Default.PortNumber = portTextBox.Text;
            Properties.Settings.Default.Save();
        }

        private void VPNForm_Load(object sender, EventArgs e)
        {
            showConsoleCheckBox.Checked = Properties.Settings.Default.ShowConsole;
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

        private void showConsoleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //if (!showConsoleCheckBox.Checked)
            //{
            //    Globals.ShowConsole_Checked = false;
            //}
            //else Globals.ShowConsole_Checked = true;
            if (!showConsoleCheckBox.Checked)
            {
                Properties.Settings.Default.ShowConsole = false;
                Properties.Settings.Default.Save();
            }
            else Properties.Settings.Default.ShowConsole = true;
            Properties.Settings.Default.Save();
        }
    }
}
