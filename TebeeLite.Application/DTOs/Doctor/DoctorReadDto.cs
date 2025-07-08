using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TebeeLite.Application.DTOs.Doctor
{
    public class DoctorReadDto
    {
        public int DoctorId { get; set; }
        public string FullName { get; set; }         // مأخوذ من جدول المستخدمين
        public string Specialization { get; set; }
        public int YearsOfExperience { get; set; }
        public string WorkingHours { get; set; }
    }
}
