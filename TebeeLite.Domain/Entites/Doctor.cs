using System;
using System.Collections.Generic;

namespace TebeeLite.Infrastructure.Models;

public partial class Doctor
{
    // معرف الطبيب (رقم فريد)
    public int DoctorId { get; set; }

    // معرف المستخدم المرتبط بالطبيب
    public int UserId { get; set; }

    // تخصص الطبيب (مثل: جراحة، طب أطفال، إلخ.)
    public string? Specialization { get; set; }

    // رقم الترخيص الذي حصل عليه الطبيب
    public string? LicenseNumber { get; set; }

    // المؤهلات التعليمية للطبيب
    public string? Education { get; set; }

    // عدد سنوات الخبرة التي يمتلكها الطبيب
    public int? YearsOfExperience { get; set; }

    // ساعات العمل للطبيب (مثل: من 9 صباحاً إلى 5 مساءً)
    public string? WorkingHours { get; set; }

    // ملاحظات إضافية عن الطبيب
    public string? Notes { get; set; }

    // تاريخ إنشاء سجل الطبيب
    public DateTime? CreatedAt { get; set; }

    // تاريخ آخر تحديث لسجل الطبيب
    public DateTime? UpdatedAt { get; set; }

    // مجموعة من المواعيد المرتبطة بالطبيب
    public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();

    // المستخدم المرتبط بالطبيب (معلومات المستخدم)
    public virtual User User { get; set; } = null!;
}