using AjaxContatos.Service.Services.Interfaces;
using AjaxContatos.Service.ViewModel;
using Newtonsoft.Json;
using System.Collections.Generic;
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
            var contatos = await _contatoService.BuscarTodos();
            return contatos;
        }
    }
}
