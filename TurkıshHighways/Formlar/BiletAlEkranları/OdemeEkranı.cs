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
using TurkıshHighways.Formlar.BiletAlEkranları;
using static TurkıshHighways.enumlar;

namespace TurkıshHighways.Formlar
{
    public partial class OdemeEkranı : Form
    {
        SqlConnection odemeBağlantı;

        SqlCommand odemeKomut;
        public OdemeEkranı()
        {
            InitializeComponent();
        }
        private void OdemeEkranı_Load(object sender, EventArgs e)
        {
            int toplam = Convert.ToInt32(Convert.ToDecimal(lblFiyatOdeme.Text) * Convert.ToDecimal(lblAdetOdeme.Text));
            txtUcret.Text = toplam.ToString() + " " + "₺";
            cmbUyruk.Items.AddRange(Enum.GetNames(typeof(Uyruklar)));
        }
        private void btnGüvenliÖdeme_Click(object sender, EventArgs e)      
        {
            odemeBağlantı = new SqlConnection(@"Data Source=DESKTOP-R443NGM;Initial Catalog=TurkishHighways;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            

            if (lblSeferTarihiOdeme.Text != default && lblKalkısOdeme.Text != default && lblVarısOdeme.Text != default && lblFiyatOdeme.Text != default && lblAdetOdeme.Text != default &&
                txtMail.Text!="" && mtxtTelefon.Text != "" && txtKartNumarası.Text != "" && cmbAy.Text != "" && cmbYıl.Text != "" && txtCvv2.Text != "" && 
                rdbONSozlesme.Checked!=false && txtUcret.Text != "" && rdbSmsBildirimi.Checked != false )
            {
                odemeBağlantı.Open();
                odemeKomut = new SqlCommand("Insert into Bilet(Ad,Soyad,Email,Telefon,Kimlik,Cinsiyet,Uyruk,Pasaport,KartNo,SonKullanma,GüvenlikNo,SeferTarihi,KalkısYeri,VarısYeri,KoltukNo,Fiyat) Values(@ad,@soyad,@email,@telefon,@kimlik,@cinsiyet,@uyruk,@pasaport,@kartNo,@sonKul,@güvenlikNo,@seferTar,@kalkısYer,@varısYer,@koltukNo,@fiyat)", odemeBağlantı);

                odemeKomut.Parameters.AddWithValue("@ad", txtAd.Text);
                odemeKomut.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                odemeKomut.Parameters.AddWithValue("@email", txtMail.Text);
                odemeKomut.Parameters.AddWithValue("@telefon", mtxtTelefon.Text);
                if(txtKimlik.Text != null)
                {
                    odemeKomut.Parameters.AddWithValue("@kimlik", txtKimlik.Text);
                }
                else
                {
                    txtKimlik.Text = null;
                    odemeKomut.Parameters.AddWithValue("@kimlik", txtKimlik.Text);
                }
                odemeKomut.Parameters.AddWithValue("@cinsiyet", lblOdemeCinsiyet.Text);
                if(cmbUyruk.Text != null && txtPasaport.Text != null)
                {
                    odemeKomut.Parameters.AddWithValue("@uyruk", cmbUyruk.Text);
                    odemeKomut.Parameters.AddWithValue("@pasaport", txtPasaport.Text);
                }
                else
                {
                    cmbUyruk.Text = null;
                    txtPasaport.Text = null;
                    odemeKomut.Parameters.AddWithValue("@uyruk", cmbUyruk.Text);
                    odemeKomut.Parameters.AddWithValue("@pasaport", txtPasaport.Text);
                }

                odemeKomut.Parameters.AddWithValue("@kartNo", txtKartNumarası.Text.Replace(txtKartNumarası.Text.Substring(12,4), "****"));
                odemeKomut.Parameters.AddWithValue("@sonKul", cmbAy.Text+"/"+cmbYıl.Text);
                odemeKomut.Parameters.AddWithValue("@güvenlikNo", txtCvv2.Text);
                odemeKomut.Parameters.AddWithValue("@seferTar", lblSeferTarihiOdeme.Text);
                odemeKomut.Parameters.AddWithValue("@kalkısYer", lblKalkısOdeme.Text);
                odemeKomut.Parameters.AddWithValue("@varısYer", lblVarısOdeme.Text);
                odemeKomut.Parameters.AddWithValue("@koltukNo", lblKoltukNu.Text);
                odemeKomut.Parameters.AddWithValue("@fiyat", lblFiyatOdeme.Text);

                odemeKomut.ExecuteNonQuery();
                odemeBağlantı.Close();

                MessageBox.Show("Bilet satın alma işleminiz başarıyla tamamlanmıştır... İyi yolculuklar dileriz...");
                BiletSecimEkranı biletSecimEkranı = new BiletSecimEkranı();
                biletSecimEkranı.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz !!");
            }
        }

        private void lblCVC2Nedir_Click(object sender, EventArgs e)
        {
            cvv2Nedir cvv2 = new cvv2Nedir();         
            cvv2.Show();           
        }

        private void lblKimlik_Click(object sender, EventArgs e)
        {
            rdbTcVatandasıDegilim.Checked = false;
            txtKimlik.Enabled = true;
            cmbUyruk.Enabled = false;
            txtPasaport.Enabled = false;
        }

        private void rdbTcVatandasıDegilim_CheckedChanged_1(object sender, EventArgs e)
        {
            txtKimlik.Enabled = false;
            cmbUyruk.Enabled = true;
            txtPasaport.Enabled = true;
        }
    }
}
