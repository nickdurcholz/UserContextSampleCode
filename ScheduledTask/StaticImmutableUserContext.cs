using ClassLibrary1;

namespace ScheduledTask
{
    public class StaticImmutableUserContext : IUserContext
    {
        private static readonly User _user = new User();

        public User User => _user;
    }
}