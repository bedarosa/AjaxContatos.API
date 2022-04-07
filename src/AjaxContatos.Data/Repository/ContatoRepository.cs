using AjaxContatos.Data.Context;
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
        private readonly AjaxContatosContext _context;

        public ContatoRepository(AjaxContatosContext context)
        {
            _context = context;
        }

        public void Adicionar(Contato contato)
        {
            _context.Contatos.Add(contato);
            _context.SaveChanges();
        }

        public Contato Atualizar(Contato contato)
        {
            throw new NotImplementedException();
        }

        public Contato BuscarPorId(Guid id)
        {
            return _context.Contatos.Find(id);
        }

        public List<Contato> BuscarTodosContatos()
        {
            return _context.Contatos.ToList();
        }

        public void Deletar(Guid id)
        {
            _context.Contatos.Remove(BuscarPorId(id));
            _context.SaveChanges();
        }
    }
}
