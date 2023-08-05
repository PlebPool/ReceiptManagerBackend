using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Commands
{
    public interface ICommandHandler<in TCommand> : ICommandHandlerMarker where TCommand : ICommand
    {
        void Handle(TCommand command);
    }
}
