namespace EFCoreWithConsoleApp.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TeacherId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int SyllabusId { get; set; }


        public User Teacher { get; set; }
        public Syllabus Syllabus { get; set; }



        public ICollection<Assignment> Assignments { get; set; }

    }
}
