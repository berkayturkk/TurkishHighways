using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurkıshHighways.Formlar
{
    public partial class SeferListesi : Form
    {
        SqlConnection seferBağlantı;

        SqlDataAdapter seferDa;

        public SeferListesi()
        {
            InitializeComponent();
        }
        public void SeferGöster()
        {
            seferBağlantı = new SqlConnection("server=.;Initial Catalog=TurkTurizm;Integrated Security=SSPI");
            seferBağlantı.Open();
            if (lblKalkısYeri.Text == "İstanbul" && lblVarısYeri.Text == "Sakarya")
            {
                seferDa = new SqlDataAdapter("SELECT*FROM IstanbulSakaryaSeferListesi", seferBağlantı);
            }
            else if (lblKalkısYeri.Text == "İstanbul" && lblVarısYeri.Text == "Düzce")
            {
                seferDa = new SqlDataAdapter("SELECT*FROM IstanbulDüzceSeferListesi", seferBağlantı);
            }
            else if (lblKalkısYeri.Text == "İstanbul" && lblVarısYeri.Text == "Kocaeli")
            {
                seferDa = new SqlDataAdapter("SELECT*FROM IstanbulKocaeliSeferListesi", seferBağlantı);
            }


            DataTable seferTablo = new DataTable();
            seferDa.Fill(seferTablo);
            dataGridViewSefer.DataSource = seferTablo;
            seferBağlantı.Close();
        }
        private void SeferListesi_Load(object sender, EventArgs e)
        {
            SeferGöster();
        }

        private void btnSeferSec_Click(object sender, EventArgs e)
        {
            KoltukSecimEkranı koltukSecimEkranı = new KoltukSecimEkranı();            
            koltukSecimEkranı.Show();
            this.Hide();
        }

     
    }
}
