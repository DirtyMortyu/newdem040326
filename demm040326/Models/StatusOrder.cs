using System;
using System.Collections.Generic;

namespace demm040326.Models;

public partial class StatusOrder
{
    public int IdStatus { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
