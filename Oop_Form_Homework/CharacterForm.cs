using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Oop_Form_Homework
{
    public partial class CharacterForm : Form
    {
        private AbstractCharacter character;
        public CharacterForm(AbstractCharacter character)
        {
            InitializeComponent();
            this.character = character;
            nameLabel.Text = character.Name;
            descriptionLabel.Text = character.Description;
            characterPictureBox.Image = Image.FromFile(character.PicturePath);
            this.character = character;
            

            magic.Visible= character is IMage;
            power.Visible = character is IMage;

            
            attackButton.Visible = character is IWitcher;
            signButton.Visible = character is Geralt;
            magicButton.Visible = character is IMage;
            teleportButton.Visible = character is Ciri;
            if (character is IMage mage)
            {
                power.Text = mage.MagicPower;
            }
        }

        private void speakButton_Click(object sender, EventArgs e)
        {
            VideoForm videoForm = new VideoForm(character.SpeakVideoPath);
            videoForm.Show();
        }

        private void attackButton_Click(object sender, EventArgs e)
        {
            if (character is IWitcher witcher)
            {
                VideoForm videoForm = new VideoForm(witcher.AttackVideoPath);
                videoForm.Show();
            }
        }
        

        private void magicButton_Click(object sender, EventArgs e)
        {
            if (character is IMage mage)
            {
                VideoForm videoForm = new VideoForm(mage.UseMagic);
                videoForm.Show();
            }
        }

        private void teleportButton_Click(object sender, EventArgs e)
        {
            if (character is Ciri ciri)
            {
                VideoForm videoForm = new VideoForm(ciri.teleport);
                videoForm.Show();

            }
        }

        private void signButton_Click(object sender, EventArgs e)
        {
            if (character is Geralt geralt)
            {
                VideoForm videoForm = new VideoForm(geralt.UseSignPath);
                videoForm.Show();
            }
        }

        
    }
}
