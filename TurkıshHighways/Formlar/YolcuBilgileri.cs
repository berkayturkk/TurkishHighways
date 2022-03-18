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
    public partial class YolcuBilgileri : Form
    {
        public YolcuBilgileri()
        {
            InitializeComponent();
        }

        private void btnYolcuKaydet_Click(object sender, EventArgs e)
        {
            if (txtAd.Text != "" && txtSoyad.Text != "")
            {
                if (rdbTcVatandasıDegilim.Checked == false)
                {
                    if (txtKimlik.Text != "")
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Lütfen boş alanları doldurunuz !!");
                    }
                }
                else
                {
                    if (cmbUyruk.Text != "" && txtPasaport.Text != "")
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Lütfen boş alanları doldurunuz !!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz !!");
            }
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();        
        }

        private void rdbTcVatandasıDegilim_CheckedChanged(object sender, EventArgs e)
        {
            txtKimlik.Enabled = false;
            cmbUyruk.Enabled = true;
            txtPasaport.Enabled = true;
        }

        private void lblKimlik_Click(object sender, EventArgs e)
        {
            rdbTcVatandasıDegilim.Checked = false;
            txtKimlik.Enabled = true;
            cmbUyruk.Enabled = false;
            txtPasaport.Enabled = false;
        }

        private void YolcuBilgileri_Load(object sender, EventArgs e)
        {
            cmbUyruk.Items.AddRange(Enum.GetNames(typeof(Uyruklar)));
        }
    }
}
