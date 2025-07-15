using System.ComponentModel.DataAnnotations;

namespace University.Core.Forms
{
    public class UpdateStudentForm
    {
        [Required]
        [MaxLength(256)]

        public string Name { get; set; }
    }
}
