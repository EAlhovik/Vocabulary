
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
    //        builder.RegisterAssemblyTypes(typeof(VocabularyHub).Assembly)
    //.Where(t => t.Name.EndsWith("Service")).AsImplementedInterfaces();

    //        //builder.RegisterType(typeof(VocabularyHub)).AsImplementedInterfaces().As(typeof(Hub)).InstancePerHttpRequest();

    //        builder.RegisterType(typeof(VocabularyHub)).AsSelf().InstancePerHttpRequest();
        }
    }
}