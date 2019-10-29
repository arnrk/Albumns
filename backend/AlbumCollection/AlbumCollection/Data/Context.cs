using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlbumCollection.Models;
using Microsoft.EntityFrameworkCore;

namespace AlbumCollection.Data
{
    public class Context : DbContext
    {
        public DbSet<Albums> Albums { get; set; }
        public DbSet<Artists> Artists { get; set; }
        public DbSet<Songs> Songs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Songs>().HasData(
                new Songs()
                {
                    ID = 1,
                    Songtitle = "the resurrection of scott mescud",
                    Duration = "2:40",
                    Link = "",
                },
                new Songs()
                {
                    ID = 2,
                    Songtitle = "Unfuckwittable",
                    Duration = "4:35",
                    Link = "",
                },
                 new Songs()
                 {
                     ID = 3,
                     Songtitle = "Just What I Am",
                     Duration = "3:48",
                     Link = "",
                 },
                  new Songs()
                  {
                      ID = 4,
                      Songtitle = "Young Lady",
                      Duration = "4:24",
                      Link = "",
                  },
                   new Songs()
                   {
                       ID = 5,
                       Songtitle = "King Wizard",
                       Duration = "4:16",
                       Link = "",
                   },
                    new Songs()
                    {
                        ID = 6,
                        Songtitle = "Immortal ",
                        Duration = "5:01",
                        Link = "",
                    },
                      new Songs()
                      {
                          ID = 7,
                          Songtitle = "Solo Duo, Part II ",
                          Duration = "3:34",
                          Link = "",
                      },
                      new Songs()
                      {
                          ID = 8,
                          Songtitle = "Girls",
                          Duration = "4:27",
                          Link = "",
                      },
                      new Songs()
                      {
                          ID = 9,
                          Songtitle = "New York City Rage Fest ",
                          Duration = "1:53",
                          Link = "",
                      },
                      new Songs()
                      {
                          ID = 10,
                          Songtitle = "Red Eye ",
                          Duration = "3:54",
                          Link = "",
                      },
                      new Songs()
                      {
                          ID = 11,
                          Songtitle = "Mad solar ",
                          Duration = "4:08",
                          Link = "",
                      },
                      new Songs()
                      {
                          ID = 12,
                          Songtitle = "Beez",
                          Duration = "3:13",
                          Link = "",
                      },
                      new Songs()
                      {
                          ID = 13,
                          Songtitle = "Brothers",
                          Duration = "4:41",
                          Link = "",
                      },
                      new Songs()
                      {
                          ID = 14,
                          Songtitle = "Burn Baby Burn",
                          Duration = "2:58",
                          Link = "",
                      },
                      new Songs()
                      {
                          ID = 15,
                          Songtitle = "Lord of the Sad and Lonely",
                          Duration = "2:46",
                          Link = "",
                      },
                      new Songs()
                      {
                          ID = 16,
                          Songtitle = "Cold Blooded",
                          Duration = "2:32",
                          Link = "",
                      },
                      new Songs()
                      {
                          ID = 6,
                          Songtitle = "Immortal ",
                          Duration = "5:01",
                          Link = "",
                      },
                      new Songs()
                      {
                          ID = 6,
                          Songtitle = "Immortal ",
                          Duration = "5:01",
                          Link = "",
                      },
                      new Songs()
                      {
                          ID = 6,
                          Songtitle = "Immortal ",
                          Duration = "5:01",
                          Link = "",
                      },
                      new Songs()
                      {
                          ID = 6,
                          Songtitle = "Immortal ",
                          Duration = "5:01",
                          Link = "",
                      },
                      new Songs()
                      {
                          ID = 6,
                          Songtitle = "Immortal ",
                          Duration = "5:01",
                          Link = "",
                      },


                    );

        }


    }
}
