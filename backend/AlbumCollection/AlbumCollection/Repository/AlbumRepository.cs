using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlbumCollection.Data;
using AlbumCollection.Models;

namespace AlbumCollection.Repository
{
    public class AlbumRepository : IRepository<Albums>
    {
        private Context db;
        public AlbumRepository(Context db)
        {
            this.db = db;
        }

        public int Count()
        {
            return db.Albums.Count();
        }

        public void Create(Albums albums)
        {
            db.Albums.Add(albums);
            db.SaveChanges();
        }

        public void Delete(Albums albums)
        {
            db.Albums.Remove(albums);
            db.SaveChanges();
        }

        public void Edit(Albums albums)
        {
            db.Albums.Update(albums);
            db.SaveChanges();
        }

        public IEnumerable<Albums> GetAll()
        {
            return db.Albums.ToList();
        }

        public Albums GetByID(int id)
        {
            return db.Albums.Single(p => p.ID == id);
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
