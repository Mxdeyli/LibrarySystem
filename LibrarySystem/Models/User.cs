namespace LibrarySystem.Models
{
    public class User
    {
        public User(int id, string username, string role)
        {
            UserID = id;
            Username = username;
            Role = role;
        }

        public int UserID { get; set; }
        public string Username { get; set; }
        public string Role { get; set; }
    }
}
