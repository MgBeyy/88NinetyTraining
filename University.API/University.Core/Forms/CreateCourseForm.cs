using System.ComponentModel.DataAnnotations;

namespace University.Core.Forms
{
    public class CreateCourseForm
    {
        
        [Required]
        [MaxLength(256)]
        public string Title { get; set; }
        
        public string Description { get; set; }
    }
}
