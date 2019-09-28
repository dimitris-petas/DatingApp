using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using datingApp.api.Data;
using datingApp.api.Dtos;
using datingApp.api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace datingApp.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _authRepository;

        public AuthController(IAuthRepository authRepository)
        {
            _authRepository = authRepository;
        }
        
        [HttpPost("register")]
        public async Task<IActionResult> Register(UserForRegisterDto userForRegisterDto)
        {
            userForRegisterDto.username = userForRegisterDto.username.ToLower();
            if (await _authRepository.UserExists(userForRegisterDto.username))
                return BadRequest("Username allready exists.");

            var userToCreate = new User
            {
                Username = userForRegisterDto.username
            };

            var createdUser = await _authRepository.Register(userToCreate, userForRegisterDto.password);

            return StatusCode(201);
        }
    }
}