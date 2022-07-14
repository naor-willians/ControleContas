using ControleContas.Domain.Models;
using ControleContas.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ControleCoontas.Tests
{
    [TestClass]
    public class UsuarioTest
    {

        //[TestMethod]
        //public void UsuarioIncluirTeste()
        //{
        //    var usuario = new Usuario()
        //    {
        //        Id = "123Teste",
        //        Nome = "Teste",
        //        Email = "teste@email",
        //        Senha = "testesenha"
        //    };

        //    var repositorio = new UsuarioRepository();
        //    repositorio.Incluir(usuario);
        //}

        [TestMethod]
        public void UsuarioObterPorId()
        {

            var repositorio = new UsuarioRepository();
            var usuario = repositorio.ObterPorId("123Teste");

            if(usuario != null)
            {
                Console.WriteLine(usuario.Id);
                Console.WriteLine(usuario.Email);
            }
        }

        //[TestMethod]
        //public void UsuarioObterTodosTest()
        //{
        //    var rep = new UsuarioRepository();
        //    var lista = rep.ObterTodos(null);

        //    foreach(var usuario in lista)
        //    {
        //        Console.WriteLine(usuario.Nome);
        //        Console.WriteLine(usuario.Email);
        //    }
        //}


        //[TestMethod]
        //public void UsuarioValidaNome()
        //{
        //    var usuario = new Usuario()
        //    {
        //        Email = "teste",
        //        Senha = "123"
        //    };
        //}
    }
}
