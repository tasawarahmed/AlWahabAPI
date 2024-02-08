using System;
using System.Collections.Generic;

namespace AlWahabAPI.Models;

public partial class ViewFeePaidComplete
{
    public string Name { get; set; } = null!;

    public string FatherName { get; set; } = null!;

    public string Class { get; set; } = null!;

    public string Wing { get; set; } = null!;

    public string FeeType { get; set; } = null!;

    public string FeeMonth { get; set; } = null!;

    public int? FeeYear { get; set; }

    public long? FeeDue { get; set; }

    public long? FeeUnpaid { get; set; }

    public long? FeePaid { get; set; }

    public int WingId { get; set; }

    public int FeeTypeId { get; set; }

    public long StuId { get; set; }

    public int MonthId { get; set; }

    public int ClassId { get; set; }

    public string? StuFeeReminderRemarks { get; set; }

    public string? Mobile { get; set; }

    public string? Home { get; set; }

    public string? StuOfficeTelNo { get; set; }

    public string? ShortName { get; set; }

    public string? FeeRemarks { get; set; }
}
