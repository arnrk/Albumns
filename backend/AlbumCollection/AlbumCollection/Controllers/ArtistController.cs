using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlbumCollection.Models;
using AlbumCollection.Repository;
using Microsoft.AspNetCore.Mvc;

namespace AlbumCollection.Controllers
{
    [Route("api/artist")]
    [ApiController]
    public class ArtistController : ControllerBase
    {
        // GET api/Album
        //[HttpGet]
        //public ActionResult<IEnumerable<string>> Get()
        //{
        //    return new string[] { "album1", "album2" };
        //}

        private IRepository<Artists> artistRepo;

        public ArtistController(IRepository<Artists> artistRepo)
        {
            this.artistRepo = artistRepo;
        }

        // GET api/album/5
        [HttpGet]
        public IEnumerable<Artists> Get()
        {
            return artistRepo.GetAll();
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "artist";
        }


        // POST api/artist
        [HttpPost]
        public IEnumerable<Artists> Post([FromBody] Artists artists)
        {
            artistRepo.Create(artists);
            return artistRepo.GetAll();
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
