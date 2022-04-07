using AjaxContatos.Data.Context;
using AjaxContatos.Data.Repository;
using AjaxContatos.Data.Repository.Interfaces;
using AjaxContatos.Service.AutoMapper;
using AjaxContatos.Service.Services;
using AjaxContatos.Service.Services.Interfaces;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using SimpleInjector.Lifestyles;
using System.Web.Http;

namespace AjaxContatos.WebAPI.App_Start
{
    public class DependencyInjectionConfig
    {
        public static void RegisterDIContainer()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();

            InitializeContainer(container);

            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);

            container.Verify();

            GlobalConfiguration.Configuration.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);
        }

        private static void InitializeContainer(Container container)
        {
            container.Register<AjaxContatosContext>(Lifestyle.Scoped);
            container.Register<IContatoRepository, ContatoRepository>(Lifestyle.Scoped);
            container.Register<IContatoService, ContatoService>(Lifestyle.Scoped);

            container.RegisterSingleton(() => AutoMapperConfig.GetMapperConfiguration().CreateMapper(container.GetInstance));
        }
    }
}