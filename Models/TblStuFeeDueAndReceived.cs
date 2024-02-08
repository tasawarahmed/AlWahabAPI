using System;
using System.Collections.Generic;

namespace AlWahabAPI.Models;

public partial class TblStuFeeDueAndReceived
{
    public int Id { get; set; }

    public long? StuId { get; set; }

    public DateTime? Date { get; set; }

    public int? FeeTypeId { get; set; }

    public int? FeeMonthId { get; set; }

    public int? Year { get; set; }

    public long? FeeDue { get; set; }

    public long? FeePaid { get; set; }

    public long? FeeUnpaid { get; set; }

    public long? FundAmount { get; set; }

    public int? WriteOff { get; set; }

    public byte[]? ReceiptTime { get; set; }

    public string? Remarks { get; set; }

    public string? FeeRemarks { get; set; }

    public string? FeeCollector { get; set; }

    public string? InstallmentStatus { get; set; }
}
