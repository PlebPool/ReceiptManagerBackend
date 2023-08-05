using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Commands.Receipts
{
    public record AddReceiptCommand(Guid DomainId, string Name, double Price, int Amount, DateTime Date) : ICommand;
}
