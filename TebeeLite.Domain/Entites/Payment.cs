using System;
using System.Collections.Generic;

namespace TebeeLite.Infrastructure.Models;


public partial class Payment
{
    public int PaymentId { get; set; }

    public int PatientId { get; set; }

    public int AppointmentId { get; set; }

    public decimal Amount { get; set; }

    public DateTime PaymentDate { get; set; }

    public string? PaymentMethod { get; set; }

    public string InvoiceNumber { get; set; } = null!;

    public string? Notes { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? PaymentStatus { get; set; }

    public virtual Appointment Appointment { get; set; } = null!;

    public virtual Patient Patient { get; set; } = null!;
}
