﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TebeeLite.Application.DTOs.Doctor
{
    public class DoctorCreateDto
    {

        public int UserId { get; set; }

        //public string Username { get; set; } = null!;

      //  public string PasswordHash { get; set; } = null!;
      //  public string FullName { get; set; }
        public string Specialization { get; set; }
        public string LicenseNumber { get; set; }
        public string Education { get; set; }
        public int YearsOfExperience { get; set; }
        public string WorkingHours { get; set; }
        public string Notes { get; set; }
        // تاريخ إنشاء سجل الطبيب
        public DateTime? CreatedAt { get; set; } = DateTime.Now;
    }
}
