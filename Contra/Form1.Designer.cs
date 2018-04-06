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
            this.VoicesLocalizedToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.QSCheckBox = new System.Windows.Forms.CheckBox();
            this.MNew = new System.Windows.Forms.RadioButton();
            this.MStandard = new System.Windows.Forms.RadioButton();
            this.WinCheckBox = new System.Windows.Forms.CheckBox();
            this.QSToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.FogCheckBox = new System.Windows.Forms.CheckBox();
            this.WindowedToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.NewMusicToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.DefaultPics = new System.Windows.Forms.RadioButton();
            this.StandardMusicToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.GoofyPics = new System.Windows.Forms.RadioButton();
            this.Русский = new System.Windows.Forms.ToolTip(this.components);
            this.voicespanel = new System.Windows.Forms.Panel();
            this.languagepanel = new System.Windows.Forms.Panel();
            this.musicpanel = new System.Windows.Forms.Panel();
            this.portraitspanel = new System.Windows.Forms.Panel();
            this.PortraitsDefault = new System.Windows.Forms.ToolTip(this.components);
            this.PortraitsGoofy = new System.Windows.Forms.ToolTip(this.components);
            this.FogEffects = new System.Windows.Forms.ToolTip(this.components);
            this.EnglishLanguage = new System.Windows.Forms.ToolTip(this.components);
            this.invkeytextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonVPNinvclose = new System.Windows.Forms.Button();
            this.buttonVPNinvOK = new System.Windows.Forms.Button();
            this.UPnPToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.AutoConnectToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
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
            this.voicespanel.SuspendLayout();
            this.languagepanel.SuspendLayout();
            this.musicpanel.SuspendLayout();
            this.portraitspanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RadioEN
            // 
            this.RadioEN.AutoSize = true;
            this.RadioEN.Checked = true;
            this.RadioEN.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RadioEN.ForeColor = System.Drawing.Color.White;
            this.RadioEN.Location = new System.Drawing.Point(3, 7);
            this.RadioEN.Name = "RadioEN";
            this.RadioEN.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RadioEN.Size = new System.Drawing.Size(70, 22);
            this.RadioEN.TabIndex = 2;
            this.RadioEN.TabStop = true;
            this.RadioEN.Text = "English";
            this.EnglishLanguage.SetToolTip(this.RadioEN, "English language");
            this.RadioEN.UseVisualStyleBackColor = true;
            this.RadioEN.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // RadioRU
            // 
            this.RadioRU.AutoSize = true;
            this.RadioRU.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RadioRU.Location = new System.Drawing.Point(3, 33);
            this.RadioRU.Name = "RadioRU";
            this.RadioRU.Size = new System.Drawing.Size(73, 22);
            this.RadioRU.TabIndex = 3;
            this.RadioRU.Text = "Russian";
            this.Русский.SetToolTip(this.RadioRU, "Русский");
            this.RadioRU.UseVisualStyleBackColor = true;
            this.RadioRU.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // RadioOrigQuotes
            // 
            this.RadioOrigQuotes.AutoSize = true;
            this.RadioOrigQuotes.Cursor = System.Windows.Forms.Cursors.Default;
            this.RadioOrigQuotes.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RadioOrigQuotes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RadioOrigQuotes.Location = new System.Drawing.Point(4, 33);
            this.RadioOrigQuotes.Name = "RadioOrigQuotes";
            this.RadioOrigQuotes.Size = new System.Drawing.Size(67, 22);
            this.RadioOrigQuotes.TabIndex = 4;
            this.RadioOrigQuotes.Text = "Native";
            this.VoicesOriginalToolTip.SetToolTip(this.RadioOrigQuotes, "Each faction\'s units will speak their native language.");
            this.RadioOrigQuotes.UseVisualStyleBackColor = true;
            this.RadioOrigQuotes.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // RadioLocQuotes
            // 
            this.RadioLocQuotes.AutoSize = true;
            this.RadioLocQuotes.Checked = true;
            this.RadioLocQuotes.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RadioLocQuotes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RadioLocQuotes.Location = new System.Drawing.Point(4, 7);
            this.RadioLocQuotes.Name = "RadioLocQuotes";
            this.RadioLocQuotes.Size = new System.Drawing.Size(70, 22);
            this.RadioLocQuotes.TabIndex = 5;
            this.RadioLocQuotes.TabStop = true;
            this.RadioLocQuotes.Text = "English";
            this.VoicesLocalizedToolTip.SetToolTip(this.RadioLocQuotes, "Units of all three factions will speak English.");
            this.RadioLocQuotes.UseVisualStyleBackColor = true;
            this.RadioLocQuotes.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // VoicesOriginalToolTip
            // 
            this.VoicesOriginalToolTip.AutoPopDelay = 5000;
            this.VoicesOriginalToolTip.InitialDelay = 50;
            this.VoicesOriginalToolTip.ReshowDelay = 100;
            // 
            // VoicesLocalizedToolTip
            // 
            this.VoicesLocalizedToolTip.AutoPopDelay = 5000;
            this.VoicesLocalizedToolTip.InitialDelay = 50;
            this.VoicesLocalizedToolTip.ReshowDelay = 100;
            // 
            // QSCheckBox
            // 
            this.QSCheckBox.AutoSize = true;
            this.QSCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.QSCheckBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QSCheckBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.QSCheckBox.Location = new System.Drawing.Point(269, 430);
            this.QSCheckBox.Name = "QSCheckBox";
            this.QSCheckBox.Size = new System.Drawing.Size(91, 22);
            this.QSCheckBox.TabIndex = 16;
            this.QSCheckBox.Text = "QuickStart";
            this.QSToolTip.SetToolTip(this.QSCheckBox, "Disables intro and shellmap (game starts up faster).");
            this.QSCheckBox.UseVisualStyleBackColor = false;
            // 
            // MNew
            // 
            this.MNew.AutoSize = true;
            this.MNew.Checked = true;
            this.MNew.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MNew.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MNew.Location = new System.Drawing.Point(4, 7);
            this.MNew.Name = "MNew";
            this.MNew.Size = new System.Drawing.Size(55, 22);
            this.MNew.TabIndex = 0;
            this.MNew.TabStop = true;
            this.MNew.Text = "New";
            this.NewMusicToolTip.SetToolTip(this.MNew, "Use new soundtracks.");
            this.MNew.UseVisualStyleBackColor = true;
            this.MNew.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // MStandard
            // 
            this.MStandard.AutoSize = true;
            this.MStandard.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MStandard.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MStandard.Location = new System.Drawing.Point(4, 33);
            this.MStandard.Name = "MStandard";
            this.MStandard.Size = new System.Drawing.Size(81, 22);
            this.MStandard.TabIndex = 1;
            this.MStandard.Text = "Standard";
            this.StandardMusicToolTip.SetToolTip(this.MStandard, "Use standard Zero Hour soundtracks.");
            this.MStandard.UseVisualStyleBackColor = true;
            this.MStandard.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged_1);
            // 
            // WinCheckBox
            // 
            this.WinCheckBox.AutoSize = true;
            this.WinCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.WinCheckBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WinCheckBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.WinCheckBox.Location = new System.Drawing.Point(269, 411);
            this.WinCheckBox.Name = "WinCheckBox";
            this.WinCheckBox.Size = new System.Drawing.Size(96, 22);
            this.WinCheckBox.TabIndex = 17;
            this.WinCheckBox.Text = "Windowed";
            this.WindowedToolTip.SetToolTip(this.WinCheckBox, "Starts Contra in a window instead of full screen.");
            this.WinCheckBox.UseVisualStyleBackColor = false;
            this.WinCheckBox.CheckedChanged += new System.EventHandler(this.WinCheckBox_CheckedChanged);
            // 
            // QSToolTip
            // 
            this.QSToolTip.AutoPopDelay = 5000;
            this.QSToolTip.InitialDelay = 50;
            this.QSToolTip.ReshowDelay = 100;
            // 
            // FogCheckBox
            // 
            this.FogCheckBox.AutoSize = true;
            this.FogCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.FogCheckBox.Checked = true;
            this.FogCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FogCheckBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FogCheckBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FogCheckBox.Location = new System.Drawing.Point(435, 421);
            this.FogCheckBox.Name = "FogCheckBox";
            this.FogCheckBox.Size = new System.Drawing.Size(93, 22);
            this.FogCheckBox.TabIndex = 30;
            this.FogCheckBox.Text = "Fog Effects";
            this.FogEffects.SetToolTip(this.FogCheckBox, "Toggle fog (depth of field) effects on/off.");
            this.FogCheckBox.UseVisualStyleBackColor = false;
            this.FogCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
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
            // DefaultPics
            // 
            this.DefaultPics.AutoSize = true;
            this.DefaultPics.Checked = true;
            this.DefaultPics.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DefaultPics.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DefaultPics.Location = new System.Drawing.Point(3, 7);
            this.DefaultPics.Name = "DefaultPics";
            this.DefaultPics.Size = new System.Drawing.Size(72, 22);
            this.DefaultPics.TabIndex = 0;
            this.DefaultPics.TabStop = true;
            this.DefaultPics.Text = "Default";
            this.PortraitsDefault.SetToolTip(this.DefaultPics, "Use default general portraits.");
            this.DefaultPics.UseVisualStyleBackColor = true;
            // 
            // StandardMusicToolTip
            // 
            this.StandardMusicToolTip.AutoPopDelay = 5000;
            this.StandardMusicToolTip.InitialDelay = 50;
            this.StandardMusicToolTip.ReshowDelay = 100;
            // 
            // GoofyPics
            // 
            this.GoofyPics.AutoSize = true;
            this.GoofyPics.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoofyPics.Location = new System.Drawing.Point(3, 33);
            this.GoofyPics.Name = "GoofyPics";
            this.GoofyPics.Size = new System.Drawing.Size(64, 22);
            this.GoofyPics.TabIndex = 1;
            this.GoofyPics.Text = "Goofy";
            this.PortraitsGoofy.SetToolTip(this.GoofyPics, "Use funny general portraits.");
            this.GoofyPics.UseVisualStyleBackColor = true;
            this.GoofyPics.CheckedChanged += new System.EventHandler(this.GoofyPics_CheckedChanged);
            // 
            // Русский
            // 
            this.Русский.AutoPopDelay = 5000;
            this.Русский.InitialDelay = 50;
            this.Русский.ReshowDelay = 100;
            // 
            // voicespanel
            // 
            this.voicespanel.BackColor = System.Drawing.Color.Transparent;
            this.voicespanel.Controls.Add(this.RadioOrigQuotes);
            this.voicespanel.Controls.Add(this.RadioLocQuotes);
            this.voicespanel.Location = new System.Drawing.Point(275, 212);
            this.voicespanel.Name = "voicespanel";
            this.voicespanel.Size = new System.Drawing.Size(74, 61);
            this.voicespanel.TabIndex = 32;
            this.voicespanel.Paint += new System.Windows.Forms.PaintEventHandler(this.voicespanel_Paint);
            // 
            // languagepanel
            // 
            this.languagepanel.BackColor = System.Drawing.Color.Transparent;
            this.languagepanel.Controls.Add(this.RadioRU);
            this.languagepanel.Controls.Add(this.RadioEN);
            this.languagepanel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.languagepanel.Location = new System.Drawing.Point(444, 212);
            this.languagepanel.Name = "languagepanel";
            this.languagepanel.Size = new System.Drawing.Size(70, 61);
            this.languagepanel.TabIndex = 33;
            this.languagepanel.Paint += new System.Windows.Forms.PaintEventHandler(this.languagepanel_Paint);
            // 
            // musicpanel
            // 
            this.musicpanel.BackColor = System.Drawing.Color.Transparent;
            this.musicpanel.Controls.Add(this.MStandard);
            this.musicpanel.Controls.Add(this.MNew);
            this.musicpanel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.musicpanel.Location = new System.Drawing.Point(275, 306);
            this.musicpanel.Name = "musicpanel";
            this.musicpanel.Size = new System.Drawing.Size(81, 61);
            this.musicpanel.TabIndex = 34;
            // 
            // portraitspanel
            // 
            this.portraitspanel.BackColor = System.Drawing.Color.Transparent;
            this.portraitspanel.Controls.Add(this.GoofyPics);
            this.portraitspanel.Controls.Add(this.DefaultPics);
            this.portraitspanel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.portraitspanel.Location = new System.Drawing.Point(441, 306);
            this.portraitspanel.Name = "portraitspanel";
            this.portraitspanel.Size = new System.Drawing.Size(84, 61);
            this.portraitspanel.TabIndex = 35;
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
            // invkeytextBox
            // 
            this.invkeytextBox.Location = new System.Drawing.Point(14, 41);
            this.invkeytextBox.Name = "invkeytextBox";
            this.invkeytextBox.Size = new System.Drawing.Size(195, 20);
            this.invkeytextBox.TabIndex = 38;
            this.invkeytextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonVPNinvclose);
            this.panel1.Controls.Add(this.buttonVPNinvOK);
            this.panel1.Controls.Add(this.invkeytextBox);
            this.panel1.Location = new System.Drawing.Point(778, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 127);
            this.panel1.TabIndex = 39;
            // 
            // buttonVPNinvclose
            // 
            this.buttonVPNinvclose.Location = new System.Drawing.Point(134, 88);
            this.buttonVPNinvclose.Name = "buttonVPNinvclose";
            this.buttonVPNinvclose.Size = new System.Drawing.Size(75, 23);
            this.buttonVPNinvclose.TabIndex = 40;
            this.buttonVPNinvclose.Text = "Close";
            this.buttonVPNinvclose.UseVisualStyleBackColor = true;
            // 
            // buttonVPNinvOK
            // 
            this.buttonVPNinvOK.Location = new System.Drawing.Point(53, 88);
            this.buttonVPNinvOK.Name = "buttonVPNinvOK";
            this.buttonVPNinvOK.Size = new System.Drawing.Size(75, 23);
            this.buttonVPNinvOK.TabIndex = 39;
            this.buttonVPNinvOK.Text = "OK";
            this.buttonVPNinvOK.UseVisualStyleBackColor = true;
            this.buttonVPNinvOK.Click += new System.EventHandler(this.buttonVPNinvOK_Click);
            // 
            // UPnPToolTip
            // 
            this.UPnPToolTip.AutoPopDelay = 7500;
            this.UPnPToolTip.InitialDelay = 50;
            this.UPnPToolTip.ReshowDelay = 100;
            // 
            // AutoConnectToolTip
            // 
            this.AutoConnectToolTip.AutoPopDelay = 10000;
            this.AutoConnectToolTip.InitialDelay = 50;
            this.AutoConnectToolTip.ReshowDelay = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(664, 556);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 18);
            this.label1.TabIndex = 45;
            this.label1.Text = "Version 009 Final";
            // 
            // VPNMoreButton
            // 
            this.VPNMoreButton.BackColor = System.Drawing.Color.Transparent;
            this.VPNMoreButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("VPNMoreButton.BackgroundImage")));
            this.VPNMoreButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VPNMoreButton.FlatAppearance.BorderSize = 0;
            this.VPNMoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.VPNMoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.VPNMoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VPNMoreButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VPNMoreButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.VPNMoreButton.Location = new System.Drawing.Point(59, 136);
            this.VPNMoreButton.Name = "VPNMoreButton";
            this.VPNMoreButton.Size = new System.Drawing.Size(54, 47);
            this.VPNMoreButton.TabIndex = 44;
            this.VPNMoreButton.UseVisualStyleBackColor = false;
            this.VPNMoreButton.Click += new System.EventHandler(this.VPNMoreButton_Click);
            this.VPNMoreButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.VPNMoreButton_MouseDown);
            this.VPNMoreButton.MouseEnter += new System.EventHandler(this.VPNMoreButton_MouseEnter);
            this.VPNMoreButton.MouseLeave += new System.EventHandler(this.VPNMoreButton_MouseLeave);
            // 
            // buttonVPNstart
            // 
            this.buttonVPNstart.BackColor = System.Drawing.Color.Transparent;
            this.buttonVPNstart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonVPNstart.BackgroundImage")));
            this.buttonVPNstart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonVPNstart.FlatAppearance.BorderSize = 0;
            this.buttonVPNstart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonVPNstart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonVPNstart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVPNstart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonVPNstart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonVPNstart.Location = new System.Drawing.Point(100, 160);
            this.buttonVPNstart.Name = "buttonVPNstart";
            this.buttonVPNstart.Size = new System.Drawing.Size(107, 93);
            this.buttonVPNstart.TabIndex = 36;
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
            this.helpbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpbutton.Font = new System.Drawing.Font("SF Willamette", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.helpbutton.Location = new System.Drawing.Point(645, 260);
            this.helpbutton.Name = "helpbutton";
            this.helpbutton.Size = new System.Drawing.Size(107, 93);
            this.helpbutton.TabIndex = 29;
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
            this.buttonChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonChat.Location = new System.Drawing.Point(45, 260);
            this.buttonChat.Name = "buttonChat";
            this.buttonChat.Size = new System.Drawing.Size(107, 93);
            this.buttonChat.TabIndex = 28;
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
            this.button18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button18.FlatAppearance.BorderSize = 0;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Location = new System.Drawing.Point(732, 48);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(20, 20);
            this.button18.TabIndex = 24;
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button17.BackgroundImage = global::Contra.Properties.Resources.min;
            this.button17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button17.FlatAppearance.BorderSize = 0;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.Location = new System.Drawing.Point(701, 48);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(20, 20);
            this.button17.TabIndex = 23;
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
            this.websitebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.websitebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.websitebutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.websitebutton.Location = new System.Drawing.Point(45, 460);
            this.websitebutton.Name = "websitebutton";
            this.websitebutton.Size = new System.Drawing.Size(107, 93);
            this.websitebutton.TabIndex = 22;
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
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("SF Willamette", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(344, 432);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 93);
            this.button2.TabIndex = 1;
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
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(100, 360);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 93);
            this.button3.TabIndex = 17;
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
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Location = new System.Drawing.Point(590, 360);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(107, 93);
            this.button6.TabIndex = 13;
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
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(645, 460);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(107, 93);
            this.button5.TabIndex = 12;
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
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("SF Willamette", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(344, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 93);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VPNMoreButton);
            this.Controls.Add(this.panel1);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contra Launcher";
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
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.TextBox invkeytextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonVPNinvclose;
        private System.Windows.Forms.Button buttonVPNinvOK;
        private System.Windows.Forms.ToolTip UPnPToolTip;
        private System.Windows.Forms.ToolTip AutoConnectToolTip;
        private System.Windows.Forms.Button VPNMoreButton;
        private System.Windows.Forms.Label label1;
    }
}

