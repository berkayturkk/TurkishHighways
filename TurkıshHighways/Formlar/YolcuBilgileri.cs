using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void rdbBayan_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbBay_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
