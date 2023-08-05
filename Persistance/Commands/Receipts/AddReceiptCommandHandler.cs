﻿using Domain.Receipts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Commands.Receipts
{
    public class AddReceiptCommandHandler : ICommandHandler<AddReceiptCommand>
    {
        private readonly ReceiptsContext _context;

        public AddReceiptCommandHandler(ReceiptsContext context)
        {
            _context = context;
        }

        public void Handle(AddReceiptCommand command)
        {
            _context.Add(new Receipt
            {
                DomainId = command.DomainId,
                Name = command.Name,
                Price = command.Price,
                Amount = command.Amount,
                Date = command.Date,
            });
            _context.SaveChanges();
        }
    }
}
