using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TebeeLite.Infrastructure.Models;

namespace TebeeLite.Application
{
    public class AppointmentDto
    {
        public int AppointmentId { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }

        public string PatientName { get; set; }

        public string DoctorName { get; set; }

        public string BookedByUserName { get; set; }

        public string AppointmentDate { get; set; }
        public string AppointmentTime { get; set; }

        public DateTime AppointmentDateTime { get; set; }

        public string? Diagnosis { get; set; }

        public string? Treatment { get; set; }

        public string? Notes { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public string StatusName { get; set; }

       
    }
}
