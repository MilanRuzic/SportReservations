using Application.BusinessLogic.Authentication;
using Application.Common.Interfaces;
using Application.Common.Security;
using Application.Models;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace WebApi.Controllers.Authentication
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class AuthenticationController : Controller
    {
        private readonly IApplicationDbContext _context;
        private AuthenticationService _authService;

        public AuthenticationController(
            IApplicationDbContext context,
            AuthenticationService authService
        )
        {
            _context = context;
            _authService = authService;
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(UserLogin userLogin)
        {
            var result = await _authService.Login(userLogin);
            if (result.IsError)
            {
                return BadRequest(result.ErrorMessage);
            }
            return Ok(result.Result);
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register(User request)
        {
            var result = await _authService.Register(request);
            if (result.IsError)
            {
                return BadRequest(result.ErrorMessage);
            }
            return Ok(result.Result);
        }
    }
}
