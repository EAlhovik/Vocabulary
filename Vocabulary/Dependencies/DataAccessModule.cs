using Autofac;
using Autofac.Integration.Mvc;
using Vocabulary.Data;
using Vocabulary.Data.Helpers;

namespace Vocabulary.Dependencies
{
    public class DataAccessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<VocabularyDbContext>().AsSelf().WithParameter("connectionStringName",
             "VocabularyConnection").InstancePerHttpRequest();

            builder.RegisterAssemblyTypes(typeof(VocabularyUow).Assembly).Where(t => t.Name.EndsWith("Uow")).
               AsImplementedInterfaces();

            builder.RegisterType(typeof(RepositoryProvider)).AsImplementedInterfaces();

            builder.RegisterType(typeof(RepositoryFactories)).AsSelf().SingleInstance();
        }
    }
}