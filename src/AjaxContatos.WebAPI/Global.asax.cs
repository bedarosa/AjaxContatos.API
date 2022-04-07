using AjaxContatos.Service.AutoMapper;
using AjaxContatos.WebAPI.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace AjaxContatos.WebAPI
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            AutoMapperConfig.GetMapperConfiguration();
            DependencyInjectionConfig.RegisterDIContainer();
        }
    }
}
