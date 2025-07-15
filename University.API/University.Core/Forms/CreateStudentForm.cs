using System.ComponentModel.DataAnnotations;

namespace University.Core.Forms
{
    public class CreateStudentForm
    {

        [Required]
        [MaxLength(256)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

    }
}
