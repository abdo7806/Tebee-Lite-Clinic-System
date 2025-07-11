using System;
using System.Collections.Generic;

namespace TebeeLite.Infrastructure.Models;

public partial class MedicalFile
{
    public int FileId { get; set; }

    public int PatientId { get; set; }

    public string? FileName { get; set; }

    public string? FileType { get; set; }

    public string? FilePath { get; set; }

    public DateTime? UploadedAt { get; set; }

    public string? Notes { get; set; }

    public virtual Patient Patient { get; set; } = null!;
}
