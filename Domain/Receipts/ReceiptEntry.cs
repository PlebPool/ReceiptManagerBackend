using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Receipts
{
    public partial class ReceiptEntry
    {
        public string Name { get; set; } = null!;

        public double Price { get; set; }

        public int Amount { get; set; }
    }
}
