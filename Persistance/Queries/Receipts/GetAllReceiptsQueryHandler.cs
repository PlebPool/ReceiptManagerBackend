using Domain.Receipts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Queries.Receipts
{
    public class GetAllReceiptsQueryHandler : IQueryHandler<IEnumerable<Receipt>>
    {
        private readonly ReceiptsContext receiptsContext;

        public GetAllReceiptsQueryHandler(ReceiptsContext receiptsContext)
        {
            this.receiptsContext = receiptsContext;
        }

        public IEnumerable<Receipt> Handle()
        {
            return receiptsContext.Receipts.ToList();
        }
    }
}
