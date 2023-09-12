using System.ComponentModel.DataAnnotations;

namespace DoctorsOfficeV2.Data.Models
{
    public class Medication
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public ICollection<AppointmentMedication> appointmentMedications { get; set; }
    }
}
