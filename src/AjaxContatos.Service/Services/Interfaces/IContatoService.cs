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
        void AdicionarContato(Contato contato);
        void DeletarContato(Guid id);
        Contato Atualizar(Contato contato);
        Contato BuscarPorId(Guid id);
        List<ContatoViewModel> BuscarTodos();
    }
}
