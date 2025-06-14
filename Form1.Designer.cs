namespace ödevvv
{
    partial class Form1
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
            this.lblDurum = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.picSepet = new System.Windows.Forms.PictureBox();
            this.picElma = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSepet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picElma)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDurum.Location = new System.Drawing.Point(13, 28);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(44, 16);
            this.lblDurum.TabIndex = 1;
            this.lblDurum.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BackgroundImage = global::ödevvv.Properties.Resources.Ekran_görüntüsü_2025_05_16_005646;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(451, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(311, 269);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::ödevvv.Properties.Resources.reply;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(719, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 40);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // picSepet
            // 
            this.picSepet.BackColor = System.Drawing.SystemColors.Control;
            this.picSepet.BackgroundImage = global::ödevvv.Properties.Resources.WhatsApp_Görsel_2025_05_16_saat_01_01_14_5a4d0bd9;
            this.picSepet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picSepet.Location = new System.Drawing.Point(31, 66);
            this.picSepet.Name = "picSepet";
            this.picSepet.Size = new System.Drawing.Size(328, 269);
            this.picSepet.TabIndex = 2;
            this.picSepet.TabStop = false;
            // 
            // picElma
            // 
            this.picElma.BackgroundImage = global::ödevvv.Properties.Resources.kalp;
            this.picElma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picElma.Location = new System.Drawing.Point(347, 361);
            this.picElma.Name = "picElma";
            this.picElma.Size = new System.Drawing.Size(121, 66);
            this.picElma.TabIndex = 0;
            this.picElma.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picSepet);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.picElma);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSepet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picElma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picElma;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.PictureBox picSepet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

