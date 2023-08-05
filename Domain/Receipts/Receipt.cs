using System;
using System.Collections.Generic;

namespace Domain.Receipts;

public partial class Receipt
{
    public int Id { get; set; }

    public Guid DomainId { get; set; }

    public string Name { get; set; } = null!;

    public double Price { get; set; }

    public int Amount { get; set; }

    public DateTime Date { get; set; }
}
