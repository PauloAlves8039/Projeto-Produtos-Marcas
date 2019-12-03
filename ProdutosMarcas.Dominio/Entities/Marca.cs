/*
 * Arquivo: classe Marca
 * Autor: Paulo Alves
 * Descrição: responsável por conter propriedades da entidade Marca
 * Data: 03/12/2019
*/

using System.Collections.Generic;

namespace ProdutosMarcas.Dominio.Entities
{
    public class Marca
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public virtual List<Produto> Produtos { get; set; }
    }
}
