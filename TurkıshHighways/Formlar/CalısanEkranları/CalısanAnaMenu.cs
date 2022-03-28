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
    public partial class CalısanAnaMenü : Form
    {

        public CalısanAnaMenü()
        {
            InitializeComponent();
        }





        private void biletAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BiletSecimEkranı biletSecimEkranı = new BiletSecimEkranı();
            biletSecimEkranı.Show();
            this.Hide();
        }


    }
}
