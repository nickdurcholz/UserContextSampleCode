namespace ClassLibrary1
{
    public class User
    {
        public User() { }

        public User(int? id, string userName, string email)
        {
            Id = id;
            UserName = userName;
            Email = email;
        }

        public int? Id { get; }
        public string UserName { get; }
        public string Email { get; }
        //whatever app specific stuff you want
    }
}