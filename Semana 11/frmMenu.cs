using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana_11
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //instanciamos al formulario
            frmtest frm = new frmtest();
            frm.MdiParent = this; //definir formulario padre
            frm.Show(); // mostrar formulario
        }

        private void mascotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmmascota fmr = new frmmascota();

            fmr.MdiParent = this;
            fmr.Show();
        }
    }
}
