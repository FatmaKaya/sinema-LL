using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Salon s1 = new Salon();
        private void lblKoltukAl_Click(object sender, EventArgs e)
        {
            if (txtAdSoyad.Text == "" || txtKoltukNo.Text == "")
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız!.");
            }
            else if (Convert.ToInt32(txtKoltukNo.Text) < 0 || Convert.ToInt32(txtKoltukNo.Text) > 60)
            {
                MessageBox.Show("Lütfen 1-60 arası koltuk seçiniz!.");
                txtKoltukNo.Text = "";
            }
            else
            {

                Koltuk YeniKoltuk = new Koltuk();
                YeniKoltuk.KoltuktakiKisiAdSoyad = txtAdSoyad.Text.ToUpper();
                YeniKoltuk.KoltukNo = Convert.ToInt32(txtKoltukNo.Text);
                YeniKoltuk.KoltukDurumu = true;

                MessageBox.Show(s1.Koltuklar.InsertPos(YeniKoltuk.KoltukNo, YeniKoltuk));
                txtAdSoyad.Text = "";
                txtKoltukNo.Text = "";
                MessageBox.Show(s1.Koltuklar.DisplayElements());
            }
    
        }

        private void btnKoltukDegistir_Click(object sender, EventArgs e)
        {
            if (txtAdSoyad.Text == "" || txtKoltukNo.Text == "")
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız!.");
            }
            else if (Convert.ToInt32(txtKoltukNo.Text) < 0 || Convert.ToInt32(txtKoltukNo.Text) > 60)
            {
                MessageBox.Show("Lütfen 1-60 arası koltuk seçiniz!.");
                txtKoltukNo.Text = "";
            }
            else
            {

                Koltuk koltukIptal = new Koltuk();
                koltukIptal.KoltuktakiKisiAdSoyad = txtAdSoyad.Text.ToUpper();
                koltukIptal.KoltukNo = Convert.ToInt32(txtKoltukNo.Text);
                koltukIptal.KoltukDurumu = true;

                MessageBox.Show(s1.Koltuklar.DeletePos(koltukIptal.KoltukNo, koltukIptal));
                txtAdSoyad.Text = "";
                txtKoltukNo.Text = "";
                MessageBox.Show(s1.Koltuklar.DisplayElements());
            }

        }
        private void btnKoltukOgren_Click(object sender, EventArgs e)
        {
            
            if (txtAdSoyad.Text == "")
            {
                MessageBox.Show("Lütfen Ad Soyad alanını boş bırakmayınız!.");
            }
            else
            {
                Koltuk arananKoltuk = new Koltuk();
                Koltuk ak = new Koltuk();
                arananKoltuk.KoltuktakiKisiAdSoyad = txtAdSoyad.Text.ToUpper();
                ak=s1.Koltuklar.GetElement(arananKoltuk);
                MessageBox.Show("" + ak.KoltuktakiKisiAdSoyad + "  kişisi " + ak.KoltukNo + " numaralı koltukta oturuyor.");
            }

        }
        private void btnKoltukDurumları_Click(object sender, EventArgs e)
        {
            MessageBox.Show(s1.Koltuklar.DisplayElements());
        }
    }
}
