using System;
using System.Collections.Generic;

namespace TebeeLite.Infrastructure.Models;

public partial class Prescription
{
    public int PrescriptionId { get; set; }

    public int AppointmentId { get; set; }

    public DateOnly PrescriptionDate { get; set; }

    public string? Notes { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Appointment Appointment { get; set; } = null!;

    public virtual ICollection<PrescriptionItem> PrescriptionItems { get; set; } = new List<PrescriptionItem>();
}
