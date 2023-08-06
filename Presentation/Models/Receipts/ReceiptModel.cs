using Domain.Receipts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Models.Receipts
{
    public class ReceiptModel
    {
        public string Name { get; set; } = null!;

        public double TotalPrice { get; set; }

        public DateTime Date { get; set; }

        public IEnumerable<ReceiptEntry>? Entries { get; set; }
    }
}
