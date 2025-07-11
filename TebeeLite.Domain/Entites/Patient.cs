using System;
using System.Collections.Generic;

namespace TebeeLite.Infrastructure.Models;


public partial class Patient
{
    public int PatientId { get; set; }

    public string FullName { get; set; } = null!;

    public DateOnly? Dob { get; set; }

    public string? Gender { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? Address { get; set; }

    public string? Notes { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? BloodType { get; set; }

    public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();

    public virtual ICollection<MedicalFile> MedicalFiles { get; set; } = new List<MedicalFile>();

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();
}
