using System;
using System.Collections.Generic;

namespace AlWahabAPI.Models;

public partial class TblGenFeeType
{
    public int FeeTypeId { get; set; }

    public string FeeTypeDesc { get; set; } = null!;

    public string? Remarks { get; set; }

    public string? ServiceType { get; set; }
}
