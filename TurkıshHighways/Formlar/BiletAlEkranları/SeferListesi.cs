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
            seferBağlantı = new SqlConnection(@"Data Source=DESKTOP-R443NGM;Initial Catalog=TurkishHighways;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
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

        private void dataGridViewSefer_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            KoltukSecimEkranı koltukSecimEkranı = new KoltukSecimEkranı();
            koltukSecimEkranı.sefer = lblGidisTarihi.Text;
            koltukSecimEkranı.kalkıs = dataGridViewSefer.CurrentRow.Cells[1].Value.ToString()+" "+"-"+" "+ dataGridViewSefer.CurrentRow.Cells[2].Value.ToString();
            koltukSecimEkranı.varıs = dataGridViewSefer.CurrentRow.Cells[3].Value.ToString() + " " + "-" + " " + dataGridViewSefer.CurrentRow.Cells[4].Value.ToString();
            koltukSecimEkranı.fiyat = Convert.ToInt32(Convert.ToDecimal(dataGridViewSefer.CurrentRow.Cells[7].Value.ToString()));
            koltukSecimEkranı.Show();
            this.Hide();
        }
    }
}
