using ProdutosMarcas.Dominio.Entities;
using ProdutosMarcas.Repositorio.Comum.Interfaces;
using ProdutosMarcas.Repositorio.EF.Repositories;
using System;
using System.Windows.Forms;

namespace ProdutosMarcas.Apresentacao
{
    public partial class FrmMarca : Form
    {
        private Marca marcaASerAlterada;

        public FrmMarca(Marca marca = null)
        {
            marcaASerAlterada = marca;
            InitializeComponent();
        }

        private void FrmMarca_Load(object sender, EventArgs e)
        {
            if (marcaASerAlterada != null)
            {
                txtNomeMarca.Text = marcaASerAlterada.Nome;
            }
            else
            {
                txtNomeMarca.Text = string.Empty;
            }
        }

        private void btnSalvarMarca_Click(object sender, EventArgs e)
        {
            IRepositorioGenerico<Marca> repositorioMarcas = new RepositorioMarca();
            if (marcaASerAlterada == null)
            {
                Marca novaMarca = new Marca
                {
                    Nome = txtNomeMarca.Text.Trim()
                };
                repositorioMarcas.Inserir(novaMarca);
                MessageBox.Show("Marca cadastrada com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                marcaASerAlterada.Nome = txtNomeMarca.Text.Trim();
                repositorioMarcas.Atualizar(marcaASerAlterada);
                MessageBox.Show("Marca alterada com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Close();
        }

        private void btnLimparMarca_Click(object sender, EventArgs e)
        {
            txtNomeMarca.Clear();
        }

        private void btnFecharMarca_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
