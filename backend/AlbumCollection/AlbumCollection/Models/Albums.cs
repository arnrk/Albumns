using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumCollection.Models
{
    public class Albums
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Recordlabel { get; set; }

        public virtual ICollection<Songs> Songs { get; set; }

        public virtual int ArtistID { get; set; }
        public virtual Artists Artists { get; set; }

        public Albums()
        {
        }

        public Albums(int id, string title, string recordLabel)
        {
            ID = id;
            Title = title;
            Recordlabel = recordLabel;

        }

    }
}
