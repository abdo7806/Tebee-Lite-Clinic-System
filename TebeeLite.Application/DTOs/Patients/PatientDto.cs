
namespace Wasfaty.Application.DTOs.Patients
{
    public class PatientDto
    {
        public int Id { get; set; }

        public string FullName { get; set; } = null!;

        public DateOnly? Dob { get; set; }// تاريخ الميلاد

        public string? Gender { get; set; }

        public string? Phone { get; set; }

        public string? Email { get; set; }

        public string? Address { get; set; }

        public string? Notes { get; set; }
        public string? BloodType { get; set; }
           
        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

    }
}
