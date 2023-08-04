using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Queries.Receipts
{
    public record GetReceiptQuery(Guid DomainId) : IQuery;
}
