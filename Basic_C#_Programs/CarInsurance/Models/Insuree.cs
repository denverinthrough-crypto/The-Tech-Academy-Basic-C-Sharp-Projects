using System;
using System.Collections.Generic;

namespace CarInsurance.Models;

public partial class Insuree
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string EmailAddress { get; set; } = null!;

    public DateTime DateOfBirth { get; set; }

    public int CarYear { get; set; }

    public string CarMake { get; set; } = null!;

    public string CarModel { get; set; } = null!;

    public bool Dui { get; set; }

    public int SpeedingTickets { get; set; }

    public bool FullCoverage { get; set; }

    public decimal Quote { get; set; }
}
