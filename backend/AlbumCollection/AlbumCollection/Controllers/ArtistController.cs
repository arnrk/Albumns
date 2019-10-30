using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AlbumCollection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtistController : ControllerBase
    {
        // GET api/Artist
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "artist1", "artist2" };
        }

        // GET api/Artist/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "Artist";
        }

        // POST api/artist
        [HttpPost]
        public void Post([FromBody] string Artist)
        {
        }

        // PUT api/artist/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string Artist)
        {
        }

        // DELETE api/artist/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
