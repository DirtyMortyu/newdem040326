using System;
using System.Collections.Generic;

namespace demm040326.Models;

public partial class OrderItem
{
    public int IdOrderItems { get; set; }

    public int IdOrder { get; set; }

    public int IdTovar { get; set; }

    public int Quantity { get; set; }

    public virtual Order IdOrderNavigation { get; set; } = null!;

    public virtual Tovar IdTovarNavigation { get; set; } = null!;
}
