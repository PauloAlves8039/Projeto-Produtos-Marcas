using ProdutosMarcas.Apresentacao.ViewModels;
using ProdutosMarcas.Dominio.Entities;
using ProdutosMarcas.Repositorio.Comum.Interfaces;
using ProdutosMarcas.Repositorio.EF.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProdutosMarcas.Apresentacao
{
    public partial class FrmProdutosMarcas : Form
    {
        public FrmProdutosMarcas()
        {
            InitializeComponent();
        }

        private void FrmProdutosMarcas_Load(object sender, EventArgs e)
        {
            PreencherDataGridViewMarcasAsync();
            PreencherDataGridViewProdutosAsync();
        }

        private void FrmProdutosMarcas_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = DateTime.Now.ToShortDateString();
            toolStripStatusLabel5.Text = DateTime.Now.ToLongTimeString();
        }

        private async void PreencherDataGridViewMarcasAsync()
        {
            IRepositorioGenerico<Marca> repositorioMarcas = new RepositorioMarca();
            List<Marca> marcas = await repositorioMarcas.SelecionarTodos();
            List<MarcaViewModel> marcaViewModels = new List<MarcaViewModel>();
            foreach (Marca marca in marcas)
            {
                MarcaViewModel viewModel = new MarcaViewModel
                {
                    Id = marca.Id,
                    Nome = marca.Nome
                };
                marcaViewModels.Add(viewModel);
            }
            dgvMarcas.Invoke((MethodInvoker) delegate 
            {
                dgvMarcas.DataSource = marcaViewModels;
                dgvMarcas.Refresh();
            });            
        }

        private async void PreencherDataGridViewProdutosAsync()
        {
            IRepositorioGenerico<Produto> repositorioProdutos = new RepositorioProduto();
            List<Produto> produtos = await repositorioProdutos.SelecionarTodos();
            List<ProdutoViewModel> produtoViewModel = new List<ProdutoViewModel>();
            foreach (Produto produto in produtos)
            {
                ProdutoViewModel viewModel = new ProdutoViewModel
                {
                    Id = produto.Id,
                    Marca = produto.Marca.Nome,
                    MarcaId = produto.MarcarId,
                    Nome = produto.Nome
                };
                produtoViewModel.Add(viewModel);
            }
            dgvProdutos.Invoke((MethodInvoker)delegate
            {
                dgvProdutos.DataSource = produtoViewModel;
                dgvProdutos.Refresh();
            });
        }

        private void btnAdicionarMarca_Click(object sender, EventArgs e)
        {
            FrmMarca frmMarca = new FrmMarca();
            frmMarca.ShowDialog();
            PreencherDataGridViewMarcasAsync();
        }

        private void btnAtualizarMarca_Click(object sender, EventArgs e)
        {
            if (dgvMarcas.SelectedRows.Count > 0)
            {
                int idMarcaSelecionada = Convert.ToInt32(dgvMarcas.SelectedRows[0].Cells[0].Value);
                IRepositorioGenerico<Marca> repositorioMarcas = new RepositorioMarca();
                Marca marcaASerAlterada = repositorioMarcas.SelecionarPorId(idMarcaSelecionada);
                FrmMarca frmMarca = new FrmMarca(marcaASerAlterada);
                frmMarca.ShowDialog();
                PreencherDataGridViewMarcasAsync();
                PreencherDataGridViewProdutosAsync();
            }
            else
            {
                MessageBox.Show("Selecione uma marca antes!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExcluirMarca_Click(object sender, EventArgs e)
        {

        }

        private void btnAdiconarProdutos_Click(object sender, EventArgs e)
        {
            FrmProduto frmProduto = new FrmProduto();
            frmProduto.ShowDialog();
            PreencherDataGridViewProdutosAsync();
        }

        private void btnAtualizarProduto_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.SelectedRows.Count > 0)
            {
                int idProdutoSelecionada = Convert.ToInt32(dgvProdutos.SelectedRows[0].Cells[0].Value);
                IRepositorioGenerico<Produto> repositorioProdutos = new RepositorioProduto();
                Produto produtoASerAlterado = repositorioProdutos.SelecionarPorId(idProdutoSelecionada);
                FrmProduto frmProduto = new FrmProduto(produtoASerAlterado);
                frmProduto.ShowDialog();
                PreencherDataGridViewProdutosAsync();
            }
            else
            {
                MessageBox.Show("Selecione um produto antes!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExcluirProduto_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
