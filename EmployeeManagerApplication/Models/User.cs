using System;
using System.Collections.Generic;

namespace EmployeeManagerApplication.Models;

public partial class User
{
    public int UserId { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public int? RoleId { get; set; }

    public virtual ICollection<Attachment> Attachments { get; set; } = new List<Attachment>();

    public virtual Role? Role { get; set; }

    public virtual ICollection<Token> Tokens { get; set; } = new List<Token>();

    public virtual ICollection<UsersClaim> UsersClaims { get; set; } = new List<UsersClaim>();
}
