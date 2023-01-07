using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oop_Form_Homework
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void yenButton_Click(object sender, EventArgs e)
        {
            CharacterForm characterForm = new CharacterForm(new Yennefer());
            characterForm.Show();
        }

        private void geraltButton_Click(object sender, EventArgs e)
        {
            CharacterForm characterForm = new CharacterForm(new Geralt());
            characterForm.Show();
        }

        private void ciriButton_Click(object sender, EventArgs e)
        {
            CharacterForm characterForm = new CharacterForm(new Ciri());
            characterForm.Show();
        }

        private void trissButton_Click(object sender, EventArgs e)
        {
            CharacterForm characterForm = new CharacterForm(new Triss());
            characterForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Width = 700;
            Height = 500;
        }

        private void geraltButton_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox1.Image = Properties.Resources.geralt;
        }

        private void geraltButton_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Visible=false;
        }

        private void ciriButton_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox1.Image = Properties.Resources.ciri;
        }

        private void ciriButton_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
        }

        private void yenButton_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox1.Image = Properties.Resources.yeneffer;
        }

        private void yenButton_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
        }

        private void trissButton_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox1.Image = Properties.Resources.triss;
        }

        private void trissButton_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
        }
    }
}
