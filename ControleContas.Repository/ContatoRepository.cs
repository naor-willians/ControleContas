using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleContas.Domain.Models;
using ControleContas.Domain.Interfaces;

namespace ControleContas.Repository
{
    public class ContatoRepository : IContatoRepository
    {
        public void Alterar(Contato entidade)
        {
            throw new NotImplementedException();
        }

        public void Excluir(string id)
        {
            throw new NotImplementedException();
        }

        public void Incluir(Contato entidade)
        {
            throw new NotImplementedException();
        }

        public Contato ObterPorId(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Contato> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Contato> ObterTodos(string usuarioId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> Validar()
        {
            throw new NotImplementedException();
        }
    }
}
