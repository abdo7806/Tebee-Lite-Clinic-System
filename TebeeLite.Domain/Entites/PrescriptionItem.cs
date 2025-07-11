using System;
using System.Collections.Generic;

namespace TebeeLite.Infrastructure.Models;

public partial class PrescriptionItem
{
    public int ItemId { get; set; }

    public int PrescriptionId { get; set; }

    public int? MedicationId { get; set; }

    public string? Dosage { get; set; }

    public string? Frequency { get; set; }

    public string? Duration { get; set; }

    public string? Instructions { get; set; }

    public string? CustomMedicationName { get; set; }

    public string? CustomMedicationDescription { get; set; }

    public string? CustomDosageForm { get; set; }

    public string? CustomStrength { get; set; }

    public bool? IsCustom { get; set; }

    public virtual Medication? Medication { get; set; }

    public virtual Prescription Prescription { get; set; } = null!;
}
