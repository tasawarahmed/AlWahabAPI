using System;
using System.Collections.Generic;

namespace AlWahabAPI.Models;

public partial class TblStuExam
{
    public int ExamId { get; set; }

    public int ExamTypeId { get; set; }

    public string ExamDescription { get; set; } = null!;

    public string? Remarks { get; set; }

    public bool? IsActive { get; set; }

    public bool IsRecordEntered { get; set; }

    public int? SessionId { get; set; }
}
