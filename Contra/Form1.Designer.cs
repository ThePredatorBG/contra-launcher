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
            this.VoicesOriginalToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.QSCheckBox = new System.Windows.Forms.CheckBox();
            this.MNew = new System.Windows.Forms.RadioButton();
            this.MStandard = new System.Windows.Forms.RadioButton();
            this.WinCheckBox = new System.Windows.Forms.CheckBox();
            this.FogCheckBox = new System.Windows.Forms.CheckBox();
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
            this.VoicesLocalizedToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.QSToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.WindowedToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.NewMusicToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.StandardMusicToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.Русский = new System.Windows.Forms.ToolTip(this.components);
            this.PortraitsDefault = new System.Windows.Forms.ToolTip(this.components);
            this.PortraitsGoofy = new System.Windows.Forms.ToolTip(this.components);
            this.FogEffects = new System.Windows.Forms.ToolTip(this.components);
            this.EnglishLanguage = new System.Windows.Forms.ToolTip(this.components);
            this.voicespanel.SuspendLayout();
            this.languagepanel.SuspendLayout();
            this.musicpanel.SuspendLayout();
            this.portraitspanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // RadioEN
            // 
            resources.ApplyResources(this.RadioEN, "RadioEN");
            this.RadioEN.Checked = true;
            this.RadioEN.ForeColor = System.Drawing.Color.White;
            this.RadioEN.Name = "RadioEN";
            this.RadioEN.TabStop = true;
            this.EnglishLanguage.SetToolTip(this.RadioEN, resources.GetString("RadioEN.ToolTip"));
            this.RadioEN.UseVisualStyleBackColor = true;
            this.RadioEN.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // RadioRU
            // 
            resources.ApplyResources(this.RadioRU, "RadioRU");
            this.RadioRU.Name = "RadioRU";
            this.Русский.SetToolTip(this.RadioRU, resources.GetString("RadioRU.ToolTip"));
            this.RadioRU.UseVisualStyleBackColor = true;
            this.RadioRU.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // RadioOrigQuotes
            // 
            resources.ApplyResources(this.RadioOrigQuotes, "RadioOrigQuotes");
            this.RadioOrigQuotes.Cursor = System.Windows.Forms.Cursors.Default;
            this.RadioOrigQuotes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RadioOrigQuotes.Name = "RadioOrigQuotes";
            this.VoicesOriginalToolTip.SetToolTip(this.RadioOrigQuotes, resources.GetString("RadioOrigQuotes.ToolTip"));
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
            this.VoicesLocalizedToolTip.SetToolTip(this.RadioLocQuotes, resources.GetString("RadioLocQuotes.ToolTip"));
            this.RadioLocQuotes.UseVisualStyleBackColor = true;
            this.RadioLocQuotes.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // VoicesOriginalToolTip
            // 
            this.VoicesOriginalToolTip.AutoPopDelay = 5000;
            this.VoicesOriginalToolTip.InitialDelay = 50;
            this.VoicesOriginalToolTip.ReshowDelay = 100;
            // 
            // QSCheckBox
            // 
            resources.ApplyResources(this.QSCheckBox, "QSCheckBox");
            this.QSCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.QSCheckBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.QSCheckBox.Name = "QSCheckBox";
            this.QSToolTip.SetToolTip(this.QSCheckBox, resources.GetString("QSCheckBox.ToolTip"));
            this.VoicesOriginalToolTip.SetToolTip(this.QSCheckBox, resources.GetString("QSCheckBox.ToolTip1"));
            this.QSCheckBox.UseVisualStyleBackColor = false;
            // 
            // MNew
            // 
            resources.ApplyResources(this.MNew, "MNew");
            this.MNew.Checked = true;
            this.MNew.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MNew.Name = "MNew";
            this.MNew.TabStop = true;
            this.NewMusicToolTip.SetToolTip(this.MNew, resources.GetString("MNew.ToolTip"));
            this.VoicesOriginalToolTip.SetToolTip(this.MNew, resources.GetString("MNew.ToolTip1"));
            this.MNew.UseVisualStyleBackColor = true;
            this.MNew.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // MStandard
            // 
            resources.ApplyResources(this.MStandard, "MStandard");
            this.MStandard.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MStandard.Name = "MStandard";
            this.StandardMusicToolTip.SetToolTip(this.MStandard, resources.GetString("MStandard.ToolTip"));
            this.VoicesOriginalToolTip.SetToolTip(this.MStandard, resources.GetString("MStandard.ToolTip1"));
            this.MStandard.UseVisualStyleBackColor = true;
            this.MStandard.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged_1);
            // 
            // WinCheckBox
            // 
            resources.ApplyResources(this.WinCheckBox, "WinCheckBox");
            this.WinCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.WinCheckBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.WinCheckBox.Name = "WinCheckBox";
            this.WindowedToolTip.SetToolTip(this.WinCheckBox, resources.GetString("WinCheckBox.ToolTip"));
            this.VoicesOriginalToolTip.SetToolTip(this.WinCheckBox, resources.GetString("WinCheckBox.ToolTip1"));
            this.WinCheckBox.UseVisualStyleBackColor = false;
            this.WinCheckBox.CheckedChanged += new System.EventHandler(this.WinCheckBox_CheckedChanged);
            // 
            // FogCheckBox
            // 
            resources.ApplyResources(this.FogCheckBox, "FogCheckBox");
            this.FogCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.FogCheckBox.Checked = true;
            this.FogCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FogCheckBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FogCheckBox.Name = "FogCheckBox";
            this.VoicesOriginalToolTip.SetToolTip(this.FogCheckBox, resources.GetString("FogCheckBox.ToolTip"));
            this.FogEffects.SetToolTip(this.FogCheckBox, resources.GetString("FogCheckBox.ToolTip1"));
            this.FogCheckBox.UseVisualStyleBackColor = false;
            this.FogCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // DefaultPics
            // 
            resources.ApplyResources(this.DefaultPics, "DefaultPics");
            this.DefaultPics.Checked = true;
            this.DefaultPics.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DefaultPics.Name = "DefaultPics";
            this.DefaultPics.TabStop = true;
            this.VoicesOriginalToolTip.SetToolTip(this.DefaultPics, resources.GetString("DefaultPics.ToolTip"));
            this.PortraitsDefault.SetToolTip(this.DefaultPics, resources.GetString("DefaultPics.ToolTip1"));
            this.DefaultPics.UseVisualStyleBackColor = true;
            // 
            // GoofyPics
            // 
            resources.ApplyResources(this.GoofyPics, "GoofyPics");
            this.GoofyPics.Name = "GoofyPics";
            this.VoicesOriginalToolTip.SetToolTip(this.GoofyPics, resources.GetString("GoofyPics.ToolTip"));
            this.PortraitsGoofy.SetToolTip(this.GoofyPics, resources.GetString("GoofyPics.ToolTip1"));
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
            this.languagepanel.Paint += new System.Windows.Forms.PaintEventHandler(this.languagepanel_Paint);
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
            this.button18.FlatAppearance.BorderSize = 0;
            this.button18.Name = "button18";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button17.BackgroundImage = global::Contra.Properties.Resources.min;
            resources.ApplyResources(this.button17, "button17");
            this.button17.FlatAppearance.BorderSize = 0;
            this.button17.Name = "button17";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.button17_Click);
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
            // VoicesLocalizedToolTip
            // 
            this.VoicesLocalizedToolTip.AutoPopDelay = 5000;
            this.VoicesLocalizedToolTip.InitialDelay = 50;
            this.VoicesLocalizedToolTip.ReshowDelay = 100;
            // 
            // QSToolTip
            // 
            this.QSToolTip.AutoPopDelay = 5000;
            this.QSToolTip.InitialDelay = 50;
            this.QSToolTip.ReshowDelay = 100;
            // 
            // WindowedToolTip
            // 
            this.WindowedToolTip.AutoPopDelay = 5000;
            this.WindowedToolTip.InitialDelay = 50;
            this.WindowedToolTip.ReshowDelay = 100;
            // 
            // NewMusicToolTip
            // 
            this.NewMusicToolTip.AutoPopDelay = 5000;
            this.NewMusicToolTip.InitialDelay = 50;
            this.NewMusicToolTip.ReshowDelay = 100;
            // 
            // StandardMusicToolTip
            // 
            this.StandardMusicToolTip.AutoPopDelay = 5000;
            this.StandardMusicToolTip.InitialDelay = 50;
            this.StandardMusicToolTip.ReshowDelay = 100;
            // 
            // Русский
            // 
            this.Русский.AutoPopDelay = 5000;
            this.Русский.InitialDelay = 50;
            this.Русский.ReshowDelay = 100;
            // 
            // PortraitsDefault
            // 
            this.PortraitsDefault.AutoPopDelay = 5000;
            this.PortraitsDefault.InitialDelay = 50;
            this.PortraitsDefault.ReshowDelay = 100;
            // 
            // PortraitsGoofy
            // 
            this.PortraitsGoofy.AutoPopDelay = 5000;
            this.PortraitsGoofy.InitialDelay = 50;
            this.PortraitsGoofy.ReshowDelay = 100;
            // 
            // FogEffects
            // 
            this.FogEffects.AutoPopDelay = 5000;
            this.FogEffects.InitialDelay = 50;
            this.FogEffects.ReshowDelay = 100;
            // 
            // EnglishLanguage
            // 
            this.EnglishLanguage.AutoPopDelay = 5000;
            this.EnglishLanguage.InitialDelay = 50;
            this.EnglishLanguage.ReshowDelay = 100;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.ControlBox = false;
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.VPNMoreButton);
            this.Controls.Add(this.buttonVPNstart);
            this.Controls.Add(this.QSCheckBox);
            this.Controls.Add(this.WinCheckBox);
            this.Controls.Add(this.FogCheckBox);
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
        private System.Windows.Forms.ToolTip VoicesOriginalToolTip;
        private System.Windows.Forms.ToolTip VoicesLocalizedToolTip;
        private System.Windows.Forms.CheckBox QSCheckBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton MStandard;
        private System.Windows.Forms.RadioButton MNew;
        private System.Windows.Forms.CheckBox WinCheckBox;
        private System.Windows.Forms.ToolTip QSToolTip;
        private System.Windows.Forms.ToolTip StandardMusicToolTip;
        private System.Windows.Forms.ToolTip NewMusicToolTip;
        private System.Windows.Forms.ToolTip WindowedToolTip;
        private System.Windows.Forms.ToolTip Русский;
        private System.Windows.Forms.Button websitebutton;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button buttonChat;
        private System.Windows.Forms.Button helpbutton;
        private System.Windows.Forms.RadioButton DefaultPics;
        private System.Windows.Forms.RadioButton GoofyPics;
        private System.Windows.Forms.CheckBox FogCheckBox;
        private System.Windows.Forms.Panel voicespanel;
        private System.Windows.Forms.Panel languagepanel;
        private System.Windows.Forms.Panel musicpanel;
        private System.Windows.Forms.Panel portraitspanel;
        private System.Windows.Forms.ToolTip PortraitsDefault;
        private System.Windows.Forms.ToolTip PortraitsGoofy;
        private System.Windows.Forms.ToolTip FogEffects;
        private System.Windows.Forms.ToolTip EnglishLanguage;
        private System.Windows.Forms.Button buttonVPNstart;
        private System.Windows.Forms.Button VPNMoreButton;
        private System.Windows.Forms.Label versionLabel;
    }
}

