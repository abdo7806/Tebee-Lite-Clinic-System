using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TebeeLite.Infrastructure.Models;

namespace TebeeLite.Application.DTOs.Doctor
{
    public class DoctorReadDto
    {
        public int DoctorId { get; set; }
        public int UserId { get; set; }
        public string? Username { get; set; }
        public string? FullName { get; set; }         // مأخوذ من جدول المستخدمين
        public string? Specialization { get; set; }
        public string? LicenseNumber { get; set; }

        public int? YearsOfExperience { get; set; }
        public string? WorkingHours { get; set; }
        // المؤهلات التعليمية للطبيب
        public string? Education { get; set; }

        // ملاحظات إضافية عن الطبيب
        public string? Notes { get; set; }

        // تاريخ إنشاء سجل الطبيب
        public DateTime? CreatedAt { get; set; }

        // تاريخ آخر تحديث لسجل الطبيب
        public DateTime? UpdatedAt { get; set; }
        public bool IsActive { get; set; }


    }
}
