using System;
using System.Collections.Generic;

namespace AlWahabAPI.Models;

public partial class TblGenMonth
{
    public int MonthId { get; set; }

    public string MonthName { get; set; } = null!;

    public string? Remarks { get; set; }
}
