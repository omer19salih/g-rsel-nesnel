using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace ödevvv
{
    public partial class Form3 : Form
    {
        private Timer timer1;
        private ProgressBar progressBar1;
        private PictureBox pictureBox1;
        private SoundPlayer sesYonlendirme;
        public Form3()
        {
            InitializeComponent();
            InitializeCustomComponents();
         
            
        }

        private void InitializeCustomComponents()
        {
            // Form ayarları
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(400, 300);

            // PictureBox oluşturma
            pictureBox1 = new PictureBox();
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.Location = new Point(150, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Properties.Resources.kalp; // Resources'a bir loading resmi eklemelisiniz
            this.Controls.Add(pictureBox1);

            // ProgressBar oluşturma
            progressBar1 = new ProgressBar();
            progressBar1.Size = new Size(300, 23);
            progressBar1.Location = new Point(50, 200);
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;
            this.Controls.Add(progressBar1);

            // Timer oluşturma
            timer1 = new Timer();
            timer1.Interval = 50;
            timer1.Tick += Timer1_Tick;

            // Ses dosyası ayarlama
            try
            {
                sesYonlendirme = new SoundPlayer(Properties.Resources.yon); // loading.wav dosyasını projeye eklemelisiniz
                sesYonlendirme.Load();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ses dosyası yüklenemedi: " + ex.Message);
            }

            // Timer'ı başlat
            timer1.Start();
            try
            {
                sesYonlendirme.Play();
            }
            catch { }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 1;

            if (progressBar1.Value >= 100)
            {
                timer1.Stop();
                try
                {
                    sesYonlendirme.Stop();
                }
                catch { }

                // Form1'e geçiş
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
        }
    }
}
