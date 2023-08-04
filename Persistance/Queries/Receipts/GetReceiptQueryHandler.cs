using Persistance.Entities;
using Persistance.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Queries.Receipts
{
    public class GetReceiptQueryHandler : IQueryHandler<GetReceiptQuery, ReceiptEntity>
    {
        private readonly ReceiptsContext _context;

        public GetReceiptQueryHandler(ReceiptsContext context)
        {
            _context = context;
        }

        public ReceiptEntity Handle(GetReceiptQuery query) 
        {
            try
            {
                ReceiptEntity target = _context.Receipts.Where(a => a.DomainId == query.DomainId).Single<ReceiptEntity>();
                return target;
            } 
            catch (Exception ex)
            {
                // TODO: Implement
                throw new Exception(ex.Message);
            }
        }
    }
}
