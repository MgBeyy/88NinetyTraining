namespace EFCoreWithConsoleApp.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public int AssignmentId { get; set; }
        public int CreatedByUserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CommentContent { get; set; }


        public Assignment Assignment { get; set; }
        public User CreatedByUser { get; set; }

    }
}
