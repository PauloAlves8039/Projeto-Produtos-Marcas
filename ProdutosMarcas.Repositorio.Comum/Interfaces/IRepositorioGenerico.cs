﻿/*
 * Arquivo: interface IRepositorioGenerico
 * Autor: Paulo Alves
 * Descrição: responsável por conter métodos genéricos da regra de negócio da aplicação
 * Data: 04/12/2019
*/

using System.Collections.Generic;

namespace ProdutosMarcas.Repositorio.Comum.Interfaces
{
    public interface IRepositorioGenerico<TDominio>
    {
        List<TDominio> SelecionarTodos();
        TDominio SelecionarPorId(int id);
        void Atualizar(TDominio entidade);
        void Excluir(TDominio entidade);
    }
}