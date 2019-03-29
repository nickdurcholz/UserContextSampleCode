using ClassLibrary1;
using Microsoft.AspNetCore.Mvc;

namespace web
{
    public class MyController : Controller
    {
        private readonly IUserContext _userContext;

        public MyController(IUserContext userContext)
        {
            _userContext = userContext;
        }

        //TODO implement some actions
    }
}