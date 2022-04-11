using AjaxContatos.Service.Services.Interfaces;
using AjaxContatos.Service.ViewModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Mvc;

namespace AjaxContatos.WebAPI.Controllers
{
    public class ContatoController : ApiController
    {
        private readonly IContatoService _contatoService;
        public ContatoController(IContatoService contatoService)
        {
            _contatoService = contatoService;
        }

        public async Task<List<ContatoViewModel>> Get()
        {
            try
            {
                return await _contatoService.BuscarTodos();
            }
            catch (Exception)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

        }

        public async Task<HttpStatusCode> Create(ContatoViewModel contato)
        {
            try
            {
                contato.Id = Guid.NewGuid();
                if (ModelState.IsValid)
                {
                    await _contatoService.AdicionarContato(contato);
                    return HttpStatusCode.Created;
                }
                return HttpStatusCode.BadRequest;
            }
            catch (Exception)
            {
                return HttpStatusCode.BadRequest;
            }
        }

        public async Task<ContatoViewModel> Get(Guid id)
        {
            try
            {
                return await _contatoService.BuscarPorId(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [System.Web.Http.HttpPut]
        public async Task Update(ContatoViewModel contatoViewModel)
        {
            await _contatoService.Atualizar(contatoViewModel);
        }

        public async Task<HttpStatusCode> Delete(Guid id)
        {
            try
            {
                await _contatoService.DeletarContato(id);
                return HttpStatusCode.OK;
            }
            catch (Exception)
            {
                return HttpStatusCode.BadRequest;
            }
        }
    }
}
