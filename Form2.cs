using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ödevvv
{
    using System.Media;

    public partial class Form2 : Form
    {
        private PictureBox seciliNesne = null;

        private SoundPlayer sesYonlendirme;
        private SoundPlayer sesDogru;
        private SoundPlayer sesYanlis;

        public Form2()
        {
            InitializeComponent();

            // Sesleri resource'dan yükle
            sesYonlendirme = new SoundPlayer(Properties.Resources.yon);
            sesDogru = new SoundPlayer(Properties.Resources.dogru);
            sesYanlis = new SoundPlayer(Properties.Resources.yanlıs);

            // Sesli yönlendirme başta oynatılır
            sesYonlendirme.Play();

            // Event bağlama
            picElma.Click += NesneSec;
            picMuz.Click += NesneSec;
            picSepet.Click += HedefTiklandi;
        }

        private void NesneSec(object sender, EventArgs e)
        {
            if (seciliNesne != null)
            {
                seciliNesne.BorderStyle = BorderStyle.None;
                seciliNesne.BackColor = Color.Transparent;
            }

            seciliNesne = sender as PictureBox;

            seciliNesne.BorderStyle = BorderStyle.FixedSingle;
            seciliNesne.BackColor = Color.LightGreen;
        }

        private void HedefTiklandi(object sender, EventArgs e)
        {
            if (seciliNesne == null)
            {
                lblDurum.Text = "Lütfen önce bir nesne seçin!";
                lblDurum.ForeColor = Color.Red;
                return;
            }

            PictureBox hedef = sender as PictureBox;

            if (seciliNesne == picElma && hedef == picSepet)
            {
                lblDurum.Text = "Doğru yere bıraktınız!";
                lblDurum.ForeColor = Color.Green;
                sesDogru.Play();

                seciliNesne.Location = hedef.Location;
                seciliNesne.BorderStyle = BorderStyle.None;
                seciliNesne.BackColor = Color.Transparent;
                seciliNesne = null;
            }
            else
            {
                lblDurum.Text = "Yanlış yere bıraktınız!";
                lblDurum.ForeColor = Color.Red;
                sesYanlis.Play();
            }
        }
    }

}
