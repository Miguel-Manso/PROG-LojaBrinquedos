using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrinquedosLegais
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void tstMenuVizualizacao_Click(object sender, EventArgs e)
        {
            Vizualizacao frm =  new Vizualizacao();
            frm.ShowDialog();
        }

        private void tstMenuCadBrinquedo_Click(object sender, EventArgs e)
        {
            Brinquedos frm = new Brinquedos();
            frm.ShowDialog();
        }

        private void btnBrinquedo_Click(object sender, EventArgs e)
        {
            tstMenuCadBrinquedo.PerformClick();
        }

        private void btnVizualizacao_Click(object sender, EventArgs e)
        {
            tstMenuVizualizacao.PerformClick();
        }
    }
}
