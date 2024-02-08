using System;
using System.Collections.Generic;

namespace AlWahabAPI.Models;

public partial class TblStuExamType
{
    public int ExamTypeId { get; set; }

    public string ExamTypeDesc { get; set; } = null!;

    public string? ExamTypeRemarks { get; set; }
}
