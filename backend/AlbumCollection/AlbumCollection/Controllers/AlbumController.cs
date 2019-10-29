using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AlbumCollection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Album : ControllerBase
    {
        // GET api/Album
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "album1", "album2" };
        }

        // GET api/album/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "Album";
        }

        // POST api/album
        [HttpPost]
        public void Post([FromBody] string Album)
        {
        }

        // PUT api/album/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string Album)
        {
        }

        // DELETE api/album/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
