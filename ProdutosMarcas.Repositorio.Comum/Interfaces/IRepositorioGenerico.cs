/*
 * Arquivo: interface IRepositorioGenerico
 * Autor: Paulo Alves
 * Descrição: responsável por conter métodos genéricos da regra de negócio da aplicação
 * Data: 04/12/2019
*/

using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProdutosMarcas.Repositorio.Comum.Interfaces
{
    public interface IRepositorioGenerico<TDominio>
    {
        Task<List<TDominio>> SelecionarTodos();
        TDominio SelecionarPorId(int id);
        void Inserir(TDominio entidade);
        void Atualizar(TDominio entidade);
        void Excluir(TDominio entidade);
    }
}
