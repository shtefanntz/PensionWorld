namespace PensionWorld.Web.App_Start
{
    using System.Web.Mvc;

    using Autofac;
    using Autofac.Integration.Mvc;

    using PensionWorld.Domain.Repositories;
    using PensionWorld.Services;
    using PensionWorld.Web.App_Start.Mocks;

    public class DependencyResolverConfig
    {
        public static void RegisterDependencies()
        {
            // Register MVC-related dependencies
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterModelBinders(typeof(MvcApplication).Assembly);
            builder.RegisterModule<AutofacWebTypesModule>();

            // Register different services

            builder.RegisterType<RoomsService>().As<IRoomsService>().InstancePerRequest();
            builder.RegisterType<RoomsRepositoryMock>().As<IRoomsRepository>().InstancePerRequest();

            builder.RegisterModelBinderProvider();

            // Set the MVC dependency resolver to use Autofac
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}