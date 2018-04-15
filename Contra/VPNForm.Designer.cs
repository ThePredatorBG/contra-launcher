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
            this.InvitePanel = new System.Windows.Forms.Panel();
            this.labelEnterInvite = new System.Windows.Forms.Label();
            this.buttonVPNinvclose = new System.Windows.Forms.Button();
            this.buttonVPNinvOK = new System.Windows.Forms.Button();
            this.invkeytextBox = new System.Windows.Forms.TextBox();
            this.labelInvite = new System.Windows.Forms.Label();
            this.labelConsole = new System.Windows.Forms.Label();
            this.labelMonitor = new System.Windows.Forms.Label();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.InvitePanel.SuspendLayout();
            this.SuspendLayout();
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
            // 
            // UPnPCheckBox
            // 
            resources.ApplyResources(this.UPnPCheckBox, "UPnPCheckBox");
            this.UPnPCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.UPnPCheckBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.UPnPCheckBox.Name = "UPnPCheckBox";
            this.UPnPCheckBox.UseVisualStyleBackColor = false;
            this.UPnPCheckBox.CheckedChanged += new System.EventHandler(this.UPnPCheckBox_CheckedChanged);
            // 
            // AutoConnectCheckBox
            // 
            resources.ApplyResources(this.AutoConnectCheckBox, "AutoConnectCheckBox");
            this.AutoConnectCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.AutoConnectCheckBox.ForeColor = System.Drawing.Color.White;
            this.AutoConnectCheckBox.Name = "AutoConnectCheckBox";
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
            resources.ApplyResources(this.buttonVPNdebuglog, "buttonVPNdebuglog");
            this.buttonVPNdebuglog.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonVPNdebuglog.Name = "buttonVPNdebuglog";
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
            resources.ApplyResources(this.buttonVPNinvkey, "buttonVPNinvkey");
            this.buttonVPNinvkey.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonVPNinvkey.Name = "buttonVPNinvkey";
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
            resources.ApplyResources(this.buttonVPNconsole, "buttonVPNconsole");
            this.buttonVPNconsole.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonVPNconsole.Name = "buttonVPNconsole";
            this.buttonVPNconsole.UseVisualStyleBackColor = false;
            this.buttonVPNconsole.Click += new System.EventHandler(this.buttonVPNconsole_Click);
            this.buttonVPNconsole.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonVPNconsole_MouseDown);
            this.buttonVPNconsole.MouseEnter += new System.EventHandler(this.buttonVPNconsole_MouseEnter);
            this.buttonVPNconsole.MouseLeave += new System.EventHandler(this.buttonVPNconsole_MouseLeave);
            // 
            // InvitePanel
            // 
            this.InvitePanel.Controls.Add(this.labelEnterInvite);
            this.InvitePanel.Controls.Add(this.buttonVPNinvclose);
            this.InvitePanel.Controls.Add(this.buttonVPNinvOK);
            this.InvitePanel.Controls.Add(this.invkeytextBox);
            resources.ApplyResources(this.InvitePanel, "InvitePanel");
            this.InvitePanel.Name = "InvitePanel";
            // 
            // labelEnterInvite
            // 
            resources.ApplyResources(this.labelEnterInvite, "labelEnterInvite");
            this.labelEnterInvite.BackColor = System.Drawing.Color.Transparent;
            this.labelEnterInvite.ForeColor = System.Drawing.Color.Transparent;
            this.labelEnterInvite.Name = "labelEnterInvite";
            // 
            // buttonVPNinvclose
            // 
            resources.ApplyResources(this.buttonVPNinvclose, "buttonVPNinvclose");
            this.buttonVPNinvclose.Name = "buttonVPNinvclose";
            this.buttonVPNinvclose.UseVisualStyleBackColor = true;
            this.buttonVPNinvclose.Click += new System.EventHandler(this.buttonVPNinvclose_Click);
            // 
            // buttonVPNinvOK
            // 
            resources.ApplyResources(this.buttonVPNinvOK, "buttonVPNinvOK");
            this.buttonVPNinvOK.Name = "buttonVPNinvOK";
            this.buttonVPNinvOK.UseVisualStyleBackColor = true;
            this.buttonVPNinvOK.Click += new System.EventHandler(this.buttonVPNinvOK_Click);
            // 
            // invkeytextBox
            // 
            resources.ApplyResources(this.invkeytextBox, "invkeytextBox");
            this.invkeytextBox.Name = "invkeytextBox";
            this.invkeytextBox.TextChanged += new System.EventHandler(this.invkeytextBox_TextChanged);
            // 
            // labelInvite
            // 
            resources.ApplyResources(this.labelInvite, "labelInvite");
            this.labelInvite.BackColor = System.Drawing.Color.Transparent;
            this.labelInvite.ForeColor = System.Drawing.Color.Transparent;
            this.labelInvite.Name = "labelInvite";
            // 
            // labelConsole
            // 
            resources.ApplyResources(this.labelConsole, "labelConsole");
            this.labelConsole.BackColor = System.Drawing.Color.Transparent;
            this.labelConsole.ForeColor = System.Drawing.Color.Transparent;
            this.labelConsole.Name = "labelConsole";
            // 
            // labelMonitor
            // 
            resources.ApplyResources(this.labelMonitor, "labelMonitor");
            this.labelMonitor.BackColor = System.Drawing.Color.Transparent;
            this.labelMonitor.ForeColor = System.Drawing.Color.Transparent;
            this.labelMonitor.Name = "labelMonitor";
            // 
            // toolTip2
            // 
            this.toolTip2.AutoPopDelay = 5000;
            this.toolTip2.InitialDelay = 50;
            this.toolTip2.ReshowDelay = 100;
            // 
            // VPNForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this, "$this");
            this.ControlBox = false;
            this.Controls.Add(this.labelMonitor);
            this.Controls.Add(this.labelConsole);
            this.Controls.Add(this.labelInvite);
            this.Controls.Add(this.buttonVPNconsole);
            this.Controls.Add(this.buttonVPNinvkey);
            this.Controls.Add(this.buttonVPNdebuglog);
            this.Controls.Add(this.AutoConnectCheckBox);
            this.Controls.Add(this.UPnPCheckBox);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.InvitePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "VPNForm";
            this.InvitePanel.ResumeLayout(false);
            this.InvitePanel.PerformLayout();
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
        private System.Windows.Forms.Panel InvitePanel;
        private System.Windows.Forms.Button buttonVPNinvclose;
        private System.Windows.Forms.Button buttonVPNinvOK;
        private System.Windows.Forms.TextBox invkeytextBox;
        private System.Windows.Forms.Label labelEnterInvite;
        private System.Windows.Forms.Label labelInvite;
        private System.Windows.Forms.Label labelConsole;
        private System.Windows.Forms.Label labelMonitor;
        private System.Windows.Forms.ToolTip toolTip2;
    }
}