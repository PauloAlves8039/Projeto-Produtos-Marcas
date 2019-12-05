using ProdutosMarcas.Apresentacao.ViewModels;
using ProdutosMarcas.Dominio.Entities;
using ProdutosMarcas.Repositorio.Comum.Interfaces;
using ProdutosMarcas.Repositorio.EF.Repositories;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProdutosMarcas.Apresentacao
{
    public partial class FrmProduto : Form
    {
        private Produto produtoASerAlterado;

        public FrmProduto(Produto produto = null)
        {
            produtoASerAlterado = produto;
            InitializeComponent();
        }

        private async void FrmProduto_Load(object sender, EventArgs e)
        {
            IRepositorioGenerico<Marca> repositorioMarcas = new RepositorioMarca();
            List<Marca> marcas = await repositorioMarcas.SelecionarTodos();
            List<MarcaViewModel> viewModels = new List<MarcaViewModel>();
            foreach (Marca marca in marcas)
            {
                MarcaViewModel viewModel = new MarcaViewModel
                {
                    Id = marca.Id,
                    Nome = marca.Nome
                };
                viewModels.Add(viewModel);
            }
            cmbMarcas.DataSource = viewModels;
            cmbMarcas.DisplayMember = "Nome";
            cmbMarcas.ValueMember = "Id";
            cmbMarcas.Refresh();

            if (produtoASerAlterado != null)
            {
                txtNomeProduto.Text = produtoASerAlterado.Nome;
                cmbMarcas.SelectedValue = produtoASerAlterado.MarcarId;
            }
            else
            {
                txtNomeProduto.Text = string.Empty;
            }
        }

        private void btnSalvarProduto_Click(object sender, EventArgs e)
        {
            IRepositorioGenerico<Produto> repositorioProduto = new RepositorioProduto();
            if (produtoASerAlterado == null)
            {
                Produto novoProduto = new Produto
                {
                    Nome = txtNomeProduto.Text.Trim(),
                    MarcarId = Convert.ToInt32(cmbMarcas.SelectedValue)
                };
                repositorioProduto.Inserir(novoProduto);
                MessageBox.Show("Produto cadastrado com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                produtoASerAlterado.Nome = txtNomeProduto.Text;
                produtoASerAlterado.MarcarId = Convert.ToInt32(cmbMarcas.SelectedValue);
                repositorioProduto.Atualizar(produtoASerAlterado);
                MessageBox.Show("Produto alterado com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Close();
        }

        private void btnLimparProduto_Click(object sender, EventArgs e)
        {
            txtNomeProduto.Clear();
        }

        private void btnFecharProduto_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
