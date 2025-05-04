using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOPFinal.BL;

namespace OOPFinal.UI
{
    public partial class GameForm : Form
    {
        private Player player1;
        Player.State state = Player.State.Normal;
        public static MainMenu02 mainMenu02;
        private bool isLeftPressed = false;
        private bool isRightPressed = false;

        public GameForm(MainMenu02 mainMenu02)
        {
            InitializeComponent();
            GameForm.mainMenu02 = mainMenu02;
            MainMenu02.gameForm = this;

            timer1.Interval = 16;
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainMenu02.Show();
            this.Hide();
        }

        private void Is_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void InitializePlayer()
        {
            player1 = new Player("Player", pictureBox3, state, progressBar1, 10, 5, 5, 5, 10);
        }

        private void gameTimerTick(object sender, EventArgs e)
        {
            player1.HandleJump();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            InitializePlayer();
            Thread.Sleep(2000);
            pictureBox3.Location = new Point(pictureBox3.Location.X + 100, pictureBox3.Location.Y);
        }

        private void Is_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    isLeftPressed = false;
                    break;
                case Keys.Right:
                    isRightPressed = false;
                    break;
            }
        }

        private void Is_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Is_Key_Down(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Space:
                    player1.StartJump();
                    break;
                case Keys.Left:
                    isLeftPressed = true;
                    pictureBox3.Location = new Point(pictureBox3.Location.X - 5, pictureBox3.Location.Y);
                    break;
                case Keys.Right:
                    isRightPressed = true;
                    pictureBox3.Location = new Point(pictureBox3.Location.X + 5, pictureBox3.Location.Y);
                    break;
            }
        }
    }
}
