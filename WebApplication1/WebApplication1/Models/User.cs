namespace WebApplication1.Models
{
    public class User
    {
        public int Id { get; set; }

        public string   UName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public UserRole Role { get; set; }

        public int? ManagerId { get; set; }

        public virtual User Manager { get; set; }
    }


    public enum UserRole
    {
        Admin=0,
        Manager=1,
        Employee=2
    }


   
}
