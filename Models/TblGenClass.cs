using System;
using System.Collections.Generic;

namespace AlWahabAPI.Models;

public partial class TblGenClass
{
    public int ClassId { get; set; }

    public string ClassName { get; set; } = null!;

    public string? Remarks { get; set; }
}
