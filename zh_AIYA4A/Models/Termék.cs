using System;
using System.Collections.Generic;

namespace zh_AIYA4A.Models;

public partial class Termék
{
    public int TermékId { get; set; }

    public string? Terméknév { get; set; }

    public int? Egységár { get; set; }
}
