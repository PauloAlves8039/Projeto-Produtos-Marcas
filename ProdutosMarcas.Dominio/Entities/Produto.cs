/*
 * Arquivo: classe Produto
 * Autor: Paulo Alves
 * Descrição: responsável por conter propriedades da entidade Produto
 * Data: 03/12/2019
*/

namespace ProdutosMarcas.Dominio.Entities
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int MarcarId { get; set; }
        public virtual Marca Marca { get; set; }
    }
}
