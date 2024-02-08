using System;
using System.Collections.Generic;

namespace AlWahabAPI.Models;

public partial class TblGenWing
{
    public int WingId { get; set; }

    public string WingDesc { get; set; } = null!;

    public string? Remarks { get; set; }
}
