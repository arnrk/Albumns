using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AlbumCollection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongController : ControllerBase
    {
        // GET api/song
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "song1", "song2" };
        }

        // GET api/song/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "song";
        }

        // POST api/song
        [HttpPost]
        public void Post([FromBody] string song)
        {
        }

        // PUT api/song/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string song)
        {
        }

        // DELETE api/song/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
