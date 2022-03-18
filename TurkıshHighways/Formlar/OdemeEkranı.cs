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
    public partial class OdemeEkranı : Form
    {
        public OdemeEkranı()
        {
            InitializeComponent();
        }

        private void OdemeEkranı_Load(object sender, EventArgs e)
        {
           
        }
        private void btnGüvenliÖdeme_Click(object sender, EventArgs e)
        {

        }

        private void lblCVC2Nedir_Click(object sender, EventArgs e)
        {
            cvv2Nedir cvv2 = new cvv2Nedir();
            
            
            cvv2.Show();
            
        }

        private void grpSeferBilgileri_Enter(object sender, EventArgs e)
        {

        }
    }
}
