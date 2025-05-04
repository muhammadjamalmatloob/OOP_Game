using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPFinal.UI
{
    public partial class GameForm : Form
    {
        public static MainMenu02 mainMenu02;
        public GameForm(MainMenu02 mainMenu02)
        {
            InitializeComponent();
            GameForm.mainMenu02 = mainMenu02;
            MainMenu02.gameForm = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainMenu02.Show();
            this.Hide();
        }
    }
}
