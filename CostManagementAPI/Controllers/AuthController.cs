using System;
using System.Collections.Generic;
using CostManagementAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CostManagementAPI.Data;
using CostManagementAPI.Dto;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.AspNetCore.Authorization;
using AutoMapper;


namespace CostManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
    public IAuthRepository _authRepository { get; set; }
    public IConfiguration _config { get; set; }
    public IMapper _mapper { get; set; }

        public AuthController(IAuthRepository authRepository, IConfiguration config, IMapper mapper)
        {
            _authRepository = authRepository;
            _config = config;
            _mapper = _mapper;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login()
        {
            //throw new Exception("Server says No!.");
            //checking user exist or not
            var UserFromRepo = await _authRepository.Login("admin","admin");

            if (UserFromRepo == null)
                return Unauthorized();

            // Creating token

            var claims = new[]
            {
                 new Claim(ClaimTypes.NameIdentifier,UserFromRepo.Id.ToString()),
                 new Claim(ClaimTypes.Name,UserFromRepo.Username)
             };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(
                    _config.GetSection("AppSettings:Token").Value));

            var creds =  new SigningCredentials(key,SecurityAlgorithms.HmacSha512Signature);

            var tockenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddDays(1),
                SigningCredentials = creds
            };

            var tockenHandler = new JwtSecurityTokenHandler();

            var token = tockenHandler.CreateToken(tockenDescriptor);

            var user = _mapper.Map<UserForLoginDto>(UserFromRepo);

            return Ok(new {
               token = tockenHandler.WriteToken(token),
               user
            });
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(UserForLoginDto userForRegisterDto)
        {
            userForRegisterDto.username = userForRegisterDto.username.ToLower();

            if (await _authRepository.UserExists(userForRegisterDto.username))
                return BadRequest("Username alreary exists!");

            var userToCreate = _mapper.Map<User>(userForRegisterDto);

            var createdUser = await _authRepository.Register(userToCreate, userForRegisterDto.password);

            var userToReturn = _mapper.Map<UserForLoginDto>(createdUser);

            return CreatedAtRoute("GetUser", new {
                controller = "Users", id = createdUser.Id
            },userToReturn);
        }
    }
}