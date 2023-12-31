﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace DoctorsOfficeV2.Data.Models
{
    public class Appointment
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime Date { get; set; }
        public IdentityUser Doctor { get; set; }
        public Patient Patient { get; set; }
        public ICollection<AppointmentMedication> Medications { get; set; }
    }
}
