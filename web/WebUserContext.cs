using System.Security.Principal;
using ClassLibrary1;
using Microsoft.AspNetCore.Http;

namespace web
{
    public class WebUserContext : IUserContext
    {
        private readonly IHttpContextAccessor _contextAccessor;

        public WebUserContext(IHttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor;
        }

        public User User => GetUser();

        private User GetUser()
        {
            var context = _contextAccessor.HttpContext;
            var user = context.Items["UserContextUser"] as User;
            if (user == null)
            {
                user = LookupUser(context.User.Identity);

                context.Items["UserContextUser"] = user;
            }
            return user;
        }

        private User LookupUser(IIdentity identity)
        {
            //TODO load the user from wherever you store user data
            return new User(1, "some.dude", "dude@example.com");
        }
    }
}