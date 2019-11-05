using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlbumCollection.Models;
using AlbumCollection.Repository;
using Microsoft.AspNetCore.Mvc;

namespace AlbumCollection.Controllers
{
    [Route("api/album")]
    [ApiController]
    public class AlbumController : ControllerBase
    {
        // GET api/Album
        //[HttpGet]
        //public ActionResult<IEnumerable<string>> Get()
        //{
        //    return new string[] { "album1", "album2" };
        //}

        private IRepository<Albums> albumRepo;

        public AlbumController(IRepository<Albums> albumRepo)
        {
            this.albumRepo = albumRepo;
        }

        [HttpGet]
        public IEnumerable<Albums> Get()
        {
            return albumRepo.GetAll();
        }

        // GET api/album/5
        [HttpGet("{id}")]
        public Albums Get(int id)
        {
            return albumRepo.GetByID(id);
        }

        // POST api/album
        [HttpPost]
        public IEnumerable<Albums> Post([FromBody] Albums albums)
        {
            albumRepo.Create(albums);
            return albumRepo.GetAll();
        }

        // PUT api/album/5
        [HttpPut("{id}")]
        public IEnumerable<Albums> Put(int id, [FromBody] Albums albums)
        {
            albumRepo.Update(albums);
            return albumRepo.GetAll();
        }

        // DELETE api/album/5
        [HttpDelete("{id}")]
        public IEnumerable<Albums> Delete(int id)
        {
            var album = albumRepo.GetByID(id);
            albumRepo.Delete(album);
            return albumRepo.GetAll();
        }
    }
}
