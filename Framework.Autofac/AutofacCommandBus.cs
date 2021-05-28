using System.Collections.Generic;
using System.Threading.Tasks;
using Autofac;
using Framework.Application;

namespace Framework.Autofac
{
    public class AutofacCommandBus : ICommandBus
    {
        private readonly ILifetimeScope _lifetimeScope;

        public AutofacCommandBus(ILifetimeScope lifetimeScope)
        {
            _lifetimeScope = lifetimeScope;
        }

        public async Task Dispatch<T>(T command) where T : ICommand
        {
            var handlers = _lifetimeScope.Resolve<IEnumerable<ICommandHandler<T>>>();
            foreach (var commandHandler in handlers)
            {
                await commandHandler.Handle(command);
            }
        }
    }
}
