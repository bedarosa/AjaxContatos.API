using AjaxContatos.Data.Repository.Interfaces;
using AjaxContatos.Domain.EntitiesBase;
using AjaxContatos.Service.Services.Interfaces;
using AjaxContatos.Service.ViewModel;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

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

        public async Task AdicionarContato(Contato contato)
        {
            await _contatoRepository.Adicionar(contato);
        }

        public async Task<Contato> Atualizar(Contato contato)
        {
            return await _contatoRepository.Atualizar(contato);
        }

        public async Task<Contato> BuscarPorId(Guid id)
        {
            return await _contatoRepository.BuscarPorId(id);
        }

        public async Task<List<ContatoViewModel>> BuscarTodos()
        {
            var contatos = _mapper.Map<List<ContatoViewModel>>(await _contatoRepository.BuscarTodosContatos());
            return contatos;
        }

        public async Task DeletarContato(Guid id)
        {
            await _contatoRepository.Deletar(id);
        }
    }
}
