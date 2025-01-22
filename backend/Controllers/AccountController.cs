using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using backend.Dtos.Account;
using backend.Extensions;
using backend.Interfaces;
using backend.Mappers;
using backend.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.JsonWebTokens;

namespace backend.Controllers
{
    [Route("api/account")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<Account> _accountManager;
        private readonly ITokenService _tokenService;
        private readonly SignInManager<Account> _signInManager;
        public AccountController(UserManager<Account> accountManager, ITokenService tokenService, SignInManager<Account> signInManager)
        {
            _accountManager = accountManager;
            _tokenService = tokenService;
            _signInManager = signInManager;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDto loginDto){
            if(!ModelState.IsValid){
                return BadRequest(ModelState);
            }

            var account = await _accountManager.Users.FirstOrDefaultAsync(x => x.UserName == loginDto.Username.ToLower());

            if(account == null)
            return Unauthorized("Invalid username!");

            var result = await _signInManager.CheckPasswordSignInAsync(account, loginDto.Password, false);

            if(!result.Succeeded) return Unauthorized("Username not found and/or password incorrect");

            return Ok(
                new NewAccountDto{
                    Username = account.UserName,
                    Token = _tokenService.CreateToken(account).Result.ToString()
                }
            );
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterDto registerDto, string role){
            try
            {
                if(!ModelState.IsValid)
                return BadRequest(ModelState);

                var account = new Account{
                    UserName = registerDto.Username,
                    Email = registerDto.Email,
                    PhoneNumber = registerDto.PhoneNumber,
                    PHId = registerDto.PHId,
                    ZBId = registerDto.ZBId,
                    ZHId = registerDto.ZHId,
                    MedewerkerId = registerDto.MedewerkerId
                };

                var createdAccount = await _accountManager.CreateAsync(account, registerDto.Password);
                if(createdAccount.Succeeded){
                    var roleResult = await _accountManager.AddToRoleAsync(account, role);
                    if(roleResult.Succeeded){
                        return Ok(
                            new NewAccountDto{
                                Username = account.UserName,
                                Token = _tokenService.CreateToken(account).Result.ToString()
                            }
                        );
                    }
                    else{
                        return StatusCode(500, roleResult.Errors);
                    }
                }
                else{
                    return StatusCode(500, createdAccount.Errors);
                }
            }
            catch (Exception e){
                return StatusCode(500, e);
            }
        }
        [HttpGet("role")]
        public async Task<IActionResult> GetAccountRole(){

            var username = User.GetUserName();

            var account = await _accountManager.FindByNameAsync(username);

            if(account == null){
                return NotFound();
            }
            var roles = await _accountManager.GetRolesAsync(account);
            if(!roles.Any()){
                return Ok("User has no roles");
            }
            return Ok(roles.FirstOrDefault());
        }
        [HttpGet("PH")]
        public async Task<IActionResult> GetPH(){

            var username = User.GetUserName();

            var account = await _accountManager.FindByNameAsync(username);

            if(account == null){
                return NotFound();
            }
            
            return Ok(account.ToPHDto());
        }
        [HttpGet("ZH")]
        public async Task<IActionResult> GetZH(){

            var username = User.GetUserName();

            var account = await _accountManager.FindByNameAsync(username);

            if(account == null){
                return NotFound();
            }
            
            return Ok(account.ToZHDto());
        }
        [HttpGet("ZB")]
        public async Task<IActionResult> GetZB(){

            var username = User.GetUserName();

            var account = await _accountManager.FindByNameAsync(username);

            if(account == null){
                return NotFound();
            }
            
            return Ok(account.ToZBDto());
        }
        [HttpGet("Medewerker")]
        public async Task<IActionResult> GetMedewerker(){

            var username = User.GetUserName();

            var account = await _accountManager.FindByNameAsync(username);

            if(account == null){
                return NotFound();
            }
            
            return Ok(account.ToMederwerkerDto());
        }
        [HttpGet]
        public async Task<IActionResult> GetAccountInfo(){

            var username = User.GetUserName();

            var account = await _accountManager.FindByNameAsync(username);

            if(account == null){
                return NotFound();
            }
            
            return Ok(account.ToAccountDto());
        }
    }
}