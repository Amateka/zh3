using System;
using System.Collections.Generic;

namespace zh_AIYA4A.Models;

public partial class Személy
{
    public int SzemélyId { get; set; }

    public string Név { get; set; } = null!;

    public string? Email { get; set; }

    public int RendelésId { get; set; }
}
