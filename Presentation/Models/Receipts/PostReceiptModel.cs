using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Models.Receipts
{
    public class PostReceiptModel
    {
        public string Name { get; set; } = null!;

        public double Price { get; set; }

        public int Amount { get; set; }

        public DateTime Date { get; set; }
    }
}
