﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace Contra
{
    public partial class onlinePlayersForm : Form
    {
        public onlinePlayersForm()
        {
            InitializeComponent();
        }

        //**********DRAG FORM CODE START**********
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
        //**********DRAG FORM CODE END**********

//        public static string playersOnlineLabel_PassFromForm2;

        private void refreshOnlinePlayers()
        { 
            string tincd = "tincd.exe";
            Process[] tincdByName = Process.GetProcessesByName(tincd.Substring(0, tincd.LastIndexOf('.')));
            if (tincdByName.Length > 0) //if tincd is already running
            {
                Process onlinePlayers = new Process();
                onlinePlayers.StartInfo.Arguments = "--config=\"" + Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Contra\\vpnconfig\\contravpn\" --pidfile=\"" + Environment.CurrentDirectory + "\\contra\\vpn\\tinc.pid\"";
                onlinePlayers.StartInfo.FileName = Environment.CurrentDirectory + @"\contra\vpn\" + Globals.userOS + @"\tinc.exe";
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

                string s_concat = string.Empty;
                Regex pattern = new Regex(@"([^\s]+) id");

                bool first = true;
                foreach (var match in pattern.Matches(s))
                {
                    if (first)
                    {
                        s_concat = s_concat + "- ";
                        first = false;
                    }
                    string matchString = match.ToString();
                    if (!matchString.Contains("contravpn") && (!matchString.Contains("ctrvpntest9")))
                    {
                        s_concat += matchString;
                        s_concat = s_concat + "\r- ";
                    }
                }

                s_concat = s_concat.Replace(" id", "\n");
                s_concat = s_concat.Replace("predatorbg", "PredatoR");
                s_concat = s_concat.Replace("ggpersun", "GG`PeRSuN^");
                s_concat = s_concat.Replace("armanis", "Armanis");
                s_concat = s_concat.Replace("maelstrom", "Maelstrom");
                s_concat = s_concat.Replace("wwb2", "WWB2");
                s_concat = s_concat.Replace("kinomoto", "Hyperion Heights");

                s_concat = s_concat.Remove(s_concat.Length - 3);

                if (Globals.GB_Checked == true)
                {
                    onlinePlayersLabel.Text = s_concat;
                }
                else if (Globals.RU_Checked == true)
                {
                    onlinePlayersLabel.Text = s_concat;
                }
                else if (Globals.UA_Checked == true)
                {
                    onlinePlayersLabel.Text = s_concat;
                }
                else if (Globals.BG_Checked == true)
                {
                    onlinePlayersLabel.Text = s_concat;
                }
                else if (Globals.DE_Checked == true)
                {
                    onlinePlayersLabel.Text = s_concat;
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
                    onlinePlayers.WaitForExit();
                    onlinePlayers.Close();
                    if (Globals.GB_Checked == true)
                    {
                        Globals.playersOnlineLabel = "Players online: " + s2.ToString();
                        playersOnlineLabel.Text = Globals.playersOnlineLabel;

                        //playersOnlineLabel.Text = "Players online: " + s2.ToString();
                        //playersOnlineLabel_PassFromForm2 = playersOnlineLabel.Text; // "Players online: " + s2.ToString();
                        //Form1 Form1 = new Form1();
                        //playersOnlineLabel.Text = Form1.playersOnlineLabel_PassFromForm1; // "Players online: " + s2.ToString();
                    }
                    else if (Globals.RU_Checked == true)
                    {
                        Globals.playersOnlineLabel = "Игроки онлайн: " + s2.ToString();
                        playersOnlineLabel.Text = Globals.playersOnlineLabel;
                    }
                    else if (Globals.UA_Checked == true)
                    {
                        Globals.playersOnlineLabel = "Гравці в мережі: " + s2.ToString();
                        playersOnlineLabel.Text = Globals.playersOnlineLabel;
                    }
                    else if (Globals.BG_Checked == true)
                    {
                        Globals.playersOnlineLabel = "Играчи на линия: " + s2.ToString();
                        playersOnlineLabel.Text = Globals.playersOnlineLabel;
                    }
                    else if (Globals.DE_Checked == true)
                    {
                        Globals.playersOnlineLabel = "Spieler online: " + s2.ToString();
                        playersOnlineLabel.Text = Globals.playersOnlineLabel;
                    }
                }
            }
        }

        private void onlinePlayersForm_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.playersOnlineWindowLocation != null)
            {
                this.Location = Properties.Settings.Default.playersOnlineWindowLocation;
            }
            refreshOnlinePlayers();
        }

        private void OnApplicationExit(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                Properties.Settings.Default.playersOnlineWindowLocation = this.Location;
            }
            else
            {
                Properties.Settings.Default.playersOnlineWindowLocation = this.RestoreBounds.Location;
            }
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

        private void refreshOnlinePlayersBtn_Click(object sender, EventArgs e)
        {
            string tincd = "tincd.exe";
            Process[] tincdByName = Process.GetProcessesByName(tincd.Substring(0, tincd.LastIndexOf('.')));
            if (tincdByName.Length > 0) //if tincd is already running
            {
                refreshOnlinePlayers();
            }
            else
            {
                if (Globals.GB_Checked == true)
                {
                    playersOnlineLabel.Text = "ContraVPN is disabled";
                }
                else if (Globals.RU_Checked == true)
                {
                    playersOnlineLabel.Text = "ContraVPN выключено";
                }
                else if (Globals.UA_Checked == true)
                {
                    playersOnlineLabel.Text = "ContraVPN вимкнено";
                }
                else if (Globals.BG_Checked == true)
                {
                    playersOnlineLabel.Text = "ContraVPN е изключен";
                }
                else if (Globals.DE_Checked == true)
                {
                    playersOnlineLabel.Text = "ContraVPN deaktiviert";
                }
                onlinePlayersLabel.Text = "";
            }
        }

        private void onlinePlayersBtn_MouseDown(object sender, MouseEventArgs e)
        {
            refreshOnlinePlayersBtn.BackgroundImage = (System.Drawing.Image)(Properties.Resources.refresh);
            refreshOnlinePlayersBtn.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }

        private void onlinePlayersBtn_MouseEnter(object sender, EventArgs e)
        {
            refreshOnlinePlayersBtn.BackgroundImage = (System.Drawing.Image)(Properties.Resources.refresh_tr);
            refreshOnlinePlayersBtn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            refreshOnlinePlayersBtn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            refreshOnlinePlayersBtn.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }

        private void onlinePlayersBtn_MouseLeave(object sender, EventArgs e)
        {
            refreshOnlinePlayersBtn.BackgroundImage = (System.Drawing.Image)(Properties.Resources.refresh);
            refreshOnlinePlayersBtn.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }

        private void button17_MouseEnter(object sender, EventArgs e)
        {
            button17.BackgroundImage = (System.Drawing.Image)(Properties.Resources.min11);
        }

        private void button17_MouseLeave(object sender, EventArgs e)
        {
            button17.BackgroundImage = (System.Drawing.Image)(Properties.Resources.min);
        }

        private void button18_MouseEnter(object sender, EventArgs e)
        {
            button18.BackgroundImage = (System.Drawing.Image)(Properties.Resources.exit11);
        }

        private void button18_MouseLeave(object sender, EventArgs e)
        {
            button18.BackgroundImage = (System.Drawing.Image)(Properties.Resources.exit1);
        }
    }
}
