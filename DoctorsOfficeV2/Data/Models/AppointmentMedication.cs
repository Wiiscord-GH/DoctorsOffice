using System.ComponentModel.DataAnnotations;

namespace DoctorsOfficeV2.Data.Models
{
    public class AppointmentMedication
    {
        [Key]
        public int Id { get; set; }

        public Appointment Appointment { get; set; }
        public Medication Medication { get; set; }
    }
}
