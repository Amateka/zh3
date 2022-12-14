using System;
using System.Collections.Generic;

namespace zh_AIYA4A.Models;

public partial class Product
{
    public int TermékId { get; set; }

    public string Terméknév { get; set; } = null!;

    public int Egységár { get; set; }

    public virtual ICollection<Order> Orders { get; } = new List<Order>();
}
