﻿namespace OOPFinal
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu02));
            panel1 = new Panel();
            progressBar1 = new ProgressBar();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(progressBar1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(984, 661);
            panel1.TabIndex = 0;
            // 
            // progressBar1
            // 
            progressBar1.BackColor = SystemColors.Control;
            progressBar1.ForeColor = Color.Chocolate;
            progressBar1.Location = new Point(323, 469);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(329, 23);
            progressBar1.Step = 5;
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Orange;
            label1.Location = new Point(409, 512);
            label1.Name = "label1";
            label1.Size = new Size(202, 40);
            label1.TabIndex = 1;
            label1.Text = "Loading ...";
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 661);
            Controls.Add(panel1);
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Menu";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ProgressBar progressBar1;
        private Label label1;
    }
}
