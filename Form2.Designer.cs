namespace ödevvv
{
    partial class Form2
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
            this.picMuz = new System.Windows.Forms.PictureBox();
            this.picSepet = new System.Windows.Forms.PictureBox();
            this.picElma = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMuz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSepet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picElma)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(12, 18);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(44, 16);
            this.lblDurum.TabIndex = 2;
            this.lblDurum.Text = "label1";
            // 
            // picMuz
            // 
            this.picMuz.BackgroundImage = global::ödevvv.Properties.Resources.indir_removebg_preview;
            this.picMuz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picMuz.Location = new System.Drawing.Point(431, 324);
            this.picMuz.Name = "picMuz";
            this.picMuz.Size = new System.Drawing.Size(108, 70);
            this.picMuz.TabIndex = 3;
            this.picMuz.TabStop = false;
            // 
            // picSepet
            // 
            this.picSepet.BackColor = System.Drawing.Color.Transparent;
            this.picSepet.BackgroundImage = global::ödevvv.Properties.Resources.images;
            this.picSepet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picSepet.Location = new System.Drawing.Point(201, 58);
            this.picSepet.Name = "picSepet";
            this.picSepet.Size = new System.Drawing.Size(338, 228);
            this.picSepet.TabIndex = 1;
            this.picSepet.TabStop = false;
            // 
            // picElma
            // 
            this.picElma.BackgroundImage = global::ödevvv.Properties.Resources.kalp;
            this.picElma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picElma.Location = new System.Drawing.Point(201, 324);
            this.picElma.Name = "picElma";
            this.picElma.Size = new System.Drawing.Size(107, 60);
            this.picElma.TabIndex = 0;
            this.picElma.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picMuz);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.picSepet);
            this.Controls.Add(this.picElma);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.picMuz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSepet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picElma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picElma;
        private System.Windows.Forms.PictureBox picSepet;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.PictureBox picMuz;
    }
}