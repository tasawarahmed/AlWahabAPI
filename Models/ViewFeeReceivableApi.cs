using System;
using System.Collections.Generic;

namespace AlWahabAPI.Models;

public partial class ViewFeeReceivableApi
{
    public string FeeType { get; set; } = null!;

    public string FeeMonth { get; set; } = null!;

    public int? FeeYear { get; set; }

    public long? FeeUnpaid { get; set; }

    public long StuId { get; set; }
}
