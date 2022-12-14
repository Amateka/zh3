using System;
using System.Collections.Generic;

namespace zh_AIYA4A.Models;

public partial class Order
{
    public int PeopleId { get; set; }

    public int ProductId { get; set; }

    public string Terméknév { get; set; } = null!;

    public string SzemélyNév { get; set; } = null!;

    public int Mennyiség { get; set; }

    public int Egységár { get; set; }

    public virtual Person People { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
