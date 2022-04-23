using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mod8_1302204026.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Movies : ControllerBase
    {
        private static readonly string[] Titles = new[]
                {
            "inception", "fight club", "The Matrix"
        };

        private static readonly string[] Directors = new[]
                {
            "Elliot Page", "David Fincher", "Keanu Reeves"
        };

        private static readonly string[] Descriptions = new[]
                {
            "A thief who steals corporate secrets through the use of dream-sharing technology is.", "An insomniac office worker and a devil-may-care soap maker form an underground fight club that evolves into much mor.", "When a beautiful stranger leads computer hacker Neo to a forbidding underworld, he discovers the shocking truth--the life he knows is the elaborate deception of an evil cyber-intelligence.."
        };

        // GET: api/<Movies>
        [HttpGet]
        public IEnumerable<movie> Get()
        {
            var rng = new Random();
            return Enumerable.Range(0, 3).Select(index => new movie
            {
                Title = Titles[index],
                Director = Directors[index],
                Stars = new List<string> { "" },
                Description = Descriptions[index]
            })
            .ToArray();
        }

        // GET api/<Movies>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<Movies>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }


        // DELETE api/<Movies>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        private readonly ILogger<Movies> _logger;

        public Movies(ILogger<Movies> logger)
        {
            _logger = logger;
        }
    }
}
