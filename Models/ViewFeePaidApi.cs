using System;
using System.Collections.Generic;

namespace AlWahabAPI.Models;

public partial class ViewFeePaidApi
{
    public string FeeType { get; set; } = null!;

    public string FeeMonth { get; set; } = null!;

    public int? FeeYear { get; set; }

    public long? FeeAmount { get; set; }

    public long StuId { get; set; }
}
