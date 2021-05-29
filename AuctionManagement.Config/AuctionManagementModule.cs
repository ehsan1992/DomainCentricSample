using System.Linq;
using AuctionManagement.Application;
using AuctionManagement.Domain.Model;
using AuctionManagement.Persistence.Mongo;
using Autofac;
using Framework.Application;
using Framework.Autofac;

namespace AuctionManagement.Config
{
    public class AuctionManagementModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(typeof(AuctionCommandHandler).Assembly)
                .As(type => type.GetInterfaces()
                    .Where(interfaceType => interfaceType
                        .IsClosedTypeOf(typeof(ICommandHandler<>))))
                .InstancePerLifetimeScope();

            builder.RegisterType<MongoAuctionRepository>().As<IAuctionRepository>();

            builder.RegisterType<AutofacCommandBus>().As<ICommandBus>();

            base.Load(builder);
        }
    }
}
