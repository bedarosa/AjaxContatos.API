using AjaxContatos.Data.Context;
using AjaxContatos.Data.Repository.Interfaces;
using AjaxContatos.Domain.EntitiesBase;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjaxContatos.Data.Repository
{
    public class ContatoRepository : IContatoRepository
    {
        private readonly AjaxContatosContext _context;
        private DbSet<Contato> _dataSet;

        public ContatoRepository(AjaxContatosContext context)
        {
            _context = context;
            _dataSet = context.Set<Contato>();
        }

        public async Task Adicionar(Contato contato)
        {
            _dataSet.Add(contato);
            await _context.SaveChangesAsync();
        }

        public async Task<Contato> Atualizar(Contato contato)
        {
            throw new NotImplementedException();
        }

        public async Task<Contato> BuscarPorId(Guid id)
        {
            return await _dataSet.FindAsync(id);
        }

        public async Task<List<Contato>> BuscarTodosContatos()
        {
            return await _dataSet.ToListAsync();
        }

        public async Task Deletar(Guid id)
        {
            _context.Contatos.Remove(await _dataSet.FindAsync(id));
            await _context.SaveChangesAsync();
        }
    }
}
