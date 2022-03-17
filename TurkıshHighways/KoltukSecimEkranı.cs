using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurkıshHighways
{
    public partial class KoltukSecimEkranı : Form
    {
        public KoltukSecimEkranı()
        {
            InitializeComponent();
        }

        private void btnKoltuk1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string koltukNo = btn.Text;

            if (rdbBay.Checked == true || rdbBayan.Checked == true)
            {
                btn.BackColor = Color.ForestGreen;
            }
            else if (rdbBayan.Checked == false && rdbBay.Checked == false)
            {
                MessageBox.Show("Lütfen önce cinsiyet seçiniz, daha sonra koltuk seçiniz !!");
            }


        }

        private void btnSecimiIptalEt_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.BackColor == Color.ForestGreen)
            {
                btn.BackColor = Color.LightGray;
            }
        }

        private void btnKoltukEkle_Click(object sender, EventArgs e)
        {         

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
            rdbBay.Checked = false;   // Her koltuk seçiminden sonra cinsiyet seçimindeki bay seçiminin temizlenmesi sağlandı.
            rdbBayan.Checked = false;  // Her koltuk seçiminden sonra cinsiyet seçimindeki bayan seçiminin temizlenmesi sağlandı.
        }
    }
}
