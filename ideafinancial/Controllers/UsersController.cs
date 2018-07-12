using AutoMapper;
using ideafinancial.Controllers.Resources;
using ideafinancial.Models;
using ideafinancial.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace ideafinancial.Controllers
{
    public class UsersController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;


        public UsersController(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this._mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        [HttpGet("/api/users/{id}")]
        public IActionResult GetUserById(int id)
        {
            var user = _unitOfWork.UserRepository.GetUser(id);
            if (user == null)
                return NotFound("User not found");

            return Ok(_mapper.Map<User, UserResource>(user));
        }

        [HttpPost("/api/users")]
        public IActionResult Draw([FromBody]DrawResource draw)
        {
            var user = _unitOfWork.UserRepository.GetUser(draw.UserId);
            if (user == null)
                return NotFound("User not found");

            if (user.AvailableFunds < draw.Amount)
                return BadRequest("Draw amount bigger than available funds");

            user.Draw(draw.Amount);

            _unitOfWork.Complete();

            return Ok();
        }
    }
}
