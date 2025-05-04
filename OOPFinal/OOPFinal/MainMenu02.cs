using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPFinal
{
    public partial class MainMenu02 : Form
    {
        public MainMenu02()
        {
            InitializeComponent();
            radioButton1.Checked = true;
            radioButton3.Checked = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void soundApply_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Settings.SetSound(true);
            }
            else
            {
                Settings.SetSound(false);
            }
            MessageBox.Show("Changes applied successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void sound_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void SoundBack_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.BorderStyle = BorderStyle.None;
            pictureBox3.BorderStyle = BorderStyle.None;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.None;
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox3.BorderStyle = BorderStyle.None;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.None;
            pictureBox2.BorderStyle = BorderStyle.None;
            pictureBox3.BorderStyle = BorderStyle.Fixed3D;
        }

        private void location_Click(object sender, EventArgs e)
        {
            if (Settings.getTheme() == 2)
            {
                pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            }
            else if (Settings.getTheme() == 3)
            {
                pictureBox3.BorderStyle = BorderStyle.Fixed3D;
            }
            else
            {
                pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            }
            groupBox2.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.BorderStyle == BorderStyle.Fixed3D)
            {
                Settings.SetTheme(1);
            }
            else if (pictureBox2.BorderStyle == BorderStyle.Fixed3D)
            {
                Settings.SetTheme(2);
            }
            else
            {
                Settings.SetTheme(2);
            }
            MessageBox.Show("Changes applied successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                Settings.SetLevel(1);
            }
            else if (radioButton4.Checked)
            {
                Settings.SetLevel(2);
            }
            else if (radioButton5.Checked)
            {
                Settings.SetLevel(3);
            }
            MessageBox.Show("Changes applied successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
        }
    }
}
