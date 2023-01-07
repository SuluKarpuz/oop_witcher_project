namespace Oop_Form_Homework
{
    partial class MainForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.geraltButton = new System.Windows.Forms.Button();
            this.ciriButton = new System.Windows.Forms.Button();
            this.yenButton = new System.Windows.Forms.Button();
            this.trissButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // geraltButton
            // 
            resources.ApplyResources(this.geraltButton, "geraltButton");
            this.geraltButton.Name = "geraltButton";
            this.geraltButton.UseVisualStyleBackColor = true;
            this.geraltButton.Click += new System.EventHandler(this.geraltButton_Click);
            this.geraltButton.MouseEnter += new System.EventHandler(this.geraltButton_MouseEnter);
            this.geraltButton.MouseLeave += new System.EventHandler(this.geraltButton_MouseLeave);
            // 
            // ciriButton
            // 
            resources.ApplyResources(this.ciriButton, "ciriButton");
            this.ciriButton.Name = "ciriButton";
            this.ciriButton.UseVisualStyleBackColor = true;
            this.ciriButton.Click += new System.EventHandler(this.ciriButton_Click);
            this.ciriButton.MouseEnter += new System.EventHandler(this.ciriButton_MouseEnter);
            this.ciriButton.MouseLeave += new System.EventHandler(this.ciriButton_MouseLeave);
            // 
            // yenButton
            // 
            resources.ApplyResources(this.yenButton, "yenButton");
            this.yenButton.Name = "yenButton";
            this.yenButton.UseVisualStyleBackColor = true;
            this.yenButton.Click += new System.EventHandler(this.yenButton_Click);
            this.yenButton.MouseEnter += new System.EventHandler(this.yenButton_MouseEnter);
            this.yenButton.MouseLeave += new System.EventHandler(this.yenButton_MouseLeave);
            // 
            // trissButton
            // 
            resources.ApplyResources(this.trissButton, "trissButton");
            this.trissButton.Name = "trissButton";
            this.trissButton.UseVisualStyleBackColor = true;
            this.trissButton.Click += new System.EventHandler(this.trissButton_Click);
            this.trissButton.MouseEnter += new System.EventHandler(this.trissButton_MouseEnter);
            this.trissButton.MouseLeave += new System.EventHandler(this.trissButton_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Oop_Form_Homework.Properties.Resources.triss;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.trissButton);
            this.Controls.Add(this.yenButton);
            this.Controls.Add(this.ciriButton);
            this.Controls.Add(this.geraltButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button geraltButton;
        private System.Windows.Forms.Button ciriButton;
        private System.Windows.Forms.Button yenButton;
        private System.Windows.Forms.Button trissButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

