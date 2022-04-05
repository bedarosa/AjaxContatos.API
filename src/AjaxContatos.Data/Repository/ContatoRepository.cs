using AjaxContatos.Data.Repository.Interfaces;
using AjaxContatos.Domain.EntitiesBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjaxContatos.Data.Repository
{
    public class ContatoRepository : IContatoRepository
    {
        public void Adicionar(Contato contato)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(Contato contato)
        {
            throw new NotImplementedException();
        }

        public Contato BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Contato> BuscarTodosContatos()
        {
            throw new NotImplementedException();
        }

        public void Deletar(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
