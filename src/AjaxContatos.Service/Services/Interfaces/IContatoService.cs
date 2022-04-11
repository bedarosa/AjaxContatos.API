using AjaxContatos.Domain.EntitiesBase;
using AjaxContatos.Service.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjaxContatos.Service.Services.Interfaces
{
    public interface IContatoService
    {
        Task AdicionarContato(Contato contato);
        Task DeletarContato(Guid id);
        Task<Contato> Atualizar(Contato contato);
        Task<Contato> BuscarPorId(Guid id);
        Task<List<ContatoViewModel>> BuscarTodos();
    }
}
