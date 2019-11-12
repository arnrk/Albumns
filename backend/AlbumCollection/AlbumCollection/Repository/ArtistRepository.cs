using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlbumCollection.Data;
using AlbumCollection.Models;
using Microsoft.EntityFrameworkCore;

namespace AlbumCollection.Repository
{
    public class ArtistRepository : Repository<Artists>, IRepository<Artists>
    {
        private DbContext db;

        public ArtistRepository(Context context) : base(context)
        {
            this.db = context;
        }

        public override Artists GetByID(int id)
        {
            return db.Set<Artists>().Where(i => i.ID == id).Include("Albums").FirstOrDefault();
        }
    }
}
