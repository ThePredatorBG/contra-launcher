namespace Contra
{
    partial class VPNForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VPNForm));
            this.button18 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.UPnPCheckBox = new System.Windows.Forms.CheckBox();
            this.AutoConnectCheckBox = new System.Windows.Forms.CheckBox();
            this.buttonVPNdebuglog = new System.Windows.Forms.Button();
            this.buttonVPNinvkey = new System.Windows.Forms.Button();
            this.buttonVPNconsole = new System.Windows.Forms.Button();
            this.UPnPToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.AutoConnectToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button18.BackgroundImage = global::Contra.Properties.Resources.exit1;
            this.button18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button18.FlatAppearance.BorderSize = 0;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Location = new System.Drawing.Point(199, 31);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(20, 20);
            this.button18.TabIndex = 25;
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
            this.button17.Location = new System.Drawing.Point(173, 31);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(20, 20);
            this.button17.TabIndex = 26;
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // UPnPCheckBox
            // 
            this.UPnPCheckBox.AutoSize = true;
            this.UPnPCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.UPnPCheckBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UPnPCheckBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.UPnPCheckBox.Location = new System.Drawing.Point(46, 181);
            this.UPnPCheckBox.Name = "UPnPCheckBox";
            this.UPnPCheckBox.Size = new System.Drawing.Size(61, 22);
            this.UPnPCheckBox.TabIndex = 42;
            this.UPnPCheckBox.Text = "UPnP";
            this.UPnPToolTip.SetToolTip(this.UPnPCheckBox, "Search for local UPnP-IGD devices, this can improve connectivity if UPnP is enabl" +
        "ed on your router.\r\nRequires miniuonpc support (tinc distributed by Contra has t" +
        "his, official does not).");
            this.UPnPCheckBox.UseVisualStyleBackColor = false;
            this.UPnPCheckBox.CheckedChanged += new System.EventHandler(this.UPnPCheckBox_CheckedChanged);
            // 
            // AutoConnectCheckBox
            // 
            this.AutoConnectCheckBox.AutoSize = true;
            this.AutoConnectCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.AutoConnectCheckBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AutoConnectCheckBox.ForeColor = System.Drawing.Color.White;
            this.AutoConnectCheckBox.Location = new System.Drawing.Point(46, 207);
            this.AutoConnectCheckBox.Name = "AutoConnectCheckBox";
            this.AutoConnectCheckBox.Size = new System.Drawing.Size(108, 22);
            this.AutoConnectCheckBox.TabIndex = 43;
            this.AutoConnectCheckBox.Text = "AutoConnect";
            this.AutoConnectToolTip.SetToolTip(this.AutoConnectCheckBox, "Automatically set up meta connections to other nodes.\r\nThis allows you to retain " +
        "connection with other players even if contravpn node goes down.\r\nOnly works with" +
        " nodes that have open ports.\r\n");
            this.AutoConnectCheckBox.UseVisualStyleBackColor = false;
            this.AutoConnectCheckBox.CheckedChanged += new System.EventHandler(this.AutoConnectCheckBox_CheckedChanged);
            // 
            // buttonVPNdebuglog
            // 
            this.buttonVPNdebuglog.BackColor = System.Drawing.Color.Transparent;
            this.buttonVPNdebuglog.BackgroundImage = global::Contra.Properties.Resources._button_log;
            this.buttonVPNdebuglog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonVPNdebuglog.FlatAppearance.BorderSize = 0;
            this.buttonVPNdebuglog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonVPNdebuglog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonVPNdebuglog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVPNdebuglog.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonVPNdebuglog.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonVPNdebuglog.Location = new System.Drawing.Point(170, 85);
            this.buttonVPNdebuglog.Name = "buttonVPNdebuglog";
            this.buttonVPNdebuglog.Size = new System.Drawing.Size(54, 47);
            this.buttonVPNdebuglog.TabIndex = 44;
            this.buttonVPNdebuglog.UseVisualStyleBackColor = false;
            this.buttonVPNdebuglog.Click += new System.EventHandler(this.buttonVPNdebuglog_Click);
            this.buttonVPNdebuglog.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonVPNdebuglog_MouseDown);
            this.buttonVPNdebuglog.MouseEnter += new System.EventHandler(this.buttonVPNdebuglog_MouseEnter);
            this.buttonVPNdebuglog.MouseLeave += new System.EventHandler(this.buttonVPNdebuglog_MouseLeave);
            // 
            // buttonVPNinvkey
            // 
            this.buttonVPNinvkey.BackColor = System.Drawing.Color.Transparent;
            this.buttonVPNinvkey.BackgroundImage = global::Contra.Properties.Resources._button_invite;
            this.buttonVPNinvkey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonVPNinvkey.FlatAppearance.BorderSize = 0;
            this.buttonVPNinvkey.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonVPNinvkey.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonVPNinvkey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVPNinvkey.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonVPNinvkey.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonVPNinvkey.Location = new System.Drawing.Point(30, 85);
            this.buttonVPNinvkey.Name = "buttonVPNinvkey";
            this.buttonVPNinvkey.Size = new System.Drawing.Size(54, 47);
            this.buttonVPNinvkey.TabIndex = 45;
            this.buttonVPNinvkey.UseVisualStyleBackColor = false;
            this.buttonVPNinvkey.Click += new System.EventHandler(this.buttonVPNinvkey_Click);
            this.buttonVPNinvkey.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonVPNinvkey_MouseDown);
            this.buttonVPNinvkey.MouseEnter += new System.EventHandler(this.buttonVPNinvkey_MouseEnter);
            this.buttonVPNinvkey.MouseLeave += new System.EventHandler(this.buttonVPNinvkey_MouseLeave);
            // 
            // buttonVPNconsole
            // 
            this.buttonVPNconsole.BackColor = System.Drawing.Color.Transparent;
            this.buttonVPNconsole.BackgroundImage = global::Contra.Properties.Resources._button_console;
            this.buttonVPNconsole.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonVPNconsole.FlatAppearance.BorderSize = 0;
            this.buttonVPNconsole.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonVPNconsole.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonVPNconsole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVPNconsole.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonVPNconsole.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonVPNconsole.Location = new System.Drawing.Point(100, 85);
            this.buttonVPNconsole.Name = "buttonVPNconsole";
            this.buttonVPNconsole.Size = new System.Drawing.Size(54, 47);
            this.buttonVPNconsole.TabIndex = 46;
            this.buttonVPNconsole.UseVisualStyleBackColor = false;
            this.buttonVPNconsole.Click += new System.EventHandler(this.buttonVPNconsole_Click);
            this.buttonVPNconsole.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonVPNconsole_MouseDown);
            this.buttonVPNconsole.MouseEnter += new System.EventHandler(this.buttonVPNconsole_MouseEnter);
            this.buttonVPNconsole.MouseLeave += new System.EventHandler(this.buttonVPNconsole_MouseLeave);
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
            this.label1.Location = new System.Drawing.Point(36, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 47;
            this.label1.Text = "Invite";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(98, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 48;
            this.label2.Text = "Console";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(160, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 49;
            this.label3.Text = "Debug Log";
            // 
            // VPNForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(250, 325);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonVPNconsole);
            this.Controls.Add(this.buttonVPNinvkey);
            this.Controls.Add(this.buttonVPNdebuglog);
            this.Controls.Add(this.AutoConnectCheckBox);
            this.Controls.Add(this.UPnPCheckBox);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button18);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VPNForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContraVPN Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.CheckBox UPnPCheckBox;
        private System.Windows.Forms.CheckBox AutoConnectCheckBox;
        private System.Windows.Forms.Button buttonVPNdebuglog;
        private System.Windows.Forms.Button buttonVPNinvkey;
        private System.Windows.Forms.Button buttonVPNconsole;
        private System.Windows.Forms.ToolTip UPnPToolTip;
        private System.Windows.Forms.ToolTip AutoConnectToolTip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}