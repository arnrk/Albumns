using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlbumCollection.Data;
using AlbumCollection.Models;

namespace AlbumCollection.Repository
{
    public class SongRepository : IRepository<Songs>
    {
        private Context db;
        public SongRepository(Context db)
        {
            this.db = db;
        }

        public int Count()
        {
            return db.Songs.Count();
        }

        public void Create(Songs songs)
        {
            db.Songs.Add(songs);
            db.SaveChanges();
        }

        public void Delete(Songs songs)
        {
            db.Songs.Remove(songs);
            db.SaveChanges();
        }

        public void Edit(Songs songs)
        {
            db.Songs.Update(songs);
            db.SaveChanges();
        }

        public IEnumerable<Songs> GetAll()
        {
            return db.Songs.ToList();
        }

        public Songs GetByID(int id)
        {
            return db.Songs.Single(p => p.ID == id);
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
