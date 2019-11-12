using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlbumCollection.Data;
using AlbumCollection.Models;

namespace AlbumCollection.Repository
{
    public class SongRepository : Repository<Songs>, IRepository<Songs>
    {
        public SongRepository(Context context) : base(context)
        {

        }
    }
}
