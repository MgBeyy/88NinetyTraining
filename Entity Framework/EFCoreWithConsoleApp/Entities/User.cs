namespace EFCoreWithConsoleApp.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAdress { get; set; }
        public string PhoneNumber { get; set; }
        public string Role { get; set; }


        public ICollection<Grade> Grades { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
