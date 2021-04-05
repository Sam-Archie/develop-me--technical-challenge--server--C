using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bounce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TournamentController : ControllerBase
    {
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return "x";
        //}

        // GET api/<TournamentController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TournamentController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TournamentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TournamentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
