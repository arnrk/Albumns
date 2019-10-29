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
