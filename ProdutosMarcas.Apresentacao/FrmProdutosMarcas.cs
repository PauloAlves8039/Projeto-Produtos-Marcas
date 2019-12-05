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

        private void btnAdicionarMarca_Click(object sender, EventArgs e)
        {

        }

        private void btnAtualizarMarca_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluirMarca_Click(object sender, EventArgs e)
        {

        }

        private void btnAdiconarProdutos_Click(object sender, EventArgs e)
        {

        }

        private void btnAtualizarProduto_Click(object sender, EventArgs e)
        {

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
