using System;
using System.Collections.Generic;

namespace EmployeeManagerApplication.Models;

public partial class UsersClaim
{
    public int UserClaimId { get; set; }

    public int? UserId { get; set; }

    public int? RoleId { get; set; }

    public string? Value { get; set; }

    public virtual Role? Role { get; set; }

    public virtual User? User { get; set; }
}
