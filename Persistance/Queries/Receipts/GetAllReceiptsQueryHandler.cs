using Persistance.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Queries.Receipts
{
    public class GetAllReceiptsQueryHandler : IQueryHandler<IEnumerable<ReceiptEntity>>
    {
        ReceiptsContext receiptsContext;

        public GetAllReceiptsQueryHandler(ReceiptsContext receiptsContext)
        {
            this.receiptsContext = receiptsContext;
        }

        public IEnumerable<ReceiptEntity> Handle()
        {
            return receiptsContext.Receipts.ToList();
        }
    }
}
