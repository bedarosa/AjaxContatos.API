using AjaxContatos.Service.Services.Interfaces;
using Newtonsoft.Json;
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

        public string Get()
        {
            string json = JsonConvert.SerializeObject(_contatoService.BuscarTodos());
            return json;
        }
    }
}
