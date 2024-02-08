using System;
using System.Collections.Generic;

namespace AlWahabAPI.Models;

public partial class TblUser
{
    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string? ActualName { get; set; }

    public string SecurityQuestion { get; set; } = null!;

    public string SecurityAnswer { get; set; } = null!;

    public string Roles { get; set; } = null!;

    public string? UserType { get; set; }

    public bool? IsActive { get; set; }
}
