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
    public partial class VideoForm : Form
    {
        public VideoForm(string videoPath)
        {
            InitializeComponent();
            axWindowsMediaPlayer1.URL = videoPath;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void VideoForm_Load(object sender, EventArgs e)
        {
            Height = 1000;
            Width = 1200;
        }
    }
}
