using System;
using System.Collections.Generic;

namespace EmployeeManagerApplication.Models;

public partial class Role
{
    public int RoleId { get; set; }

    public string? RoleName { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();

    public virtual ICollection<UsersClaim> UsersClaims { get; set; } = new List<UsersClaim>();
}
