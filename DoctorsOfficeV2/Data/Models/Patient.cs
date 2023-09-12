using System.ComponentModel.DataAnnotations;

namespace DoctorsOfficeV2.Data.Models
{
    public class Patient
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public int SSN { get; set; }

        public ICollection<Appointment> Appointments { get; set; }
    }
}
