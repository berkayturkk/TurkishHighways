using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TurkıshHighways.Formlar.BiletAlEkranları;

namespace TurkıshHighways.Formlar
{
    public partial class OdemeEkranı : Form
    {
        public OdemeEkranı()
        {
            InitializeComponent();
        }
        private void OdemeEkranı_Load(object sender, EventArgs e)
        {
            int toplam = Convert.ToInt32(Convert.ToDecimal(lblFiyatOdeme.Text) * Convert.ToDecimal(lblAdetOdeme.Text));
            txtUcret.Text = toplam.ToString() + " " + "₺";
        }
        private void btnGüvenliÖdeme_Click(object sender, EventArgs e)      
        {
            if (lblSeferTarihiOdeme.Text != default && lblKalkısOdeme.Text != default && lblVarısOdeme.Text != default && lblFiyatOdeme.Text != default && lblAdetOdeme.Text != default &&
                txtMail.Text!="" && mtxtTelefon.Text != "" && txtKartNumarası.Text != "" && cmbAy.Text != "" && cmbYıl.Text != "" && txtCvv2.Text != "" && 
                rdbONSozlesme.Checked==false && txtUcret.Text != "" )
            {
                MessageBox.Show("Bilet satın alma işleminiz başarıyla tamamlanmıştır... İyi yolculuklar dileriz...");
                BiletFisi biletFisi = new BiletFisi();
                biletFisi.Show();
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
        
    }
}
