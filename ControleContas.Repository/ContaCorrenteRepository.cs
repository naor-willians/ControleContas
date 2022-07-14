using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleContas.Domain.Models;
using ControleContas.Domain.Interfaces;

namespace ControleContas.Repository
{
    public class ContaCorrenteRepository : IContaCorrenteRepository
    {
        public void Alterar(ContaCorrente entidade)
        {
            throw new NotImplementedException();
        }

        public void Excluir(string id)
        {
            throw new NotImplementedException();
        }

        public void Incluir(ContaCorrente entidade)
        {
            throw new NotImplementedException();
        }

        public ContaCorrente ObterPorId(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ContaCorrente> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ContaCorrente> ObterTodos(string usuarioId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> Validar()
        {
            throw new NotImplementedException();
        }
    }
}
