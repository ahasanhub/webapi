using System;
using System.Threading.Tasks;
using System.Web.Http;
using AutoMapper.Api.Models;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(AutoMapper.Api.Startup))]

namespace AutoMapper.Api
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config=new HttpConfiguration();
            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=316888
            WebApiConfig.Register(config);
            app.UseWebApi(config);
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Customer, CustomerDto>();
                cfg.CreateMap<CustomerDto, Customer>();
            });
           
        }
    }
}
