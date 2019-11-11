using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlbumCollection.Data;
using AlbumCollection.Models;
using Microsoft.EntityFrameworkCore;

namespace AlbumCollection.Repository
{
    public class ArtistRepository : IRepository<Artists>
    {
        private Context db;
        public ArtistRepository(Context db)
        {
            this.db = db;
        }

        public int Count()
        {
            return db.Artists.Count();
        }

        public void Create(Artists artists)
        {
            db.Artists.Add(artists);
            db.SaveChanges();
        }

        public void Delete(Artists artists)
        {
            db.Artists.Remove(artists);
            db.SaveChanges();
        }

        public void Update(Artists artists)
        {
            db.Artists.Update(artists);
            db.SaveChanges();
        }

        public IEnumerable<Artists> GetAll()
        {
            return db.Artists.ToList();
        }

        public Artists GetByID(int id)
        {
            return db.Artists.Where(i => i.ID == id).Include("Albums").FirstOrDefault();
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
