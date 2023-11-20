﻿namespace ABC_Bakery.Forms
{
    partial class DefaultForm
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
            components = new System.ComponentModel.Container();
            timer = new System.Windows.Forms.Timer(components);
            skyLabel1 = new ReaLTaiizor.Controls.SkyLabel();
            lbTimer = new ReaLTaiizor.Controls.SmallLabel();
            rjCircularPictureBox1 = new Helpers.UI.RJCircularPictureBox();
            roundedPanel1 = new Helpers.UI.RoundedPanel();
            lbTime = new ReaLTaiizor.Controls.BigLabel();
            ((System.ComponentModel.ISupportInitialize)rjCircularPictureBox1).BeginInit();
            roundedPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // timer
            // 
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            // 
            // skyLabel1
            // 
            skyLabel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            skyLabel1.AutoSize = true;
            skyLabel1.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
            skyLabel1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            skyLabel1.ForeColor = System.Drawing.Color.FromArgb(243, 255, 244);
            skyLabel1.Location = new System.Drawing.Point(129, 353);
            skyLabel1.Name = "skyLabel1";
            skyLabel1.Size = new System.Drawing.Size(249, 37);
            skyLabel1.TabIndex = 3;
            skyLabel1.Text = "Design By LaTeam";
            // 
            // lbTimer
            // 
            lbTimer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbTimer.BackColor = System.Drawing.Color.Transparent;
            lbTimer.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbTimer.ForeColor = System.Drawing.Color.FromArgb(184, 191, 183);
            lbTimer.Location = new System.Drawing.Point(0, 444);
            lbTimer.Name = "lbTimer";
            lbTimer.Size = new System.Drawing.Size(502, 49);
            lbTimer.TabIndex = 4;
            lbTimer.Text = "smallLabel1";
            lbTimer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rjCircularPictureBox1
            // 
            rjCircularPictureBox1.Anchor = AnchorStyles.None;
            rjCircularPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            rjCircularPictureBox1.BorderColor = System.Drawing.Color.RoyalBlue;
            rjCircularPictureBox1.BorderColor2 = System.Drawing.Color.HotPink;
            rjCircularPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            rjCircularPictureBox1.BorderSize = 0;
            rjCircularPictureBox1.GradientAngle = 50F;
            rjCircularPictureBox1.Image = Properties.Resources.logo_team;
            rjCircularPictureBox1.Location = new System.Drawing.Point(81, 17);
            rjCircularPictureBox1.Name = "rjCircularPictureBox1";
            rjCircularPictureBox1.Size = new System.Drawing.Size(333, 333);
            rjCircularPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            rjCircularPictureBox1.TabIndex = 5;
            rjCircularPictureBox1.TabStop = false;
            // 
            // roundedPanel1
            // 
            roundedPanel1.Anchor = AnchorStyles.None;
            roundedPanel1.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
            roundedPanel1.Controls.Add(lbTime);
            roundedPanel1.Controls.Add(rjCircularPictureBox1);
            roundedPanel1.Controls.Add(skyLabel1);
            roundedPanel1.Controls.Add(lbTimer);
            roundedPanel1.ForeColor = System.Drawing.Color.White;
            roundedPanel1.Location = new System.Drawing.Point(273, 75);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new System.Drawing.Size(502, 507);
            roundedPanel1.TabIndex = 6;
            // 
            // lbTime
            // 
            lbTime.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbTime.AutoSize = true;
            lbTime.BackColor = System.Drawing.Color.Transparent;
            lbTime.FlatStyle = FlatStyle.Flat;
            lbTime.Font = new Font("Segoe UI", 24.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbTime.ForeColor = System.Drawing.Color.FromArgb(220, 229, 219);
            lbTime.Location = new System.Drawing.Point(166, 399);
            lbTime.Name = "lbTime";
            lbTime.Size = new System.Drawing.Size(170, 45);
            lbTime.TabIndex = 6;
            lbTime.Text = "bigLabel1";
            // 
            // DefaultForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(226, 199, 153);
            BackgroundImage = Properties.Resources.Bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1059, 603);
            Controls.Add(roundedPanel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "DefaultForm";
            Text = "DefaultForm";
            Load += DefaultForm_Load;
            ((System.ComponentModel.ISupportInitialize)rjCircularPictureBox1).EndInit();
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private ReaLTaiizor.Controls.SkyLabel skyLabel1;
        private ReaLTaiizor.Controls.SmallLabel lbTimer;
        private Helpers.UI.RJCircularPictureBox rjCircularPictureBox1;
        private Helpers.UI.RoundedPanel roundedPanel1;
        private ReaLTaiizor.Controls.BigLabel lbTime;
    }
}