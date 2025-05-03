namespace OOPFinal
{
    partial class MainMenu02
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu02));
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            soundApply = new Button();
            SoundBack = new Button();
            groupBox2 = new GroupBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            level = new Button();
            location = new Button();
            sound = new Button();
            start = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(level);
            panel1.Controls.Add(location);
            panel1.Controls.Add(sound);
            panel1.Controls.Add(start);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(984, 661);
            panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Tan;
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(soundApply);
            groupBox1.Controls.Add(SoundBack);
            groupBox1.Location = new Point(12, 370);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(299, 201);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sound";
            groupBox1.Visible = false;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(30, 60);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(46, 19);
            radioButton2.TabIndex = 3;
            radioButton2.TabStop = true;
            radioButton2.Text = "OFF";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(30, 35);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(43, 19);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "ON";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // soundApply
            // 
            soundApply.BackColor = Color.DarkSeaGreen;
            soundApply.FlatAppearance.BorderSize = 0;
            soundApply.FlatStyle = FlatStyle.Flat;
            soundApply.Font = new Font("Segoe UI", 11.25F);
            soundApply.ForeColor = SystemColors.ButtonHighlight;
            soundApply.Location = new Point(109, 157);
            soundApply.Name = "soundApply";
            soundApply.Size = new Size(75, 31);
            soundApply.TabIndex = 1;
            soundApply.Text = "Apply";
            soundApply.UseVisualStyleBackColor = false;
            soundApply.Click += soundApply_Click;
            // 
            // SoundBack
            // 
            SoundBack.BackColor = Color.DarkSeaGreen;
            SoundBack.FlatAppearance.BorderSize = 0;
            SoundBack.FlatStyle = FlatStyle.Flat;
            SoundBack.Font = new Font("Segoe UI", 11.25F);
            SoundBack.ForeColor = SystemColors.ButtonHighlight;
            SoundBack.Location = new Point(209, 157);
            SoundBack.Name = "SoundBack";
            SoundBack.Size = new Size(75, 31);
            SoundBack.TabIndex = 0;
            SoundBack.Text = "Back";
            SoundBack.UseVisualStyleBackColor = false;
            SoundBack.Click += SoundBack_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Tan;
            groupBox2.Controls.Add(pictureBox3);
            groupBox2.Controls.Add(pictureBox2);
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(button2);
            groupBox2.Location = new Point(121, 218);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(774, 353);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Location";
            groupBox2.Visible = false;
            groupBox2.Enter += groupBox2_Enter;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(521, 71);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(196, 115);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(287, 71);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(196, 115);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(52, 71);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(196, 115);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSeaGreen;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 11.25F);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(587, 309);
            button1.Name = "button1";
            button1.Size = new Size(75, 31);
            button1.TabIndex = 1;
            button1.Text = "Apply";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkSeaGreen;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 11.25F);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(678, 309);
            button2.Name = "button2";
            button2.Size = new Size(75, 31);
            button2.TabIndex = 0;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // level
            // 
            level.BackColor = Color.Gold;
            level.FlatStyle = FlatStyle.Flat;
            level.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            level.Location = new Point(492, 591);
            level.Name = "level";
            level.Size = new Size(246, 70);
            level.TabIndex = 3;
            level.Text = "LEVEL";
            level.UseVisualStyleBackColor = false;
            level.Click += button4_Click;
            // 
            // location
            // 
            location.BackColor = Color.MediumPurple;
            location.FlatStyle = FlatStyle.Flat;
            location.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            location.Location = new Point(246, 591);
            location.Name = "location";
            location.Size = new Size(246, 70);
            location.TabIndex = 2;
            location.Text = "LOCATION";
            location.UseVisualStyleBackColor = false;
            location.Click += location_Click;
            // 
            // sound
            // 
            sound.BackColor = Color.CadetBlue;
            sound.FlatStyle = FlatStyle.Flat;
            sound.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sound.Location = new Point(0, 591);
            sound.Name = "sound";
            sound.Size = new Size(246, 70);
            sound.TabIndex = 1;
            sound.Text = "SOUND";
            sound.UseVisualStyleBackColor = false;
            sound.Click += sound_Click;
            // 
            // start
            // 
            start.BackColor = Color.Chartreuse;
            start.FlatStyle = FlatStyle.Flat;
            start.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            start.Location = new Point(738, 591);
            start.Name = "start";
            start.Size = new Size(246, 70);
            start.TabIndex = 0;
            start.Text = "START";
            start.UseVisualStyleBackColor = false;
            // 
            // MainMenu02
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 661);
            Controls.Add(panel1);
            Name = "MainMenu02";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Menu";
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button level;
        private Button location;
        private Button sound;
        private Button start;
        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button soundApply;
        private Button SoundBack;
        private GroupBox groupBox2;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}