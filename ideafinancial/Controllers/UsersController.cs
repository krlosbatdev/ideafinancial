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

        [HttpGet("/api/users/{id}")]
        public IActionResult GetUserById(int id)
        {
            var user = _dbContext.Users.FirstOrDefault(u => u.Id == id);
            if (user == null)
                return NotFound("User not found");

            return Ok(_mapper.Map<User, UserResource>(user));
        }

        [HttpPost("/api/users")]
        public IActionResult Draw([FromBody]DrawResource draw)
        {
            var user = _dbContext.Users.FirstOrDefault(u => u.Id == draw.UserId);
            if (user == null)
                return NotFound("User not found");

            if (user.AvailableFunds < draw.Amount)
                return BadRequest("Draw amount bigger than available funds");

            user.Draw(draw.Amount);

            _dbContext.SaveChanges();

            return Ok();
        }
    }
}
