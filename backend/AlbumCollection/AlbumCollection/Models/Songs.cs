using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumCollection.Models
{
    public class Songs
    {
        public int ID { get; set; }
        public string Songtitle { get; set; }
        public string Duration { get; set; }

        public virtual int AlbumID { get; set; }
        public virtual Albums Albums { get; set; }

        public Songs()
        {
        }

        public Songs(int id, string title, string duration, int albumID)
        {
            ID = id;
            Songtitle = title;
            Duration = duration;
            AlbumID = albumID;
        }



    }
}
