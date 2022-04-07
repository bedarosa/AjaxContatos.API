using AjaxContatos.Data.Repository.Interfaces;
using AjaxContatos.Domain.EntitiesBase;
using AjaxContatos.Service.Services.Interfaces;
using AjaxContatos.Service.ViewModel;
using AutoMapper;
using System;
using System.Collections.Generic;

namespace AjaxContatos.Service.Services
{
    public class ContatoService : IContatoService
    {
        private readonly IContatoRepository _contatoRepository;
        private readonly IMapper _mapper;
        public ContatoService(IContatoRepository contatoRepository, IMapper mapper)
        {
            _contatoRepository = contatoRepository;
            _mapper = mapper;
        }

        public void AdicionarContato(Contato contato)
        {
            _contatoRepository.Adicionar(contato);
        }

        public Contato Atualizar(Contato contato)
        {
            return _contatoRepository.Atualizar(contato);
        }

        public Contato BuscarPorId(Guid id)
        {
            return _contatoRepository.BuscarPorId(id);
        }

        public List<ContatoViewModel> BuscarTodos()
        {
            return _mapper.Map<List<ContatoViewModel>>(_contatoRepository.BuscarTodosContatos());
        }

        public void DeletarContato(Guid id)
        {
            _contatoRepository.Deletar(id);
        }
    }
}
