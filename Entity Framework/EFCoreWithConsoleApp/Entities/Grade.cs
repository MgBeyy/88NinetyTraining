namespace EFCoreWithConsoleApp.Entities
{
    public class Grade
    {
        public int Id { get; set; }
        public int AssignmentId { get; set; }
        public int StudentId { get; set; }
        public int Score { get; set; }

        public User Student { get; set; }
        public Assignment Assignment { get; set; }
    }
}
