using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjaxContatos.Service.ViewModel
{
    public class ContatoViewModel
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }
        [JsonProperty("nome")]
        public string Nome { get; set; }
        [JsonProperty("telefone")]
        public string Telefone { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("cpf")]
        public string Cpf { get; set; }
    }
}
