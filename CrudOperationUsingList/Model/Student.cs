using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CrudOperation.Models.Model
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("First Name")]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [DisplayName("Last Name")]
        public string LastName { get; set; } = string.Empty;

        [Required]
        [DisplayName("Gender")]
        public string Gender { get; set; } = string.Empty;

        [Required]
        [Range(5, 99)]
        [DisplayName("Age")]
        public int Age { get; set; }


        [DisplayName("Address")]
        public string Address { get; set; } = string.Empty;

        [DisplayName("Class")]
        public string Class { get; set; } = string.Empty;
    }
}
