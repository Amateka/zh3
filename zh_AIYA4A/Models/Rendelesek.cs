using System;
using System.Collections.Generic;

namespace zh_AIYA4A.Models;

public partial class Rendelesek
{
    public int SzemélyId { get; set; }

    public int TermékId { get; set; }

    public string Személynév { get; set; } = null!;

    public string Terméknév { get; set; } = null!;

    public int Mennyiség { get; set; }

    public int Egységár { get; set; }
}
