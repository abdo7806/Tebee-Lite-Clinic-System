using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TebeeLite.Application.DTOs.Appointment
{
    public class CreateAppointment
    {

        public int PatientId { get; set; }

        public int DoctorId { get; set; }

        public int? BookedByUserId { get; set; }

        public DateTime AppointmentDate { get; set; }
     
        public string? Notes { get; set; }

        public DateTime? CreatedAt { get; set; }

        public int? StatusId { get; set; }

    }
}
