using System;
using System.Collections.Generic;

namespace AlWahabAPI.Models;

public partial class TblStuExamResult
{
    public long StuId { get; set; }

    public int SubjectId { get; set; }

    public int ExamId { get; set; }

    public int? ClassId { get; set; }

    public string? Section { get; set; }

    public int? StdMarks { get; set; }

    public int? ActualMarks { get; set; }

    public double MarksObtained { get; set; }

    public double? StdMarksObtained { get; set; }

    public string? Remarks { get; set; }
}
