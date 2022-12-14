using System;
using System.Collections.Generic;

namespace zh_AIYA4A.Models;

public partial class Person
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Gender { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; } = new List<Order>();
}
