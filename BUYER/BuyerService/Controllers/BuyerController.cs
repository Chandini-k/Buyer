using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BuyerService.Models;
using BuyerService.Repositories;
using Microsoft.Extensions.Configuration;

namespace BuyerService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuyerController : ControllerBase
    {
        private readonly IBuyerRepository _repo;
        private readonly IConfiguration configuration;

        public BuyerController(IBuyerRepository repo, IConfiguration configuration)
        {
            _repo = repo;
            this.configuration = configuration;
        }
       
    }
}