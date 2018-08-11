namespace Contra
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.RadioEN = new System.Windows.Forms.RadioButton();
            this.RadioRU = new System.Windows.Forms.RadioButton();
            this.RadioOrigQuotes = new System.Windows.Forms.RadioButton();
            this.RadioLocQuotes = new System.Windows.Forms.RadioButton();
            this.MNew = new System.Windows.Forms.RadioButton();
            this.QSCheckBox = new System.Windows.Forms.CheckBox();
            this.MStandard = new System.Windows.Forms.RadioButton();
            this.WinCheckBox = new System.Windows.Forms.CheckBox();
            this.DefaultPics = new System.Windows.Forms.RadioButton();
            this.GoofyPics = new System.Windows.Forms.RadioButton();
            this.voicespanel = new System.Windows.Forms.Panel();
            this.languagepanel = new System.Windows.Forms.Panel();
            this.musicpanel = new System.Windows.Forms.Panel();
            this.portraitspanel = new System.Windows.Forms.Panel();
            this.versionLabel = new System.Windows.Forms.Label();
            this.VPNMoreButton = new System.Windows.Forms.Button();
            this.buttonVPNstart = new System.Windows.Forms.Button();
            this.helpbutton = new System.Windows.Forms.Button();
            this.buttonChat = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.websitebutton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.radioFlag_GB = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioFlag_BG = new System.Windows.Forms.RadioButton();
            this.radioFlag_UA = new System.Windows.Forms.RadioButton();
            this.radioFlag_RU = new System.Windows.Forms.RadioButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Resolution = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.onlinePlayersBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.playersOnlineLabel = new System.Windows.Forms.Label();
            this.voicespanel.SuspendLayout();
            this.languagepanel.SuspendLayout();
            this.musicpanel.SuspendLayout();
            this.portraitspanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RadioEN
            // 
            resources.ApplyResources(this.RadioEN, "RadioEN");
            this.RadioEN.Checked = true;
            this.RadioEN.ForeColor = System.Drawing.Color.White;
            this.RadioEN.Name = "RadioEN";
            this.RadioEN.TabStop = true;
            this.toolTip1.SetToolTip(this.RadioEN, resources.GetString("RadioEN.ToolTip"));
            this.RadioEN.UseVisualStyleBackColor = true;
            this.RadioEN.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // RadioRU
            // 
            resources.ApplyResources(this.RadioRU, "RadioRU");
            this.RadioRU.Name = "RadioRU";
            this.toolTip1.SetToolTip(this.RadioRU, resources.GetString("RadioRU.ToolTip"));
            this.RadioRU.UseVisualStyleBackColor = true;
            this.RadioRU.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // RadioOrigQuotes
            // 
            resources.ApplyResources(this.RadioOrigQuotes, "RadioOrigQuotes");
            this.RadioOrigQuotes.Cursor = System.Windows.Forms.Cursors.Default;
            this.RadioOrigQuotes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RadioOrigQuotes.Name = "RadioOrigQuotes";
            this.toolTip1.SetToolTip(this.RadioOrigQuotes, resources.GetString("RadioOrigQuotes.ToolTip"));
            this.RadioOrigQuotes.UseVisualStyleBackColor = true;
            this.RadioOrigQuotes.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // RadioLocQuotes
            // 
            resources.ApplyResources(this.RadioLocQuotes, "RadioLocQuotes");
            this.RadioLocQuotes.Checked = true;
            this.RadioLocQuotes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RadioLocQuotes.Name = "RadioLocQuotes";
            this.RadioLocQuotes.TabStop = true;
            this.toolTip1.SetToolTip(this.RadioLocQuotes, resources.GetString("RadioLocQuotes.ToolTip"));
            this.RadioLocQuotes.UseVisualStyleBackColor = true;
            this.RadioLocQuotes.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // MNew
            // 
            resources.ApplyResources(this.MNew, "MNew");
            this.MNew.Checked = true;
            this.MNew.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MNew.Name = "MNew";
            this.MNew.TabStop = true;
            this.toolTip1.SetToolTip(this.MNew, resources.GetString("MNew.ToolTip"));
            this.MNew.UseVisualStyleBackColor = true;
            this.MNew.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // QSCheckBox
            // 
            resources.ApplyResources(this.QSCheckBox, "QSCheckBox");
            this.QSCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.QSCheckBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.QSCheckBox.Name = "QSCheckBox";
            this.QSCheckBox.UseVisualStyleBackColor = false;
            // 
            // MStandard
            // 
            resources.ApplyResources(this.MStandard, "MStandard");
            this.MStandard.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MStandard.Name = "MStandard";
            this.toolTip1.SetToolTip(this.MStandard, resources.GetString("MStandard.ToolTip"));
            this.MStandard.UseVisualStyleBackColor = true;
            this.MStandard.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged_1);
            // 
            // WinCheckBox
            // 
            resources.ApplyResources(this.WinCheckBox, "WinCheckBox");
            this.WinCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.WinCheckBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.WinCheckBox.Name = "WinCheckBox";
            this.WinCheckBox.UseVisualStyleBackColor = false;
            this.WinCheckBox.CheckedChanged += new System.EventHandler(this.WinCheckBox_CheckedChanged);
            // 
            // DefaultPics
            // 
            resources.ApplyResources(this.DefaultPics, "DefaultPics");
            this.DefaultPics.Checked = true;
            this.DefaultPics.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DefaultPics.Name = "DefaultPics";
            this.DefaultPics.TabStop = true;
            this.toolTip1.SetToolTip(this.DefaultPics, resources.GetString("DefaultPics.ToolTip"));
            this.DefaultPics.UseVisualStyleBackColor = true;
            // 
            // GoofyPics
            // 
            resources.ApplyResources(this.GoofyPics, "GoofyPics");
            this.GoofyPics.Name = "GoofyPics";
            this.toolTip1.SetToolTip(this.GoofyPics, resources.GetString("GoofyPics.ToolTip"));
            this.GoofyPics.UseVisualStyleBackColor = true;
            this.GoofyPics.CheckedChanged += new System.EventHandler(this.GoofyPics_CheckedChanged);
            // 
            // voicespanel
            // 
            this.voicespanel.BackColor = System.Drawing.Color.Transparent;
            this.voicespanel.Controls.Add(this.RadioOrigQuotes);
            this.voicespanel.Controls.Add(this.RadioLocQuotes);
            resources.ApplyResources(this.voicespanel, "voicespanel");
            this.voicespanel.Name = "voicespanel";
            this.voicespanel.Paint += new System.Windows.Forms.PaintEventHandler(this.voicespanel_Paint);
            // 
            // languagepanel
            // 
            this.languagepanel.BackColor = System.Drawing.Color.Transparent;
            this.languagepanel.Controls.Add(this.RadioRU);
            this.languagepanel.Controls.Add(this.RadioEN);
            this.languagepanel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            resources.ApplyResources(this.languagepanel, "languagepanel");
            this.languagepanel.Name = "languagepanel";
            // 
            // musicpanel
            // 
            this.musicpanel.BackColor = System.Drawing.Color.Transparent;
            this.musicpanel.Controls.Add(this.MStandard);
            this.musicpanel.Controls.Add(this.MNew);
            this.musicpanel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            resources.ApplyResources(this.musicpanel, "musicpanel");
            this.musicpanel.Name = "musicpanel";
            // 
            // portraitspanel
            // 
            this.portraitspanel.BackColor = System.Drawing.Color.Transparent;
            this.portraitspanel.Controls.Add(this.GoofyPics);
            this.portraitspanel.Controls.Add(this.DefaultPics);
            this.portraitspanel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            resources.ApplyResources(this.portraitspanel, "portraitspanel");
            this.portraitspanel.Name = "portraitspanel";
            // 
            // versionLabel
            // 
            resources.ApplyResources(this.versionLabel, "versionLabel");
            this.versionLabel.BackColor = System.Drawing.Color.Transparent;
            this.versionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(100)))));
            this.versionLabel.Name = "versionLabel";
            // 
            // VPNMoreButton
            // 
            this.VPNMoreButton.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.VPNMoreButton, "VPNMoreButton");
            this.VPNMoreButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VPNMoreButton.FlatAppearance.BorderSize = 0;
            this.VPNMoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.VPNMoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.VPNMoreButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.VPNMoreButton.Name = "VPNMoreButton";
            this.VPNMoreButton.UseVisualStyleBackColor = false;
            this.VPNMoreButton.Click += new System.EventHandler(this.VPNMoreButton_Click);
            this.VPNMoreButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.VPNMoreButton_MouseDown);
            this.VPNMoreButton.MouseEnter += new System.EventHandler(this.VPNMoreButton_MouseEnter);
            this.VPNMoreButton.MouseLeave += new System.EventHandler(this.VPNMoreButton_MouseLeave);
            // 
            // buttonVPNstart
            // 
            this.buttonVPNstart.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.buttonVPNstart, "buttonVPNstart");
            this.buttonVPNstart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonVPNstart.FlatAppearance.BorderSize = 0;
            this.buttonVPNstart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonVPNstart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonVPNstart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonVPNstart.Name = "buttonVPNstart";
            this.buttonVPNstart.UseVisualStyleBackColor = false;
            this.buttonVPNstart.Click += new System.EventHandler(this.buttonVPNstart_Click);
            this.buttonVPNstart.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonVPNstart_MouseDown);
            this.buttonVPNstart.MouseEnter += new System.EventHandler(this.buttonVPNstart_MouseEnter);
            this.buttonVPNstart.MouseLeave += new System.EventHandler(this.buttonVPNstart_MouseLeave);
            // 
            // helpbutton
            // 
            this.helpbutton.BackColor = System.Drawing.Color.Transparent;
            this.helpbutton.BackgroundImage = global::Contra.Properties.Resources._button_help;
            this.helpbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.helpbutton.FlatAppearance.BorderSize = 0;
            this.helpbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.helpbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.helpbutton, "helpbutton");
            this.helpbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.helpbutton.Name = "helpbutton";
            this.helpbutton.UseVisualStyleBackColor = false;
            this.helpbutton.Click += new System.EventHandler(this.helpbutton_Click);
            this.helpbutton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.helpbutton_MouseDown_1);
            this.helpbutton.MouseEnter += new System.EventHandler(this.helpbutton_MouseEnter_1);
            this.helpbutton.MouseLeave += new System.EventHandler(this.helpbutton_MouseLeave_1);
            // 
            // buttonChat
            // 
            this.buttonChat.BackColor = System.Drawing.Color.Transparent;
            this.buttonChat.BackgroundImage = global::Contra.Properties.Resources._button_discord;
            this.buttonChat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChat.FlatAppearance.BorderSize = 0;
            this.buttonChat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonChat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.buttonChat, "buttonChat");
            this.buttonChat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonChat.Name = "buttonChat";
            this.buttonChat.UseVisualStyleBackColor = false;
            this.buttonChat.Click += new System.EventHandler(this.buttonChat_Click);
            this.buttonChat.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonChat_MouseDown);
            this.buttonChat.MouseEnter += new System.EventHandler(this.buttonChat_MouseEnter);
            this.buttonChat.MouseLeave += new System.EventHandler(this.buttonChat_MouseLeave);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button18.BackgroundImage = global::Contra.Properties.Resources.exit1;
            resources.ApplyResources(this.button18, "button18");
            this.button18.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button18.FlatAppearance.BorderSize = 0;
            this.button18.Name = "button18";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            this.button18.MouseEnter += new System.EventHandler(this.button18_MouseEnter);
            this.button18.MouseLeave += new System.EventHandler(this.button18_MouseLeave);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button17.BackgroundImage = global::Contra.Properties.Resources.min;
            resources.ApplyResources(this.button17, "button17");
            this.button17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button17.FlatAppearance.BorderSize = 0;
            this.button17.Name = "button17";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            this.button17.MouseEnter += new System.EventHandler(this.button17_MouseEnter);
            this.button17.MouseLeave += new System.EventHandler(this.button17_MouseLeave);
            // 
            // websitebutton
            // 
            this.websitebutton.BackColor = System.Drawing.Color.Transparent;
            this.websitebutton.BackgroundImage = global::Contra.Properties.Resources._button_website;
            this.websitebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.websitebutton.FlatAppearance.BorderSize = 0;
            this.websitebutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.websitebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.websitebutton, "websitebutton");
            this.websitebutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.websitebutton.Name = "websitebutton";
            this.websitebutton.UseVisualStyleBackColor = false;
            this.websitebutton.Click += new System.EventHandler(this.websitebutton_Click);
            this.websitebutton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.websitebutton_MouseDown);
            this.websitebutton.MouseEnter += new System.EventHandler(this.websitebutton_MouseEnter);
            this.websitebutton.MouseLeave += new System.EventHandler(this.websitebutton_MouseLeave);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::Contra.Properties.Resources._button_exit;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.button2, "button2");
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button2_MouseDown);
            this.button2.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::Contra.Properties.Resources._button_readme;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.button3, "button3");
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button3_MouseDown);
            this.button3.MouseEnter += new System.EventHandler(this.button3_MouseEnter);
            this.button3.MouseLeave += new System.EventHandler(this.button3_MouseLeave);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.BackgroundImage = global::Contra.Properties.Resources._button_wb;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.button6, "button6");
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Name = "button6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            this.button6.Enter += new System.EventHandler(this.button6_Enter);
            this.button6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button6_MouseDown);
            this.button6.MouseEnter += new System.EventHandler(this.button6_MouseEnter);
            this.button6.MouseLeave += new System.EventHandler(this.button6_MouseLeave);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImage = global::Contra.Properties.Resources._button_moddb;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.button5, "button5");
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Name = "button5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            this.button5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button5_MouseDown);
            this.button5.MouseEnter += new System.EventHandler(this.button5_MouseEnter);
            this.button5.MouseLeave += new System.EventHandler(this.button5_MouseLeave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Contra.Properties.Resources._button_launch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // radioFlag_GB
            // 
            resources.ApplyResources(this.radioFlag_GB, "radioFlag_GB");
            this.radioFlag_GB.BackColor = System.Drawing.Color.Transparent;
            this.radioFlag_GB.BackgroundImage = global::Contra.Properties.Resources.flag_gb;
            this.radioFlag_GB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioFlag_GB.FlatAppearance.BorderSize = 0;
            this.radioFlag_GB.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.radioFlag_GB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.radioFlag_GB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.radioFlag_GB.Name = "radioFlag_GB";
            this.radioFlag_GB.TabStop = true;
            this.radioFlag_GB.UseVisualStyleBackColor = false;
            this.radioFlag_GB.CheckedChanged += new System.EventHandler(this.radioFlag_GB_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.radioFlag_BG);
            this.panel1.Controls.Add(this.radioFlag_UA);
            this.panel1.Controls.Add(this.radioFlag_RU);
            this.panel1.Controls.Add(this.radioFlag_GB);
            this.panel1.Name = "panel1";
            // 
            // radioFlag_BG
            // 
            resources.ApplyResources(this.radioFlag_BG, "radioFlag_BG");
            this.radioFlag_BG.BackColor = System.Drawing.Color.Transparent;
            this.radioFlag_BG.BackgroundImage = global::Contra.Properties.Resources.flag_bg;
            this.radioFlag_BG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioFlag_BG.FlatAppearance.BorderSize = 0;
            this.radioFlag_BG.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.radioFlag_BG.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.radioFlag_BG.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.radioFlag_BG.Name = "radioFlag_BG";
            this.radioFlag_BG.TabStop = true;
            this.radioFlag_BG.UseVisualStyleBackColor = false;
            this.radioFlag_BG.CheckedChanged += new System.EventHandler(this.radioFlag_BG_CheckedChanged);
            // 
            // radioFlag_UA
            // 
            resources.ApplyResources(this.radioFlag_UA, "radioFlag_UA");
            this.radioFlag_UA.BackColor = System.Drawing.Color.Transparent;
            this.radioFlag_UA.BackgroundImage = global::Contra.Properties.Resources.flag_ua;
            this.radioFlag_UA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioFlag_UA.FlatAppearance.BorderSize = 0;
            this.radioFlag_UA.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.radioFlag_UA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.radioFlag_UA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.radioFlag_UA.Name = "radioFlag_UA";
            this.radioFlag_UA.TabStop = true;
            this.radioFlag_UA.UseVisualStyleBackColor = false;
            this.radioFlag_UA.CheckedChanged += new System.EventHandler(this.radioFlag_UA_CheckedChanged);
            // 
            // radioFlag_RU
            // 
            resources.ApplyResources(this.radioFlag_RU, "radioFlag_RU");
            this.radioFlag_RU.BackColor = System.Drawing.Color.Transparent;
            this.radioFlag_RU.BackgroundImage = global::Contra.Properties.Resources.flag_ru;
            this.radioFlag_RU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioFlag_RU.FlatAppearance.BorderSize = 0;
            this.radioFlag_RU.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.radioFlag_RU.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.radioFlag_RU.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.radioFlag_RU.Name = "radioFlag_RU";
            this.radioFlag_RU.TabStop = true;
            this.radioFlag_RU.UseVisualStyleBackColor = false;
            this.radioFlag_RU.CheckedChanged += new System.EventHandler(this.radioFlag_RU_CheckedChanged);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 50;
            this.toolTip1.ReshowDelay = 100;
            // 
            // Resolution
            // 
            resources.ApplyResources(this.Resolution, "Resolution");
            this.Resolution.BackColor = System.Drawing.Color.Transparent;
            this.Resolution.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Resolution.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Resolution.Name = "Resolution";
            this.Resolution.Click += new System.EventHandler(this.Resolution_Click);
            this.Resolution.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Resolution_MouseDown);
            this.Resolution.MouseEnter += new System.EventHandler(this.Resolution_MouseEnter);
            this.Resolution.MouseLeave += new System.EventHandler(this.Resolution_MouseLeave);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Name = "label1";
            // 
            // onlinePlayersBtn
            // 
            this.onlinePlayersBtn.BackColor = System.Drawing.Color.Transparent;
            this.onlinePlayersBtn.BackgroundImage = global::Contra.Properties.Resources.refresh;
            resources.ApplyResources(this.onlinePlayersBtn, "onlinePlayersBtn");
            this.onlinePlayersBtn.FlatAppearance.BorderSize = 0;
            this.onlinePlayersBtn.Name = "onlinePlayersBtn";
            this.onlinePlayersBtn.UseVisualStyleBackColor = false;
            this.onlinePlayersBtn.Click += new System.EventHandler(this.onlinePlayersBtn_Click);
            this.onlinePlayersBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.onlinePlayersBtn_MouseDown);
            this.onlinePlayersBtn.MouseEnter += new System.EventHandler(this.onlinePlayersBtn_MouseEnter);
            this.onlinePlayersBtn.MouseLeave += new System.EventHandler(this.onlinePlayersBtn_MouseLeave);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // playersOnlineLabel
            // 
            resources.ApplyResources(this.playersOnlineLabel, "playersOnlineLabel");
            this.playersOnlineLabel.BackColor = System.Drawing.Color.Transparent;
            this.playersOnlineLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.playersOnlineLabel.Name = "playersOnlineLabel";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::Contra.Properties.Resources.background;
            resources.ApplyResources(this, "$this");
            this.ControlBox = false;
            this.Controls.Add(this.playersOnlineLabel);
            this.Controls.Add(this.onlinePlayersBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Resolution);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.VPNMoreButton);
            this.Controls.Add(this.buttonVPNstart);
            this.Controls.Add(this.QSCheckBox);
            this.Controls.Add(this.WinCheckBox);
            this.Controls.Add(this.voicespanel);
            this.Controls.Add(this.languagepanel);
            this.Controls.Add(this.portraitspanel);
            this.Controls.Add(this.musicpanel);
            this.Controls.Add(this.helpbutton);
            this.Controls.Add(this.buttonChat);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.websitebutton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.voicespanel.ResumeLayout(false);
            this.voicespanel.PerformLayout();
            this.languagepanel.ResumeLayout(false);
            this.languagepanel.PerformLayout();
            this.musicpanel.ResumeLayout(false);
            this.musicpanel.PerformLayout();
            this.portraitspanel.ResumeLayout(false);
            this.portraitspanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton RadioEN;
        private System.Windows.Forms.RadioButton RadioRU;
        private System.Windows.Forms.RadioButton RadioOrigQuotes;
        private System.Windows.Forms.RadioButton RadioLocQuotes;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.CheckBox QSCheckBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton MStandard;
        private System.Windows.Forms.RadioButton MNew;
        private System.Windows.Forms.CheckBox WinCheckBox;
        private System.Windows.Forms.Button websitebutton;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button buttonChat;
        private System.Windows.Forms.Button helpbutton;
        private System.Windows.Forms.RadioButton DefaultPics;
        private System.Windows.Forms.RadioButton GoofyPics;
        private System.Windows.Forms.Panel voicespanel;
        private System.Windows.Forms.Panel languagepanel;
        private System.Windows.Forms.Panel musicpanel;
        private System.Windows.Forms.Panel portraitspanel;
        private System.Windows.Forms.Button buttonVPNstart;
        private System.Windows.Forms.Button VPNMoreButton;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.RadioButton radioFlag_GB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioFlag_BG;
        private System.Windows.Forms.RadioButton radioFlag_UA;
        private System.Windows.Forms.RadioButton radioFlag_RU;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label Resolution;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button onlinePlayersBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label playersOnlineLabel;
    }
}

