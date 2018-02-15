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
            this.button18 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.UPnPCheckBox = new System.Windows.Forms.CheckBox();
            this.AutoConnectCheckBox = new System.Windows.Forms.CheckBox();
            this.buttonVPNdebuglog = new System.Windows.Forms.Button();
            this.buttonVPNinvkey = new System.Windows.Forms.Button();
            this.buttonVPNconsole = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button18.BackgroundImage = global::Contra.Properties.Resources.exit1;
            this.button18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button18.FlatAppearance.BorderSize = 0;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Location = new System.Drawing.Point(240, 12);
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
            this.button17.Location = new System.Drawing.Point(214, 12);
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
            this.UPnPCheckBox.Font = new System.Drawing.Font("Berlin Sans FB Demi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UPnPCheckBox.ForeColor = System.Drawing.Color.White;
            this.UPnPCheckBox.Location = new System.Drawing.Point(158, 105);
            this.UPnPCheckBox.Name = "UPnPCheckBox";
            this.UPnPCheckBox.Size = new System.Drawing.Size(59, 20);
            this.UPnPCheckBox.TabIndex = 42;
            this.UPnPCheckBox.Text = "UPnP";
            this.UPnPCheckBox.UseVisualStyleBackColor = false;
            this.UPnPCheckBox.CheckedChanged += new System.EventHandler(this.UPnPCheckBox_CheckedChanged);
            // 
            // AutoConnectCheckBox
            // 
            this.AutoConnectCheckBox.AutoSize = true;
            this.AutoConnectCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.AutoConnectCheckBox.Font = new System.Drawing.Font("Berlin Sans FB Demi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoConnectCheckBox.ForeColor = System.Drawing.Color.White;
            this.AutoConnectCheckBox.Location = new System.Drawing.Point(158, 131);
            this.AutoConnectCheckBox.Name = "AutoConnectCheckBox";
            this.AutoConnectCheckBox.Size = new System.Drawing.Size(101, 20);
            this.AutoConnectCheckBox.TabIndex = 43;
            this.AutoConnectCheckBox.Text = "AutoConnect";
            this.AutoConnectCheckBox.UseVisualStyleBackColor = false;
            this.AutoConnectCheckBox.CheckedChanged += new System.EventHandler(this.AutoConnectCheckBox_CheckedChanged);
            // 
            // buttonVPNdebuglog
            // 
            this.buttonVPNdebuglog.BackColor = System.Drawing.Color.Transparent;
            this.buttonVPNdebuglog.BackgroundImage = global::Contra.Properties.Resources._button_readme;
            this.buttonVPNdebuglog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonVPNdebuglog.FlatAppearance.BorderSize = 0;
            this.buttonVPNdebuglog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonVPNdebuglog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonVPNdebuglog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVPNdebuglog.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonVPNdebuglog.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonVPNdebuglog.Location = new System.Drawing.Point(36, 49);
            this.buttonVPNdebuglog.Name = "buttonVPNdebuglog";
            this.buttonVPNdebuglog.Size = new System.Drawing.Size(48, 48);
            this.buttonVPNdebuglog.TabIndex = 44;
            this.buttonVPNdebuglog.UseVisualStyleBackColor = false;
            // 
            // buttonVPNinvkey
            // 
            this.buttonVPNinvkey.BackColor = System.Drawing.Color.Transparent;
            this.buttonVPNinvkey.BackgroundImage = global::Contra.Properties.Resources._button_readme;
            this.buttonVPNinvkey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonVPNinvkey.FlatAppearance.BorderSize = 0;
            this.buttonVPNinvkey.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonVPNinvkey.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonVPNinvkey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVPNinvkey.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonVPNinvkey.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonVPNinvkey.Location = new System.Drawing.Point(45, 103);
            this.buttonVPNinvkey.Name = "buttonVPNinvkey";
            this.buttonVPNinvkey.Size = new System.Drawing.Size(48, 48);
            this.buttonVPNinvkey.TabIndex = 45;
            this.buttonVPNinvkey.UseVisualStyleBackColor = false;
            // 
            // buttonVPNconsole
            // 
            this.buttonVPNconsole.BackColor = System.Drawing.Color.Transparent;
            this.buttonVPNconsole.BackgroundImage = global::Contra.Properties.Resources._button_readme;
            this.buttonVPNconsole.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonVPNconsole.FlatAppearance.BorderSize = 0;
            this.buttonVPNconsole.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonVPNconsole.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonVPNconsole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVPNconsole.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonVPNconsole.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonVPNconsole.Location = new System.Drawing.Point(45, 167);
            this.buttonVPNconsole.Name = "buttonVPNconsole";
            this.buttonVPNconsole.Size = new System.Drawing.Size(48, 48);
            this.buttonVPNconsole.TabIndex = 46;
            this.buttonVPNconsole.UseVisualStyleBackColor = false;
            // 
            // VPNForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(271, 345);
            this.Controls.Add(this.buttonVPNconsole);
            this.Controls.Add(this.buttonVPNinvkey);
            this.Controls.Add(this.buttonVPNdebuglog);
            this.Controls.Add(this.AutoConnectCheckBox);
            this.Controls.Add(this.UPnPCheckBox);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button18);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "VPNForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VPNForm";
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
    }
}