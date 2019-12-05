using System;
using System.Windows.Forms;

namespace ProdutosMarcas.Apresentacao
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value = progressBar1.Value + 2;
            }
            else
            {
                timer1.Enabled = false;
                FrmProdutosMarcas frmProdutosMarcas = new FrmProdutosMarcas();
                frmProdutosMarcas.Show();
                Visible = false;
            }
        }
    }
}
