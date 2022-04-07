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
        void Adicionar(Contato contato);
        void Deletar(Guid id);
        Contato Atualizar(Contato contato);
        List<Contato> BuscarTodosContatos();
        Contato BuscarPorId(Guid id);
    }
}
