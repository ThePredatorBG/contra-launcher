using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace Contra
{
    public partial class moreOptionsForm : Form
    {
        public moreOptionsForm()
        {
            InitializeComponent();
            FogCheckBox.TabStop = false;
            LangFilterCheckBox.TabStop = false;
            button17.TabStop = false;
            button18.TabStop = false;
            comboBox1.TabStop = false;
            resOkButton.TabStop = false;

            if (!FogCheckBox.Checked)
            {
                Globals.FogFX_Checked = false;
            }
            if (!LangFilterCheckBox.Checked)
            {
                Globals.LangF_Checked = false;
            }

            if (Globals.GB_Checked == true)
            {
                toolTip3.SetToolTip(FogCheckBox, "Toggle fog (depth of field) effects on/off.\nThis effect adds a color layer at the top of the screen, depending on the map.");
                toolTip3.SetToolTip(LangFilterCheckBox, "Disabling the language filter will show bad words written by players in chat.");
            }
            else if (Globals.RU_Checked == true)
            {
                toolTip3.SetToolTip(FogCheckBox, "Эффекты переключения тумана (глубина поля) вкл\\выкл.");
                toolTip3.SetToolTip(LangFilterCheckBox, "Отключение языкового фильтра покажет плохие слова, написанные игроками в чате.");
            }
            else if (Globals.UA_Checked == true)
            {
                toolTip3.SetToolTip(FogCheckBox, "Ефекти перемикання туману (глибина поля) вкл\\викл.");
                toolTip3.SetToolTip(LangFilterCheckBox, "Вимкнення мовного фільтра покаже погані слова, написані гравцями в чаті.");
            }
            else if (Globals.BG_Checked == true)
            {
                toolTip3.SetToolTip(FogCheckBox, "Превключете ефекта \"дълбочина на рязкост\".\nТози ефект добавя цветен слой на върха на екрана, зависещ от атмосферата на картата. Например, мъгла.");
                toolTip3.SetToolTip(LangFilterCheckBox, "Изключването на езиковия филтър ще спре да скрива лошите думи, написани от играчите.");
            }

            //Get current resolution
            if (Directory.Exists(path))
            {
                string s = File.ReadAllText(path + "Options.ini");
                List<string> found = new List<string>();
                string line;
                using (StringReader file = new StringReader(s))
                {
                    while ((line = file.ReadLine()) != null)
                    {
                        if (line.Contains("Resolution ="))
                        {
                            found.Add(line);
                            s = line;
                            s = s.Substring(s.IndexOf('=') + 2);
                            s = s.TrimEnd();
                            string s2 = s.Replace(" ", "x");
                            //                        MessageBox.Show(s2); //shows current res
                            Properties.Settings.Default.Res = s2;
                            Properties.Settings.Default.Save();
                        }
                    }
                }
            }
            comboBox1.Text = Properties.Settings.Default.Res;

            FogCheckBox.Checked = Properties.Settings.Default.Fog;
            LangFilterCheckBox.Checked = Properties.Settings.Default.LangF;
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

        private void OnApplicationExit(object sender, EventArgs e) //MoreOptionsWindowExit
        {
            Properties.Settings.Default.Fog = FogCheckBox.Checked;
            Properties.Settings.Default.LangF = LangFilterCheckBox.Checked;
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

        private void resOkButton_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(path))
            {
                string text = File.ReadAllText(path + "Options.ini");
                {
                    if (!Regex.IsMatch(comboBox1.Text, @"^[0-9]{3,4}x[0-9]{3,4}$")) //if selected res doesn't match valid input (input must match the regex)
                    {
                        if (Globals.GB_Checked == true)
                        {
                            MessageBox.Show("This resolution is not valid.", "Error");
                        }
                        else if (Globals.RU_Checked == true)
                        {
                            MessageBox.Show("Это разрешение экрана не является действительным.", "Ошибка");
                        }
                        else if (Globals.UA_Checked == true)
                        {
                            MessageBox.Show("Це розширення не є дійсним.", "Помилка");
                        }
                        else if (Globals.BG_Checked == true)
                        {
                            MessageBox.Show("Тази резолюция не е валидна.", "Грешка");
                        }
                        //return;
                    }
                    else
                    {
                        string fixedText = comboBox1.Text.Replace("x", " ");
                        File.WriteAllText(path + "Options.ini", Regex.Replace(File.ReadAllText(path + "Options.ini"), "\r?\nResolution =.*", "\r\nResolution = " + fixedText + "\r\n"));
                        if (Globals.GB_Checked == true)
                        {
                            MessageBox.Show("Resolution changed successfully!");
                        }
                        else if (Globals.RU_Checked == true)
                        {
                            MessageBox.Show("Разрешение экрана успешно изменено!");
                        }
                        else if (Globals.UA_Checked == true)
                        {
                            MessageBox.Show("Розширення успішно змінено!");
                        }
                        else if (Globals.BG_Checked == true)
                        {
                            MessageBox.Show("Резолюцията беше променена успешно!");
                        }
                    }
                }
            }
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

        private void FogCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!FogCheckBox.Checked)
            {
                Globals.FogFX_Checked = false;
            }
            else Globals.FogFX_Checked = true;
        }

        private void LangFilterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!LangFilterCheckBox.Checked)
            {
                Globals.LangF_Checked = false;
            }
            else Globals.LangF_Checked = true;
        }
    }
}
