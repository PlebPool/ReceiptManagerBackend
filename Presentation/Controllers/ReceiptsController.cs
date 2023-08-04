using Persistance.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Persistance.Commands.Receipts;
using Persistance.Queries.Receipts;
using Persistance.Queries;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("/receipts")]
    public class ReceiptsController : Controller
    {
        private readonly IQueryHandler<IEnumerable<ReceiptEntity>> getAllReceiptQueryHandler;

        public ReceiptsController(IQueryHandler<IEnumerable<ReceiptEntity>> getAllReceiptQueryHandler)
        {

            this.getAllReceiptQueryHandler = getAllReceiptQueryHandler;
        }

        [HttpGet]
        public IEnumerable<ReceiptEntity> GetReceipts()
        {
            return getAllReceiptQueryHandler.Handle();
        }
    }
}
