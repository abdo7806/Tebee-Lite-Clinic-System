using System;
using System.Collections.Generic;

namespace TebeeLite.Infrastructure.Models;

public partial class Doctor
{
    public int DoctorId { get; set; }

    public int UserId { get; set; }

    public string? Specialization { get; set; }

    public string? LicenseNumber { get; set; }

    public string? Education { get; set; }

    public int? YearsOfExperience { get; set; }

    public string? WorkingHours { get; set; }

    public string? Notes { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();

    public virtual User User { get; set; } = null!;
}
