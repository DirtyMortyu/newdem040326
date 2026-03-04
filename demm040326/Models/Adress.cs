using System;
using System.Collections.Generic;

namespace demm040326.Models;

public partial class Adress
{
    public int Idadress { get; set; }

    public long Index { get; set; }

    public string City { get; set; } = null!;

    public string Stret { get; set; } = null!;

    public int NumberHouse { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
