using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleContas.Domain.Models;
using ControleContas.Domain.Interfaces;

namespace ControleContas.Repository
{
    public class ContaCategoriaRepository : IContaCategoriaRepository
    {
        public void Alterar(ContaCategoria entidade)
        {
            throw new NotImplementedException();
        }

        public void Excluir(string id)
        {
            throw new NotImplementedException();
        }

        public void Incluir(ContaCategoria entidade)
        {
            throw new NotImplementedException();
        }

        public ContaCategoria ObterPorId(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ContaCategoria> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ContaCategoria> ObterTodos(string usuarioId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> Validar()
        {
            throw new NotImplementedException();
        }
    }
}
