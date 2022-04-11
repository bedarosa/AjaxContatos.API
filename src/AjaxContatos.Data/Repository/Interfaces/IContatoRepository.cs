using AjaxContatos.Domain.EntitiesBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjaxContatos.Data.Repository.Interfaces
{
    public interface IContatoRepository
    {
        Task Adicionar(Contato contato);
        Task Deletar(Guid id);
        Task<Contato> Atualizar(Contato contato);
        Task<List<Contato>> BuscarTodosContatos();
        Task<Contato> BuscarPorId(Guid id);
    }
}
