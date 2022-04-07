using AjaxContatos.Domain.EntitiesBase;
using AjaxContatos.Service.ViewModel;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AjaxContatos.Service.AutoMapper
{
    public class AutoMapperConfig
    {
        public static MapperConfiguration GetMapperConfiguration()
        {
            var profiles = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(x => typeof(Profile).IsAssignableFrom(x));

            return new MapperConfiguration(cfg =>
            {
                foreach (var profile in profiles)
                {
                    cfg.AddProfile(Activator.CreateInstance(profile) as Profile);
                }
            });
        }
    }

    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Contato, ContatoViewModel>().ReverseMap();
        }
    }
}
