namespace ClassLibrary1
{
    public class SomeBusinessLogic
    {
        private readonly IUserContext _userContext;

        public SomeBusinessLogic(IUserContext userContext)
        {
            _userContext = userContext;
        }

        public void DoSomething()
        {
            var currentUser = _userContext.User;
        }
    }
}