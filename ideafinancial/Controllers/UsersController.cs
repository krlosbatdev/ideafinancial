using AutoMapper;
using ideafinancial.Controllers.Resources;
using ideafinancial.Models;
using ideafinancial.Persistence;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ideafinancial.Controllers
{
    public class UsersController : Controller
    {
        private readonly IdeafinancialDbContext _dbContext;
        private readonly IMapper _mapper;

        public UsersController(IdeafinancialDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            this._mapper = mapper;
        }

        [HttpGet("/api/users")]
        public IActionResult GetUserByName(string name)
        {
            var user = _dbContext.Users.FirstOrDefault(u => u.FirstName == name);
            if (user == null)
                return NotFound("User not found");

            return Ok(_mapper.Map<User, UserResource>(user));
        }
    }
}
