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
        public void Alterar(ContaCategoria contaCategoria)
        {
            Db.Execute("ContaCategoriaAlterar", contaCategoria);
        }

        public void Excluir(string id)
        {
            Db.Execute("ContaCategoriaExcluir", new { Id =id });
        }

        public void Incluir(ContaCategoria contaCategoria)
        {
            Db.Execute("ContaCategoriaIncluir", contaCategoria);
        }

        public ContaCategoria ObterPorId(string id)
        {
            return Db.QueryEntidade<ContaCategoria>("ContaCategoriaObterPorId", new { Id = id });
        }

        public IEnumerable<ContaCategoria> ObterTodos(string usuarioId)
        {
            return Db.QueryColecao<ContaCategoria>("ContaCategoriaObterTodos", null);
        }

        public IEnumerable<string> Validar()
        {
            throw new NotImplementedException();
        }
    }
}
