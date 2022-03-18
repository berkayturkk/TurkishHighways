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
    public partial class AnaMenü : Form
    {
        public AnaMenü()
        {
            InitializeComponent();
        }

        private void biletİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BiletSecimEkranı biletSecimEkranı = new BiletSecimEkranı();         
            biletSecimEkranı.Show();
            
           
        }
    }
}
