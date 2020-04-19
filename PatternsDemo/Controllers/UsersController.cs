using Microsoft.AspNetCore.Mvc;
using PatternsDemo.Domain.DBModels;
using PatternsDemo.IBusiness;

namespace PatternsDemo.Repository.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IBUsers _users;

        public UsersController(IBUsers users)
        {
            _users = users;
        }


        [HttpGet]
        public ActionResult<Users> GetUsers()
        {
            var user = _users.GetUseryById(1);

            return user;
        }
    }
}