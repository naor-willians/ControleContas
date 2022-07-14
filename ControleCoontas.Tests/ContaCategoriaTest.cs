using Microsoft.VisualStudio.TestTools.UnitTesting;
using ControleContas.Repository;
using ControleContas.Domain.Models;
using ControleContas.Domain.Interfaces;
using System;

namespace ControleContas.Tests
{
    [TestClass]
    public class ContaCategoriaTest
    {
        ContaCategoriaRepository rep = new ContaCategoriaRepository();

        //[TestMethod]
        //public void ContaCategoriaIncluirTest()
        //{
        //    var categoria = new ContaCategoria()
        //    {
        //        Id = "2",
        //        UsuarioId = "123Teste",
        //        Nome = "Educação"
        //    };


        //    rep.Incluir(categoria);
        //}

        //[TestMethod]
        //public void ContaCategoriaAlterarTest()
        //{
        //    var categoria = new ContaCategoria()
        //    {
        //        Id = "2",
        //        UsuarioId = "123Teste",
        //        Nome = "Alimentação"
        //    };

        //    rep.Alterar(categoria);
        //}

        [TestMethod]
        public void ContaCategoriaExcluirTest()
        {
            rep.Excluir("2");
        }
    }
}
