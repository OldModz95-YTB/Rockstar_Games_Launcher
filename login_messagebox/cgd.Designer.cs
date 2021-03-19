
namespace Rockstar_Launcher.login_messagebox
{
    partial class cgd
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
            this.home_panel = new System.Windows.Forms.Panel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.panel_principal = new System.Windows.Forms.Panel();
            this.cgd_label_long = new System.Windows.Forms.PictureBox();
            this.cgd_label_pic = new System.Windows.Forms.PictureBox();
            this.button_close = new Guna.UI2.WinForms.Guna2Button();
            this.button_fermer = new Guna.UI2.WinForms.Guna2Button();
            this.Elipse_fermer = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Elipse_cgd_Form = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.home_panel.SuspendLayout();
            this.panel_principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cgd_label_long)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cgd_label_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // home_panel
            // 
            this.home_panel.Controls.Add(this.cgd_label_pic);
            this.home_panel.Controls.Add(this.bunifuSeparator1);
            this.home_panel.Controls.Add(this.button_close);
            this.home_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.home_panel.Location = new System.Drawing.Point(0, 0);
            this.home_panel.Name = "home_panel";
            this.home_panel.Size = new System.Drawing.Size(945, 95);
            this.home_panel.TabIndex = 1;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(30, 89);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(888, 10);
            this.bunifuSeparator1.TabIndex = 3;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(30, 419);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(888, 10);
            this.bunifuSeparator2.TabIndex = 4;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // panel_principal
            // 
            this.panel_principal.AutoScroll = true;
            this.panel_principal.Controls.Add(this.cgd_label_long);
            this.panel_principal.Location = new System.Drawing.Point(30, 95);
            this.panel_principal.Name = "panel_principal";
            this.panel_principal.Size = new System.Drawing.Size(890, 330);
            this.panel_principal.TabIndex = 5;
            // 
            // cgd_label_long
            // 
            this.cgd_label_long.Image = global::Rockstar_Launcher.Properties.Resources.exemple_cgd;
            this.cgd_label_long.Location = new System.Drawing.Point(1, 3);
            this.cgd_label_long.Name = "cgd_label_long";
            this.cgd_label_long.Size = new System.Drawing.Size(854, 326);
            this.cgd_label_long.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cgd_label_long.TabIndex = 0;
            this.cgd_label_long.TabStop = false;
            // 
            // cgd_label_pic
            // 
            this.cgd_label_pic.Image = global::Rockstar_Launcher.Properties.Resources.cgd_label;
            this.cgd_label_pic.Location = new System.Drawing.Point(30, 25);
            this.cgd_label_pic.Name = "cgd_label_pic";
            this.cgd_label_pic.Size = new System.Drawing.Size(512, 32);
            this.cgd_label_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cgd_label_pic.TabIndex = 4;
            this.cgd_label_pic.TabStop = false;
            // 
            // button_close
            // 
            this.button_close.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_close.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.button_close.BorderRadius = 15;
            this.button_close.CheckedState.Parent = this.button_close;
            this.button_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_close.CustomImages.Parent = this.button_close;
            this.button_close.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.button_close.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_close.ForeColor = System.Drawing.Color.OrangeRed;
            this.button_close.HoverState.Parent = this.button_close;
            this.button_close.Image = global::Rockstar_Launcher.Properties.Resources.delete_24px;
            this.button_close.Location = new System.Drawing.Point(900, 25);
            this.button_close.Name = "button_close";
            this.button_close.ShadowDecoration.Parent = this.button_close;
            this.button_close.Size = new System.Drawing.Size(20, 20);
            this.button_close.TabIndex = 2;
            this.button_close.Click += new System.EventHandler(this.button_settings_Click);
            // 
            // button_fermer
            // 
            this.button_fermer.CheckedState.Parent = this.button_fermer;
            this.button_fermer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_fermer.CustomImages.Parent = this.button_fermer;
            this.button_fermer.FillColor = System.Drawing.Color.White;
            this.button_fermer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_fermer.ForeColor = System.Drawing.Color.Black;
            this.button_fermer.HoverState.Parent = this.button_fermer;
            this.button_fermer.Location = new System.Drawing.Point(728, 459);
            this.button_fermer.Name = "button_fermer";
            this.button_fermer.ShadowDecoration.Parent = this.button_fermer;
            this.button_fermer.Size = new System.Drawing.Size(190, 45);
            this.button_fermer.TabIndex = 11;
            this.button_fermer.Text = "Fermer";
            this.button_fermer.Click += new System.EventHandler(this.button_fermer_Click);
            // 
            // Elipse_fermer
            // 
            this.Elipse_fermer.BorderRadius = 35;
            this.Elipse_fermer.TargetControl = this.button_fermer;
            // 
            // Elipse_cgd_Form
            // 
            this.Elipse_cgd_Form.BorderRadius = 45;
            this.Elipse_cgd_Form.TargetControl = this;
            // 
            // cgd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(945, 540);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.button_fermer);
            this.Controls.Add(this.panel_principal);
            this.Controls.Add(this.home_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "cgd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Condition Générales d\'Utilisation";
            this.home_panel.ResumeLayout(false);
            this.home_panel.PerformLayout();
            this.panel_principal.ResumeLayout(false);
            this.panel_principal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cgd_label_long)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cgd_label_pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel home_panel;
        private Guna.UI2.WinForms.Guna2Button button_close;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.Panel panel_principal;
        private System.Windows.Forms.PictureBox cgd_label_long;
        private System.Windows.Forms.PictureBox cgd_label_pic;
        private Guna.UI2.WinForms.Guna2Button button_fermer;
        private Guna.UI2.WinForms.Guna2Elipse Elipse_fermer;
        private Guna.UI2.WinForms.Guna2Elipse Elipse_cgd_Form;
    }
}