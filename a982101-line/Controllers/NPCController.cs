using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace a982101_line.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NPCController : ControllerBase
    {
        // GET: api/NPC
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/NPC/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/NPC
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/NPC/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/NPC/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
