using System.ComponentModel.DataAnnotations;

namespace University.Core.Forms
{
    public class UpdateCourseForm
    {
        [Required]
        [MaxLength(256)]
        public string Title { get; set; }

        public string Description { get; set; }
    }
}
