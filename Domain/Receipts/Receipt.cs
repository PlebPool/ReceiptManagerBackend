using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;

namespace Domain.Receipts;

public partial class Receipt
{
    public int Id { get; set; }

    public Guid DomainId { get; set; }

    public string Name { get; set; } = null!;

    public double TotalPrice { get; set; }

    public DateTime Date { get; set; }

    public string? EntriesSerialized { get; set; }

    [NotMapped]
    public IEnumerable<ReceiptEntry>? Entries 
    { 
        get
        {
            if (EntriesSerialized == null) return null;
            return JsonSerializer.Deserialize<IEnumerable<ReceiptEntry>>(EntriesSerialized);
        }
        set
        {
            EntriesSerialized = JsonSerializer.Serialize(value);
        } 
    }
}
