
using Autofac;
using Autofac.Integration.Mvc;
using SignalR.Hubs;
using Vocabulary.Hubs;

namespace Vocabulary.Dependencies
{
    public class DomainServicesModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //builder.RegisterAssemblyTypes(typeof(TicketManagementService).Assembly)
            //    .Where(t => t.Name.EndsWith("Service")).AsImplementedInterfaces();
            //builder.RegisterAssemblyTypes(typeof(TicketBuilder).Assembly)
            //    .Where(t => t.Name.EndsWith("Builder")).AsImplementedInterfaces();

            //builder.RegisterAssemblyTypes(typeof(FileWriter).Assembly).Where(t => t.Name.EndsWith("Writer")).AsImplementedInterfaces();

            //builder.RegisterType(typeof(TicketProfile)).AsImplementedInterfaces().As(typeof(Profile)).InstancePerHttpRequest();
            //builder.RegisterType(typeof(AutomapperConfigurator)).AsSelf().InstancePerHttpRequest();
        }
    }
}