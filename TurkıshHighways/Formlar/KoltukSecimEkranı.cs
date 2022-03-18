using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TurkıshHighways.Formlar;

namespace TurkıshHighways
{
    public partial class KoltukSecimEkranı : Form
    {

        Button btn;  // Buton tanımlaması yapıldı.

        public KoltukSecimEkranı()
        {
            InitializeComponent();
        } 

        private void btnKoltuk1_Click(object sender, EventArgs e)
        {
            btn = sender as Button; 

            // Seçilen butonun rengi yeşil olması ve böylece seçildiği anlaşılması sağlandı.

            if (rdbBay.Checked == true || rdbBayan.Checked == true)
            {                
                YolcuBilgileri yolcu = new YolcuBilgileri();
               
                yolcu.ShowDialog();

                if (yolcu.DialogResult == DialogResult.OK)
                {
                    btn.BackColor = Color.ForestGreen;
                }
                else if (yolcu.DialogResult == DialogResult.Cancel)
                {
                    btn.BackColor = Color.LightGray;
                    rdbBayan.Checked = false;
                    rdbBay.Checked = false;
                }
            }
            else if (rdbBayan.Checked == false && rdbBay.Checked == false)
            {
                MessageBox.Show("Lütfen önce cinsiyet seçiniz, daha sonra koltuk seçiniz !!");
            }
        }

        private void btnSecimiIptalEt_Click(object sender, EventArgs e)
        {
            if (btn.BackColor == Color.ForestGreen)
            {
                btn.BackColor = Color.LightGray;
            }
        }

        private void btnKoltukEkle_Click(object sender, EventArgs e)
        {  
            // Seçilen buton kaydedilerek enabled ı false olarak tekrar seçim yapılmasının önüne geçildi ve cinsiyete göre rengi belirlendi.
            if (lbSecilenKoltuklar.Items.Contains(btn.Text + "-" + "Bayan") == false && lbSecilenKoltuklar.Items.Contains(btn.Text + "-" + "Bay") == false && btn.BackColor == Color.ForestGreen)
            {
                lbSecilenKoltuklar.Items.Add(btn.Text + "-" + (rdbBayan.Checked == true ? "Bayan" : "Bay"));
                if (rdbBayan.Checked == true)
                {
                    btn.BackColor = Color.PaleVioletRed;
                }
                else if (rdbBay.Checked == true)
                {
                    btn.BackColor = Color.CornflowerBlue;
                }
                btn.Enabled = false;
            }
            else
            {
                MessageBox.Show("Aynı koltuktan birden fazla işlem yapılamaz. Lütfen boş bir koltuk seçiniz!!");
            }


            rdbBay.Checked = false;   // Her koltuk seçiminden sonra cinsiyet seçimindeki bay seçiminin temizlenmesi sağlandı.
            rdbBayan.Checked = false;  // Her koltuk seçiminden sonra cinsiyet seçimindeki bayan seçiminin temizlenmesi sağlandı.
        }

        private void btnKoltukSil_Click(object sender, EventArgs e)
        {
            
         
            lbSecilenKoltuklar.Items.Remove(lbSecilenKoltuklar.SelectedItem);
        }

        private void btnOnaylaDevamEt_Click(object sender, EventArgs e)
        { 
            OdemeEkranı odemeEkranı = new OdemeEkranı();

            for (int i = 0; i < lbSecilenKoltuklar.Items.Count; i++)
            {
                odemeEkranı.lblKoltukk.Text = Convert.ToString(lbSecilenKoltuklar.Items[i]);
            }
            odemeEkranı.Show();
            this.Hide();

        }
    }
}
