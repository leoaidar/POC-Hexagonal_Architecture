using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Poc.Hexagonal.Domain.Entities;
using Poc.Hexagonal.Domain.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Poc.Hexagonal.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClubController : ControllerBase
    {
        private readonly IClubService _clubService;

        public ClubController(IClubService clubService)
        {
            _clubService = clubService;
        }

        // GET: api/<ClubController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var clubs = await _clubService.RecoverAllClubs();

            return Ok(clubs);
        }


        // POST api/<ClubController>
        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] Club club)
        {
            var id = await _clubService.RegisterAClub(club);

            return Ok(id);
        }

    }
}
