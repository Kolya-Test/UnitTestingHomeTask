namespace Tools.Models
{
    public class User
    {
        private static int _id = 1;
        private static User _undefinedUser = new User(0, "Undefined");

        public int Id { get; }
        public string Name { get; set; }
        public string Email { get; set; }
        public static User Undefined => _undefinedUser;

        public User() { Id = _id++; }
        public User(string name) : this() { Name = name; }
        public User(string name, string email) : this(name) { Email = email; }
        private User(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public string GetInfo() { return $"[{Id}] User '{Name}' (email: {Email})"; }
    }

}
