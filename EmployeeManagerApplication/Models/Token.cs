using System;
using System.Collections.Generic;

namespace EmployeeManagerApplication.Models;

public partial class Token
{
    public int Id { get; set; }

    public string? TokenType { get; set; }

    public DateTime? ExpirationDate { get; set; }

    public int? UserId { get; set; }

    public virtual User? User { get; set; }
}
