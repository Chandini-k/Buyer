using System;
using Microsoft.AspNetCore.Mvc;
using UserService.Extensions;
using UserService.Models;
using UserService.Repositories;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authorization;

namespace UserService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _repo;
        private readonly ILogger<UserController> _logger;

        public UserController(IUserRepository repo,ILogger<UserController> logger)
        {
            _repo = repo;
            _logger = logger;
        }
        /// <summary>
        /// Register buyer
        /// </summary>
        /// <param name="buyer"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Register")]
        public IActionResult Buyer(Buyer buyer)
        {
            _logger.LogInformation("Register");
            
            _repo.BuyerRegister(buyer);

            _logger.LogInformation($"Successfully Registered");

            return Ok();
        }
        /// <summary>
        /// Login Buyer
        /// </summary>
        /// <param name="uname"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("Login/{uname}/{pwd}")]
        //[ProducesResponseType]
        public IActionResult BuyerLogin(string uname, string pwd)
        {
            try
            {
                _logger.LogInformation("User Login");

                Buyer buyer = _repo.ValidateBuyer(uname, pwd);
                if(buyer!=null)
                {
                    return Ok(buyer);
                }

                return Ok(buyer);
            }
            catch (MyAppException ex)
            {
                throw ex;
            }
        }
    }
}