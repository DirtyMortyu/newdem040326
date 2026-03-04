using System;
using System.Collections.Generic;

namespace demm040326.Models;

public partial class Order
{
    public int IdOrder { get; set; }

    public DateOnly DateOrder { get; set; }

    public DateOnly DateEndOrder { get; set; }

    public int IdAdress { get; set; }

    public int? IdClient { get; set; }

    public int Cod { get; set; }

    public int IdStatus { get; set; }

    public virtual Adress IdAdressNavigation { get; set; } = null!;

    public virtual User? IdClientNavigation { get; set; }

    public virtual StatusOrder IdStatusNavigation { get; set; } = null!;

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
}
