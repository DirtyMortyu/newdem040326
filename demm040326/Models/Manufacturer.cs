using System;
using System.Collections.Generic;

namespace demm040326.Models;

public partial class Manufacturer
{
    public int Idmanufacturer { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Tovar> Tovars { get; set; } = new List<Tovar>();
}
