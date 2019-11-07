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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=AlbumCollection;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connectionString)
                          .UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Artists>().HasData(
                new Artists()
                {
                    ID = 1,
                    Name = "Kid Cudi",
                    Age = 35,
                    Recordlabel = "Wicked Awesome",
                    Hometown = "Cleveland, OH",
                    Image = "/images/kidcudiartistpic.jpg"
                },
                new Artists()
                {
                    ID = 2,
                    Name = "Heuy Lewis And The News",
                    Age = 40,
                    Recordlabel = "Chrysalis Records",
                    Hometown = "San Francisco, CA",
                    Image = "/images/Huey-Lewis.jpg"
                },
                new Artists()
                {
                    ID = 3,
                    Name = "J. Cole",
                    Age = 34,
                    Recordlabel = "Dreamville",
                    Hometown = "Fayetteville, NC",
                    Image = "/images/JCole.jpg"
                },
                new Artists()
                {
                    ID = 4,
                    Name = "Anna Leone",
                    Age = 23,
                    Recordlabel = "Half Awake",
                    Hometown = "Stockholm, Sweden",
                    Image = "/images/AnnaLeone.jpg"
                },
                new Artists()
                {
                    ID = 5,
                    Name = "The Offspring",
                    Age = 35,
                    Recordlabel = "Nitro Records",
                    Hometown = "Garden Grove, CA",
                    Image = "/images/offspringbandpic.jpg"
                },
                new Artists()
                {
                    ID = 6,
                    Name = "Green Day",
                    Age = 33,
                    Recordlabel = "Lookout!",
                    Hometown = "Oakland, CA",
                    Image = "/images/greendaybandpic.jpg"
                },
                new Artists()
                {
                    ID = 7,
                    Name = "U2",
                    Age = 32,
                    Recordlabel = "Island Records",
                    Hometown = "Dublin, Ireland",
                    Image = "/images/U2.jpg"
                });
            modelBuilder.Entity<Albums>().HasData(
                new Albums()
                {
                    ID = 1,
                    Name ="Indicud",
                    Recordlabel = "Wicked Awesome",
                    ArtistID = 1,
                    Image = "/images/indicudalbum.jpeg"
                },
                new Albums()
                {
                    ID = 2,
                    Name ="Sports",
                    Recordlabel = "Chrysalis Records",
                    ArtistID = 2,
                    Image = "/images/Sports-Huey-Lewis.jpg"

                },
                new Albums()
                {
                    ID = 3,
                    Name ="2014 Forest Hills Drive",
                    Recordlabel = "Dreamville",
                    ArtistID = 3,
                    Image = "/images/Jcolealbum.jpeg"
                },
                new Albums()
                {
                    ID = 4,
                    Name ="Wandered Away",
                    Recordlabel = "Half Awake",
                    ArtistID = 4,
                    Image = "/images/wanderedaway.jpg"
                },
                new Albums()
                {
                    ID = 5,
                    Name ="Smash",
                    Recordlabel = "Nitro Records",
                    ArtistID = 5,
                    Image = "/images/offspringSmashalbumcover.jpg"
                },
                new Albums()
                {
                    ID = 6,
                    Name ="Dookie",
                    Recordlabel = "Lookout!",
                    ArtistID = 6,
                    Image = "/images/greendayDookiealbumcover.jpg"
                },
                new Albums()
                {
                    ID = 7,
                    Name ="Joshua Tree",
                    Recordlabel = "Island Records",
                    ArtistID = 7,
                    Image = "/images/U2album.jpg"
                }
                );
        
            modelBuilder.Entity<Songs>().HasData(
                new Songs()
                {
                    ID = 1,
                    Name = "the resurrection of scott mescud",
                    Duration = "2:40",
                    AlbumID = 1
                },
                new Songs()
                {
                    ID = 2,
                    Name = "Unfuckwittable",
                    Duration = "4:35",
                    AlbumID = 1

                },
                 new Songs()
                 {
                     ID = 3,
                     Name = "Just What I Am",
                     Duration = "3:48",
                     AlbumID = 1

                 },
                  new Songs()
                  {
                      ID = 4,
                      Name = "Young Lady",
                      Duration = "4:24",
                      AlbumID = 1

                  },
                   new Songs()
                   {
                       ID = 5,
                       Name = "King Wizard",
                       Duration = "4:16",
                       AlbumID = 1

                   },
                    new Songs()
                    {
                        ID = 6,
                        Name = "Immortal ",
                        Duration = "5:01",
                        AlbumID = 1

                    },
                      new Songs()
                      {
                          ID = 7,
                          Name = "Solo Duo, Part II ",
                          Duration = "3:34",
                          AlbumID = 1

                      },
                      new Songs()
                      {
                          ID = 8,
                          Name = "Girls",
                          Duration = "4:27",
                          AlbumID = 1

                      },
                      new Songs()
                      {
                          ID = 9,
                          Name = "New York City Rage Fest ",
                          Duration = "1:53",
                          AlbumID = 1

                      },
                      new Songs()
                      {
                          ID = 10,
                          Name = "Red Eye ",
                          Duration = "3:54",
                          AlbumID = 1

                      },
                      new Songs()
                      {
                          ID = 11,
                          Name = "Mad solar ",
                          Duration = "4:08",
                          AlbumID = 1

                      },
                      new Songs()
                      {
                          ID = 12,
                          Name = "Beez",
                          Duration = "3:13",
                          AlbumID = 1

                      },
                      new Songs()
                      {
                          ID = 13,
                          Name = "Brothers",
                          Duration = "4:41",
                          AlbumID = 1

                      },
                      new Songs()
                      {
                          ID = 14,
                          Name = "Burn Baby Burn",
                          Duration = "2:58",
                          AlbumID = 1

                      },
                      new Songs()
                      {
                          ID = 15,
                          Name = "Lord of the Sad and Lonely",
                          Duration = "2:46",
                          AlbumID = 1

                      },
                      new Songs()
                      {
                          ID = 16,
                          Name = "Cold Blooded",
                          Duration = "2:32",
                          AlbumID = 1

                      },
                      new Songs()
                      {
                          ID = 17,
                          Name = "Afterwards (Bring yo Friends)",
                          Duration = "9:03",
                          AlbumID = 1

                      },
                      new Songs()
                      {
                          ID = 18,
                          Name = "The Flight of the Moon Man",
                          Duration = "2:51",
                          AlbumID = 1

                      },
                      new Songs()
                      {
                          ID = 19,
                          Name = "The Heart Of Rock And Roll",
                          Duration = "5:05",
                          AlbumID = 2

                      },
                      new Songs()
                      {
                          ID = 20,
                          Name = "Heart And Soul",
                          Duration = "4:13",
                          AlbumID = 2

                      },
                      new Songs()
                      {
                          ID = 21,
                          Name = "Bad Is Bad",
                          Duration = "3:48",
                          AlbumID = 2

                      },
                      new Songs()
                      {
                          ID = 22,
                          Name = "I Want A New Drug",
                          Duration = "4:46",
                          AlbumID = 2

                      },
                      new Songs()
                      {
                          ID = 23,
                          Name = "Walking On A Thin Line",
                          Duration = "5:11",
                          AlbumID = 2

                      },
                      new Songs()
                      {
                          ID = 24,
                          Name = "Finally Found A Home",
                          Duration = "3:53",
                          AlbumID = 2

                      },
                      new Songs()
                      {
                          ID = 25,
                          Name = "If This Is It",
                          Duration = "3:53",
                          AlbumID = 2

                      },
                      new Songs()
                      {
                          ID = 26,
                          Name = "You Crack Me Up",
                          Duration = "3:43",
                          AlbumID = 2

                      },
                      new Songs()
                      {
                          ID = 27,
                          Name = "Honky Tonk Blues",
                          Duration = "3:21",
                          AlbumID = 2

                      },
                      new Songs()
                      {
                          ID = 28,
                          Name = "Intro",
                          Duration = "2:09",
                          AlbumID = 3

                      },
                      new Songs()
                      {
                          ID = 29,
                          Name = "January 28th",
                          Duration = "4:02",
                          AlbumID = 3

                      },
                      new Songs()
                      {
                          ID = 30,
                          Name = "Wet Dreamz",
                          Duration = "3:59",
                          AlbumID = 3

                      },
                      new Songs()
                      {
                          ID = 31,
                          Name = "03' Adolescence",
                          Duration = "4:24",
                          AlbumID = 3

                      },
                      new Songs()
                      {
                          ID = 32,
                          Name = "A Tale of 2 Citiez",
                          Duration = "4:29",
                          AlbumID = 3

                      },
                      new Songs()
                      {
                          ID = 33,
                          Name = "Fire Squad",
                          Duration = "4:48",
                          AlbumID = 3

                      },
                      new Songs()
                      {
                          ID = 34,
                          Name = "St. Tropez",
                          Duration = "4:17",
                          AlbumID = 3

                      },
                      new Songs()
                      {
                          ID = 35,
                          Name = "G.O.M.D.",
                          Duration = "5:01",
                          AlbumID = 3

                      },
                      new Songs()
                      {
                          ID = 36,
                          Name = "No Role Modelz",
                          Duration = "4:52",
                          AlbumID = 3

                      },
                      new Songs()
                      {
                          ID = 37,
                          Name = "Hello",
                          Duration = "3:39",
                          AlbumID = 3

                      },
                      new Songs()
                      {
                          ID = 38,
                          Name = "Apparently",
                          Duration = "4:53",
                          AlbumID = 3

                      },
                      new Songs()
                      {
                          ID = 39,
                          Name = "Love Yourz",
                          Duration = "3:31",
                          AlbumID = 3

                      },
                      new Songs()
                      {
                          ID = 40,
                          Name = "Note to Self",
                          Duration = "14:35",
                          AlbumID = 3

                      },
                      new Songs()
                      {
                          ID = 41,
                          Name = "I Never Really",
                          Duration = "4:15",
                          AlbumID = 4
                      },
                      new Songs()
                      {
                          ID = 42,
                          Name = "My Soul I",
                          Duration = "3:59",
                          AlbumID = 4

                      },
                      new Songs()
                      {
                          ID = 43,
                          Name = "Wandered Away",
                          Duration = "3:45",
                          AlbumID = 4

                      },
                      new Songs()
                      {
                          ID = 44,
                          Name = "If You Only",
                          Duration = "3:05",
                          AlbumID = 4

                      },
                      new Songs()
                      {
                          ID = 45,
                          Name = "Into the Cold",
                          Duration = "3:48",
                          AlbumID = 4

                      },
                      new Songs()
                      {
                          ID = 46,
                          Name = "Time to Relax",
                          Duration = "0:25",
                          AlbumID = 5

                      },
                      new Songs()
                      {
                          ID = 47,
                          Name = "Nitro",
                          Duration = "2:27",
                          AlbumID = 5

                      },
                      new Songs()
                      {
                          ID = 48,
                          Name = "Bad Habit",
                          Duration = "3:52",
                          AlbumID = 5

                      },
                      new Songs()
                      {
                          ID = 49,
                          Name = "Gotta Get Away",
                          Duration = "3:52",
                          AlbumID = 5

                      },
                      new Songs()
                      {
                          ID = 50,
                          Name = "Genocide",
                          Duration = "3:33",
                          AlbumID = 5

                      },
                      new Songs()
                      {
                          ID = 51,
                          Name = "Something to Believe In",
                          Duration = "3:17",
                          AlbumID = 5

                      },
                      new Songs()
                      {
                          ID = 52,
                          Name = "Come Out and Play",
                          Duration = "3:17",
                          AlbumID = 5

                      },
                      new Songs()
                      {
                          ID = 53,
                          Name = "Self Esteem",
                          Duration = "4:17",
                          AlbumID = 5

                      },
                      new Songs()
                      {
                          ID = 54,
                          Name = "It’ll Be a Long Time",
                          Duration = "2:43",
                          AlbumID = 5

                      },
                      new Songs()
                      {
                          ID = 55,
                          Name = "Killboy Powerhead",
                          Duration = "2:02",
                          AlbumID = 5

                      },
                      new Songs()
                      {
                          ID = 56,
                          Name = "What Happened to You?",
                          Duration = "2:12",
                          AlbumID = 5

                      },
                      new Songs()
                      {
                          ID = 57,
                          Name = "So Alone",
                          Duration = "1:17",
                          AlbumID = 5

                      },
                      new Songs()
                      {
                          ID = 58,
                          Name = "Not the One",
                          Duration = "2:54",
                          AlbumID = 5

                      },
                      new Songs()
                      {
                          ID = 59,
                          Name = "Smash",
                          Duration = "10:42",
                          AlbumID = 5

                      },
                      new Songs()
                      {
                          ID = 60,
                          Name = "Burnou",
                          Duration = "2:07",
                          AlbumID = 6

                      },
                      new Songs()
                      {
                          ID = 61,
                          Name = "Having a Blast",
                          Duration = "2:54",
                          AlbumID = 6

                      },
                      new Songs()
                      {
                          ID = 62,
                          Name = "Chump",
                          Duration = "2:54",
                          AlbumID = 6

                      },
                      new Songs()
                      {
                          ID = 63,
                          Name = "Longview",
                          Duration = "3:59",
                          AlbumID = 6

                      },
                      new Songs()
                      {
                          ID = 64,
                          Name = "Welcome to Paradise",
                          Duration = "3:44",
                          AlbumID = 6

                      },
                      new Songs()
                      {
                          ID = 65,
                          Name = "Pulling Teeth",
                          Duration = "2:31",
                          AlbumID = 6

                      },
                      new Songs()
                      {
                          ID = 66,
                          Name = "Basket Case",
                          Duration = "3:01",
                          AlbumID = 6

                      },
                      new Songs()
                      {
                          ID = 67,
                          Name = "She",
                          Duration = "2:14",
                          AlbumID = 6

                      },
                      new Songs()
                      {
                          ID = 68,
                          Name = "Sassafras Roots",
                          Duration = "2:37",
                          AlbumID = 6

                      },
                      new Songs()
                      {
                          ID = 69,
                          Name = "When I Come Around",
                          Duration = "2:58",
                          AlbumID = 6

                      },
                      new Songs()
                      {
                          ID = 70,
                          Name = "Coming Clean",
                          Duration = "1:34",
                          AlbumID = 6

                      },
                      new Songs()
                      {
                          ID = 71,
                          Name = "Emenius Sleepus",
                          Duration = "1:43",
                          AlbumID = 6

                      },
                      new Songs()
                      {
                          ID = 72,
                          Name = "In the End",
                          Duration = "1:46",
                          AlbumID = 6

                      },
                      new Songs()
                      {
                          ID = 73,
                          Name = "F.O.D.",
                          Duration = "5:46",
                          AlbumID = 6

                      },
                      new Songs()
                      {
                          ID = 74,
                          Name = "Where The Streets Have No Name",
                          Duration = "5:38",
                          AlbumID = 7
                      },
                      new Songs()
                      {
                          ID = 75,
                          Name = "I Still Haven’t Found What I’m Looking For",
                          Duration = "4:38",
                          AlbumID = 7

                      },
                      new Songs()
                      {
                          ID = 76,
                          Name = "With or Without You",
                          Duration = "4:56",
                          AlbumID = 7

                      },
                      new Songs()
                      {
                          ID = 77,
                          Name = "Bullet the Blue Sky",
                          Duration = "4:32",
                          AlbumID = 7

                      },
                      new Songs()
                      {
                          ID = 78,
                          Name = "Running to Stand STill",
                          Duration = "4:18",
                          AlbumID = 7

                      },
                      new Songs()
                      {
                          ID = 79,
                          Name = "Red Hill Mining Town",
                          Duration = "4:54",
                          AlbumID = 7

                      },
                      new Songs()
                      {
                          ID = 80,
                          Name = "In God’s Country",
                          Duration = "2:57",
                          AlbumID = 7

                      },
                      new Songs()
                      {
                          ID = 81,
                          Name = "Trip Through Your Wires",
                          Duration = "3:33",
                          AlbumID = 7

                      },
                      new Songs()
                      {
                          ID = 82,
                          Name = "One Tree Hill",
                          Duration = "5:23",
                          AlbumID = 7

                      },
                      new Songs()
                      {
                          ID = 83,
                          Name = "Exit",
                          Duration = "4:13",
                          AlbumID = 7

                      },
                      new Songs()
                      {
                          ID = 84,
                          Name = "Mothers of the Disappeared",
                          Duration = "5:12",
                          AlbumID = 7

                      }

                    );

        }


    }
}
