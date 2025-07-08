using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TebeeLite.Application.DTOs.Doctor
{
    public class DoctorUpdateDto
    {
       // public string Username { get; set; } = null!;

      //  public string FullName { get; set; }
      
        public string Specialization { get; set; }
        public string LicenseNumber { get; set; }
        public string Education { get; set; }
        public int YearsOfExperience { get; set; }

        public string WorkingHours { get; set; }
        public string Notes { get; set; }

        public bool IsActive { get; set; }


        public DateTime? UpdatedAt { get; set; } = DateTime.UtcNow;

    }
}
