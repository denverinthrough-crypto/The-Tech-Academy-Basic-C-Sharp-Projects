using System;
using System.Collections.Generic;

namespace NewsletterAppMVC.Models;

public partial class SignUp
{
    public int Id { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? EmailAddress { get; set; }

    public DateTime? Removed { get; set; }
}
