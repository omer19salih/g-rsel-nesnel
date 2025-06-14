using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Media;

namespace ödevvv
{
    // Oyun yönetimi için ana sınıf
    public class OyunYoneticisi
    {
        private SesYoneticisi _sesYoneticisi;
        private SurukleBirakYoneticisi _surukleBirakYoneticisi;
        private Form _oyunForm;

        public OyunYoneticisi(Form oyunForm, PictureBox hedefResim, PictureBox sepetResim, Label durumEtiketi)
        {
            _oyunForm = oyunForm;
            _sesYoneticisi = new SesYoneticisi();
            _surukleBirakYoneticisi = new SurukleBirakYoneticisi(hedefResim, sepetResim, durumEtiketi, _sesYoneticisi);
        }

        public void OyunuBaslat()
        {
            _sesYoneticisi.YonlendirmeSesiCal();
        }

        public void FormaDegistir(Form yeniForm)
        {
            yeniForm.Show();
            _oyunForm.Hide();
        }
    }

    // Ses yönetimi için sınıf
    public class SesYoneticisi
    {
        private SoundPlayer _sesYonlendirme;
        private SoundPlayer _sesDogru;
        private SoundPlayer _sesYanlis;

        public SesYoneticisi()
        {
            SesleriYukle();
        }

        private void SesleriYukle()
        {
            try
            {
                _sesYonlendirme = new SoundPlayer(Properties.Resources.yon);
                _sesDogru = new SoundPlayer(Properties.Resources.dogru);
                _sesYanlis = new SoundPlayer(Properties.Resources.yanlıs);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ses dosyaları yüklenirken hata oluştu: " + ex.Message);
            }
        }

        public void YonlendirmeSesiCal()
        {
            try
            {
                _sesYonlendirme?.Play();
            }
            catch { }
        }

        public void DogruSesiCal()
        {
            try
            {
                _sesDogru?.Play();
            }
            catch { }
        }

        public void YanlisSesiCal()
        {
            try
            {
                _sesYanlis?.Play();
            }
            catch { }
        }
    }

    // Sürükle-bırak işlemleri için sınıf
    public class SurukleBirakYoneticisi
    {
        private bool _surukleniyor = false;
        private Point _fareIlkKonum;
        private PictureBox _hedefResim;
        private PictureBox _sepetResim;
        private Label _durumEtiketi;
        private SesYoneticisi _sesYoneticisi;

        public SurukleBirakYoneticisi(PictureBox hedefResim, PictureBox sepetResim, Label durumEtiketi, SesYoneticisi sesYoneticisi)
        {
            _hedefResim = hedefResim;
            _sepetResim = sepetResim;
            _durumEtiketi = durumEtiketi;
            _sesYoneticisi = sesYoneticisi;

            OlaylariAyarla();
        }

        private void OlaylariAyarla()
        {
            _hedefResim.MouseDown += Resim_MouseDown;
            _hedefResim.MouseMove += Resim_MouseMove;
            _hedefResim.MouseUp += Resim_MouseUp;
        }

        private void Resim_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _surukleniyor = true;
                _fareIlkKonum = e.Location;
                _hedefResim.BringToFront();
            }
        }

        private void Resim_MouseMove(object sender, MouseEventArgs e)
        {
            if (_surukleniyor)
            {
                Point yeniPozisyon = _hedefResim.PointToScreen(e.Location);
                yeniPozisyon.Offset(-_fareIlkKonum.X, -_fareIlkKonum.Y);
                yeniPozisyon = _hedefResim.Parent.PointToClient(yeniPozisyon);
                _hedefResim.Location = yeniPozisyon;
                _hedefResim.BringToFront();
            }
        }

        private void Resim_MouseUp(object sender, MouseEventArgs e)
        {
            _surukleniyor = false;
            KontroluDegerlendir();
        }

        private void KontroluDegerlendir()
        {
            if (_hedefResim.Bounds.IntersectsWith(_sepetResim.Bounds))
            {
                DogruBirakma();
            }
            else
            {
                YanlisBirakma();
            }
        }

        private void DogruBirakma()
        {
            _durumEtiketi.Text = "Doğru yere bıraktınız!";
            _durumEtiketi.ForeColor = Color.Green;
            _sesYoneticisi.DogruSesiCal();
        }

        private void YanlisBirakma()
        {
            _durumEtiketi.Text = "Yanlış yere bıraktınız!";
            _durumEtiketi.ForeColor = Color.Red;
            _sesYoneticisi.YanlisSesiCal();
        }
    }
}
