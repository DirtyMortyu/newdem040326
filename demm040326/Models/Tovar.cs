using System;
using System.Collections.Generic;

namespace demm040326.Models;

public partial class Tovar
{
    public int IdTov { get; set; }

    public string Article { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Unit { get; set; } = null!;

    public decimal Price { get; set; }

    public int Sizeorder { get; set; }

    public int ManufId { get; set; }

    public int SupplierId { get; set; }

    public int CategoryId { get; set; }

    public int Salepercent { get; set; }

    public int Quantity { get; set; }

    public string Discription { get; set; } = null!;

    public byte[]? Image { get; set; }

    public virtual Category Category { get; set; } = null!;

    public virtual Manufacturer Manuf { get; set; } = null!;

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    public virtual Supplier Supplier { get; set; } = null!;
}
