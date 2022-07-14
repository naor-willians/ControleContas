﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleContas.Domain.Models;
using ControleContas.Domain.Interfaces;

namespace ControleContas.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public void Alterar(Usuario usuario)
        {
            Db.Execute("UsuarioAlterar", usuario);
        }

        public void Excluir(string id)
        {
            Db.Execute("UsuarioExcluir", new { Id = id });
        }

        public void Incluir(Usuario usuario)
        {
            Db.Execute("UsuarioIncluir", usuario);
        }

        public Usuario ObterPorEmailSenha(string email, string senha)
        {
            return Db.QueryEntidade<Usuario>("UsuarioObterEmailSenha", new { Email = email, Senha = senha });
        }

        public Usuario ObterPorId(string id)
        {
            return Db.QueryEntidade<Usuario>("UsuarioObterPorId", new { Id= id });

        }

        public IEnumerable<Usuario> ObterTodos(string usuarioId)
        {
            return Db.QueryColecao<Usuario>("UsuarioObterTodos", null);
        }

        public IEnumerable<string> Validar()
        {
            throw new NotImplementedException();
        }
    }
}
