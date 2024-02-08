using System;
using System.Collections.Generic;

namespace AlWahabAPI.Models;

public partial class ViewStudent
{
    public long StuId { get; set; }

    public string StuName { get; set; } = null!;

    public string ClassName { get; set; } = null!;
}
