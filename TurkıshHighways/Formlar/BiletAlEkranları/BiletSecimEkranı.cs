using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TurkıshHighways.enumlar;

namespace TurkıshHighways.Formlar
{
    public partial class BiletSecimEkranı : Form
    {
        public BiletSecimEkranı()
        {
            InitializeComponent();
        }
        private void BiletSecimEkranı_Load(object sender, EventArgs e)
        {
            // Nereden ve Nereye comboboxlarına enum tiplerinde tanımladığımız sehirler enumlarını eklenmesi sağlandı.

            cmbNereden.Items.AddRange(Enum.GetNames(typeof(SeferSehirleri)));
            cmbNereye.Items.AddRange(Enum.GetNames(typeof(SeferSehirleri)));
        }
        private void btnSeferleriGöster_Click(object sender, EventArgs e)
        {           
         string gds = dtmpGidisTarihi.Value.ToShortDateString();  
         DateTime gidis = Convert.ToDateTime(gds);
         string bgn = DateTime.Now.ToShortDateString();
         DateTime bugün = Convert.ToDateTime(bgn);

            if (cmbNereden.Text != "" && cmbNereye.Text != "" && cmbNereden.Text != cmbNereye.Text)
            {
                 if (gidis >= bugün)
                 {
                     SeferListesi seferListesi = new SeferListesi();
                     seferListesi.lblKalkısYeri.Text = cmbNereden.Text;
                     seferListesi.lblVarısYeri.Text = cmbNereye.Text;
                     seferListesi.lblGidisTarihi.Text = dtmpGidisTarihi.Value.ToShortDateString();                     
                     seferListesi.Show();
                     this.Hide();                                         
                 }
                // Gidiş tarihinin bugünden erken olması engellendi.
                 else
                 {
                     MessageBox.Show("Gidiş tarihi bugünden önceki bir tarih olamaz. Lütfen gidiş tarihinizi kontrol ediniz !!");
                 }
            }
            else
            {
                MessageBox.Show("Güzergah seçiminde hatalı giriş yapıldı.Lütfen güzergahınızı kontrol ediniz!!");
            }
        }
    }
}
