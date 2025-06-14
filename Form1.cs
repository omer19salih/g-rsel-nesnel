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
using System.IO;

namespace ödevvv
{
    
    public partial class Form1 : Form
    {
        private SesYoneticisi _sesYoneticisi;
        private SurukleBirakYoneticisi _surukleBirakYoneticisi;

        public Form1()
        {
            InitializeComponent();
            OyunuBaslat();
        }

        private void OyunuBaslat()
        {
            // Ses yöneticisini oluştur
            _sesYoneticisi = new SesYoneticisi();

            // Sürükle-bırak yöneticisini oluştur
            _surukleBirakYoneticisi = new SurukleBirakYoneticisi(
                picElma,
                picSepet,
                lblDurum,
                _sesYoneticisi
            );

            // Oyun başladığında yönlendirme sesi çal
            _sesYoneticisi.YonlendirmeSesiCal();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
