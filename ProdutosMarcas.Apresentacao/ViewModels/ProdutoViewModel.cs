/*
 * Arquivo: classe ProdutoViewModel
 * Autor: Paulo Alves
 * Descrição: responsável por conter propriedades da entidade Produto para a camada de apresentação
 * Data: 05/12/2019
*/

namespace ProdutosMarcas.Apresentacao.ViewModels
{
    class ProdutoViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int MarcaId { get; set; }
        public string Marca { get; set; }
    }
}
