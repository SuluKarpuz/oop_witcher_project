namespace Oop_Form_Homework
{
    partial class CharacterForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.characterPictureBox = new System.Windows.Forms.PictureBox();
            this.magicButton = new System.Windows.Forms.Button();
            this.signButton = new System.Windows.Forms.Button();
            this.speakButton = new System.Windows.Forms.Button();
            this.attackButton = new System.Windows.Forms.Button();
            this.teleportButton = new System.Windows.Forms.Button();
            this.magic = new System.Windows.Forms.Label();
            this.power = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.characterPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nameLabel.Location = new System.Drawing.Point(198, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(158, 55);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "label1";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Rockwell", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(653, 94);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(125, 42);
            this.descriptionLabel.TabIndex = 1;
            this.descriptionLabel.Text = "label2";
            // 
            // characterPictureBox
            // 
            this.characterPictureBox.Location = new System.Drawing.Point(208, 84);
            this.characterPictureBox.Name = "characterPictureBox";
            this.characterPictureBox.Size = new System.Drawing.Size(367, 574);
            this.characterPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.characterPictureBox.TabIndex = 2;
            this.characterPictureBox.TabStop = false;
            // 
            // magicButton
            // 
            this.magicButton.Location = new System.Drawing.Point(936, 588);
            this.magicButton.Name = "magicButton";
            this.magicButton.Size = new System.Drawing.Size(177, 70);
            this.magicButton.TabIndex = 3;
            this.magicButton.Text = "Use Magic";
            this.magicButton.UseVisualStyleBackColor = true;
            this.magicButton.Visible = false;
            this.magicButton.Click += new System.EventHandler(this.magicButton_Click);
            // 
            // signButton
            // 
            this.signButton.Location = new System.Drawing.Point(660, 588);
            this.signButton.Name = "signButton";
            this.signButton.Size = new System.Drawing.Size(177, 70);
            this.signButton.TabIndex = 3;
            this.signButton.Text = "Use Sign";
            this.signButton.UseVisualStyleBackColor = true;
            this.signButton.Visible = false;
            this.signButton.Click += new System.EventHandler(this.signButton_Click);
            // 
            // speakButton
            // 
            this.speakButton.Location = new System.Drawing.Point(660, 429);
            this.speakButton.Name = "speakButton";
            this.speakButton.Size = new System.Drawing.Size(177, 70);
            this.speakButton.TabIndex = 3;
            this.speakButton.Text = "Speak";
            this.speakButton.UseVisualStyleBackColor = true;
            this.speakButton.Click += new System.EventHandler(this.speakButton_Click);
            // 
            // attackButton
            // 
            this.attackButton.Location = new System.Drawing.Point(938, 429);
            this.attackButton.Name = "attackButton";
            this.attackButton.Size = new System.Drawing.Size(175, 70);
            this.attackButton.TabIndex = 3;
            this.attackButton.Text = "Attack";
            this.attackButton.UseVisualStyleBackColor = true;
            this.attackButton.Visible = false;
            this.attackButton.Click += new System.EventHandler(this.attackButton_Click);
            // 
            // teleportButton
            // 
            this.teleportButton.Location = new System.Drawing.Point(660, 277);
            this.teleportButton.Name = "teleportButton";
            this.teleportButton.Size = new System.Drawing.Size(175, 79);
            this.teleportButton.TabIndex = 3;
            this.teleportButton.Text = "teleport";
            this.teleportButton.UseVisualStyleBackColor = true;
            this.teleportButton.Visible = false;
            this.teleportButton.Click += new System.EventHandler(this.teleportButton_Click);
            // 
            // magic
            // 
            this.magic.AutoSize = true;
            this.magic.Location = new System.Drawing.Point(929, 207);
            this.magic.Name = "magic";
            this.magic.Size = new System.Drawing.Size(210, 37);
            this.magic.TabIndex = 4;
            this.magic.Text = "Magic Power ";
            // 
            // power
            // 
            this.power.AutoSize = true;
            this.power.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.power.Location = new System.Drawing.Point(978, 263);
            this.power.Name = "power";
            this.power.Size = new System.Drawing.Size(89, 37);
            this.power.TabIndex = 5;
            this.power.Text = "label";
            // 
            // CharacterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1384, 782);
            this.Controls.Add(this.power);
            this.Controls.Add(this.magic);
            this.Controls.Add(this.attackButton);
            this.Controls.Add(this.teleportButton);
            this.Controls.Add(this.signButton);
            this.Controls.Add(this.speakButton);
            this.Controls.Add(this.magicButton);
            this.Controls.Add(this.characterPictureBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.nameLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "CharacterForm";
            this.Text = "CharacterForm";
            ((System.ComponentModel.ISupportInitialize)(this.characterPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.PictureBox characterPictureBox;
        private System.Windows.Forms.Button magicButton;
        private System.Windows.Forms.Button signButton;
        private System.Windows.Forms.Button attackButton;
        private System.Windows.Forms.Button teleportButton;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Button speakButton;
        private System.Windows.Forms.Label magic;
        private System.Windows.Forms.Label power;
    }
}