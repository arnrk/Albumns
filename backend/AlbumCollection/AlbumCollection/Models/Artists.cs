using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumCollection.Models
{
    public class Artists
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Recordlabel { get; set; }
        public string Hometown { get; set; }
   

        public Artists()
        {
        }


        public Artists(int id, string name, int age, string recordLabel, string hometown)
        {
        ID = id;
        Name = name;
        Age = age;
        Recordlabel = recordLabel;
        Hometown = hometown;
        }


    }


}
