using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlbumCollection.Models;
using AlbumCollection.Repository;
using Microsoft.AspNetCore.Mvc;

namespace AlbumCollection.Controllers
{
    [Route("api/song")]
    [ApiController]
    public class SongController : ControllerBase
    {
        // GET api/Album
        //[HttpGet]
        //public ActionResult<IEnumerable<string>> Get()
        //{
        //    return new string[] { "album1", "album2" };
        //}

        private IRepository<Songs> songRepo;

        public SongController(IRepository<Songs> songRepo)
        {
            this.songRepo = songRepo;
        }

        // GET api/album/5
        [HttpGet]
        public IEnumerable<Songs> Get()
        {
            return songRepo.GetAll();
        }

        [HttpGet("{id}")]
        public Songs Get(int id)
        {
            return songRepo.GetByID(id);
        }


        // POST api/song
        [HttpPost]
        public IEnumerable<Songs> Post([FromBody] Songs songs)
        {
            songRepo.Create(songs);
            return songRepo.GetAll();
        }

        // PUT api/songs/5
        [HttpPut("{id}")]
        public IEnumerable<Songs> Put(int id, [FromBody] Songs songs)
        {
            songRepo.Update(songs);
            return songRepo.GetAll();
        }

        // DELETE api/songs/5
        [HttpDelete("{id}")]
        public IEnumerable<Songs> Delete(int id)
        {
            var song = songRepo.GetByID(id);
            songRepo.Delete(song);
            return songRepo.GetAll();
        }
    }
}
