using Domain.Receipts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Persistance.Commands.Receipts;
using Persistance.Queries.Receipts;
using Persistance.Queries;
using Presentation.Models.Receipts;
using Persistance.Commands;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("/receipts")]
    public class ReceiptsController : Controller
    {
        private readonly IQueryHandler<IEnumerable<Receipt>> getAllReceiptQueryHandler;
        private readonly ICommandHandler<AddReceiptCommand> addReceiptCommandHandler;

        public ReceiptsController(
            IQueryHandler<IEnumerable<Receipt>> getAllReceiptQueryHandler, 
            ICommandHandler<AddReceiptCommand> addReceiptCommandHandler)
        {
            this.addReceiptCommandHandler = addReceiptCommandHandler;
            this.getAllReceiptQueryHandler = getAllReceiptQueryHandler;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IEnumerable<ReceiptModel> GetReceipts()
        {
            return getAllReceiptQueryHandler.Handle().Select(receipt => ToModel(receipt));
        }

        [HttpPost]
        public ActionResult PostReceipt(PostReceiptModel incomingReceipt)
        {
            Guid freshGuid = Guid.NewGuid();
            addReceiptCommandHandler.Handle(
                new AddReceiptCommand(
                    freshGuid, 
                    incomingReceipt.Name, 
                    incomingReceipt.TotalPrice, 
                    incomingReceipt.Date, 
                    incomingReceipt.Entries
                )
            );
            return Ok();
        }

        private static ReceiptModel ToModel(Receipt receipt)
        {
            return new()
            {
                Name = receipt.Name,
                TotalPrice = receipt.TotalPrice,
                Date = receipt.Date,
                Entries = receipt.Entries
            };
        } 
    }
}
