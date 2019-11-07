using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumCollection.Models
{
    public class Albums
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Recordlabel { get; set; }
        public string Image { get; set; }

        public virtual ICollection<Songs> Songs { get; set; }

        public virtual int ArtistID { get; set; }
        public virtual Artists Artists { get; set; }

        public Albums()
        {
        }

        public Albums(int id, string name, string recordLabel, int artistID, string image)
        {
            ID = id;
            Name = name;
            Recordlabel = recordLabel;
            ArtistID = artistID;
            Image = image;
        }

    }
}
