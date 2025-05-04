namespace OOPFinal.UI
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            panel1 = new Panel();
            round = new Label();
            button1 = new Button();
            start = new Button();
            enemy = new Label();
            player = new Label();
            label1 = new Label();
            progressBar2 = new ProgressBar();
            progressBar1 = new ProgressBar();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(round);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(start);
            panel1.Controls.Add(enemy);
            panel1.Controls.Add(player);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(progressBar2);
            panel1.Controls.Add(progressBar1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(984, 661);
            panel1.TabIndex = 0;
            // 
            // round
            // 
            round.AutoSize = true;
            round.BackColor = Color.Black;
            round.Font = new Font("Showcard Gothic", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            round.ForeColor = Color.Goldenrod;
            round.Location = new Point(324, 582);
            round.Name = "round";
            round.Size = new Size(332, 79);
            round.TabIndex = 7;
            round.Text = "ROUND 01";
            // 
            // button1
            // 
            button1.BackColor = Color.CadetBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(0, 579);
            button1.Name = "button1";
            button1.Size = new Size(246, 82);
            button1.TabIndex = 6;
            button1.Text = "MAIN MENU";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // start
            // 
            start.BackColor = Color.Chartreuse;
            start.FlatStyle = FlatStyle.Flat;
            start.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            start.Location = new Point(738, 579);
            start.Name = "start";
            start.Size = new Size(246, 82);
            start.TabIndex = 2;
            start.Text = "PAUSE";
            start.UseVisualStyleBackColor = false;
            // 
            // enemy
            // 
            enemy.AutoSize = true;
            enemy.BackColor = Color.Black;
            enemy.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            enemy.ForeColor = SystemColors.ControlLight;
            enemy.Location = new Point(767, 4);
            enemy.Name = "enemy";
            enemy.Size = new Size(131, 45);
            enemy.TabIndex = 5;
            enemy.Text = "Enemy2";
            // 
            // player
            // 
            player.AutoSize = true;
            player.BackColor = Color.Black;
            player.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            player.ForeColor = SystemColors.ControlLight;
            player.Location = new Point(87, 5);
            player.Name = "player";
            player.Size = new Size(105, 45);
            player.TabIndex = 0;
            player.Text = "Player";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.OrangeRed;
            label1.Font = new Font("Showcard Gothic", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Goldenrod;
            label1.Location = new Point(443, -4);
            label1.Name = "label1";
            label1.Size = new Size(104, 79);
            label1.TabIndex = 4;
            label1.Text = "99";
            // 
            // progressBar2
            // 
            progressBar2.ForeColor = Color.LimeGreen;
            progressBar2.Location = new Point(545, 53);
            progressBar2.Name = "progressBar2";
            progressBar2.RightToLeft = RightToLeft.Yes;
            progressBar2.Size = new Size(353, 22);
            progressBar2.TabIndex = 3;
            progressBar2.Value = 100;
            // 
            // progressBar1
            // 
            progressBar1.ForeColor = Color.LimeGreen;
            progressBar1.Location = new Point(87, 53);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(359, 22);
            progressBar1.TabIndex = 0;
            progressBar1.Value = 100;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ActiveBorder;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(899, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(85, 77);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveBorder;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(85, 77);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(pictureBox3);
            panel2.Location = new Point(0, 76);
            panel2.Name = "panel2";
            panel2.Size = new Size(984, 504);
            panel2.TabIndex = 0;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(671, 297);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(100, 152);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(197, 297);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 152);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += gameTimerTick;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 661);
            Controls.Add(panel1);
            Name = "GameForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GameForm";
            Load += Game_Load;
            KeyDown += Is_Key_Down;
            KeyPress += Is_KeyPress;
            KeyUp += Is_KeyUp;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private ProgressBar progressBar2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label enemy;
        private Label player;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Button button1;
        private Button start;
        private Label round;
    }
}