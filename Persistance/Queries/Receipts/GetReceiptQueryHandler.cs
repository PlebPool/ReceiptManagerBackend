using Persistance.Entities;
using Persistance.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Queries.Receipts
{
    public class GetReceiptQueryHandler : IQueryHandler<GetReceiptQuery, Receipt>
    {
        private readonly ReceiptsContext _context;

        public GetReceiptQueryHandler(ReceiptsContext context)
        {
            _context = context;
        }

        public Receipt Handle(GetReceiptQuery query) 
        {
            try
            {
                Receipt target = _context.Receipts.Where(a => a.DomainId == query.DomainId).Single<Receipt>();
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
