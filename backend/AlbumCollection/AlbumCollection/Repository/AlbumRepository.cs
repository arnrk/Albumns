using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlbumCollection.Data;
using AlbumCollection.Models;
using Microsoft.EntityFrameworkCore;

namespace AlbumCollection.Repository
{
    public class AlbumRepository : Repository<Albums>, IRepository<Albums>
    {
        private DbContext db;

        public AlbumRepository(Context context) : base(context)
        {
            this.db = context;
        }

        public override Albums GetByID(int id)
        {
            return db.Set<Albums>().Where(i => i.ID == id).Include("Songs").FirstOrDefault();
        }
    }
}
