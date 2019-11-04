using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlbumCollection.Models;
using AlbumCollection.Repository;
using Microsoft.AspNetCore.Mvc;

namespace AlbumCollection.Controllers
{
    [Route("api/[controller]")]
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

        // GET api/album/5
        [HttpGet("{id}")]
        public IEnumerable<Albums> Get()
        {
            return albumRepo.GetAll();
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
