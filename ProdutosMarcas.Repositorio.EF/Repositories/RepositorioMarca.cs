/*
 * Arquivo: classe RepositorioMarca
 * Autor: Paulo Alves
 * Descrição: responsável por herdar métodos genéricos da interface IRepositorioGenerico para a entidade Marca
 * Data: 04/12/2019
*/

using ProdutosMarcas.Dominio.Entities;
using ProdutosMarcas.Persistencia.EF.Context;
using ProdutosMarcas.Repositorio.Comum.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProdutosMarcas.Repositorio.EF.Repositories
{
    public class RepositorioMarca : IRepositorioGenerico<Marca>
    {
        public void Atualizar(Marca entidade)
        {
            using (ProdutosMarcasDbContext contexto = new ProdutosMarcasDbContext())
            {
                contexto.Marca.Attach(entidade);
                contexto.Entry(entidade).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }

        public void Excluir(Marca entidade)
        {
            using (ProdutosMarcasDbContext contexto = new ProdutosMarcasDbContext())
            {
                contexto.Marca.Attach(entidade);
                contexto.Entry(entidade).State = System.Data.Entity.EntityState.Deleted;
                contexto.SaveChanges();
            }
        }

        public void Inserir(Marca entidade)
        {
            using (ProdutosMarcasDbContext contexto = new ProdutosMarcasDbContext())
            {
                contexto.Marca.Add(entidade);
                contexto.SaveChanges();
            }
        }

        public Marca SelecionarPorId(int id)
        {
            using (ProdutosMarcasDbContext contexto = new ProdutosMarcasDbContext())
            {
                return contexto.Marca.Find(id);
            }
        }

        public Task<List<Marca>> SelecionarTodos()
        {
            return Task.Run(() =>
            {
                using (ProdutosMarcasDbContext contexto = new ProdutosMarcasDbContext())
                {
                    return contexto.Marca.ToList();
                }
            });
        }
    }
}
