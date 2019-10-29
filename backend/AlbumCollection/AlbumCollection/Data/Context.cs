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
                },
                new Songs()
                {
                    ID = 2,
                    Songtitle = "Unfuckwittable",
                    Duration = "4:35",
                },
                 new Songs()
                 {
                     ID = 3,
                     Songtitle = "Just What I Am",
                     Duration = "3:48",

                 },
                  new Songs()
                  {
                      ID = 4,
                      Songtitle = "Young Lady",
                      Duration = "4:24",
 
                  },
                   new Songs()
                   {
                       ID = 5,
                       Songtitle = "King Wizard",
                       Duration = "4:16",
  
                   },
                    new Songs()
                    {
                        ID = 6,
                        Songtitle = "Immortal ",
                        Duration = "5:01",
   
                    },
                      new Songs()
                      {
                          ID = 7,
                          Songtitle = "Solo Duo, Part II ",
                          Duration = "3:34",

                      },
                      new Songs()
                      {
                          ID = 8,
                          Songtitle = "Girls",
                          Duration = "4:27",

                      },
                      new Songs()
                      {
                          ID = 9,
                          Songtitle = "New York City Rage Fest ",
                          Duration = "1:53",

                      },
                      new Songs()
                      {
                          ID = 10,
                          Songtitle = "Red Eye ",
                          Duration = "3:54",

                      },
                      new Songs()
                      {
                          ID = 11,
                          Songtitle = "Mad solar ",
                          Duration = "4:08",

                      },
                      new Songs()
                      {
                          ID = 12,
                          Songtitle = "Beez",
                          Duration = "3:13",

                      },
                      new Songs()
                      {
                          ID = 13,
                          Songtitle = "Brothers",
                          Duration = "4:41",

                      },
                      new Songs()
                      {
                          ID = 14,
                          Songtitle = "Burn Baby Burn",
                          Duration = "2:58",

                      },
                      new Songs()
                      {
                          ID = 15,
                          Songtitle = "Lord of the Sad and Lonely",
                          Duration = "2:46",

                      },
                      new Songs()
                      {
                          ID = 16,
                          Songtitle = "Cold Blooded",
                          Duration = "2:32",

                      },
                      new Songs()
                      {
                          ID = 17,
                          Songtitle = "Afterwards (Bring yo Friends)",
                          Duration = "9:03",

                      },
                      new Songs()
                      {
                          ID = 18,
                          Songtitle = "The Flight of the Moon Man",
                          Duration = "2:51",

                      },
                      new Songs()
                      {
                          ID = 19,
                          Songtitle = "The Heart Of Rock And Roll",
                          Duration = "5:05",

                      },
                      new Songs()
                      {
                          ID = 20,
                          Songtitle = "Heart And Soul",
                          Duration = "4:13",

                      },
                      new Songs()
                      {
                          ID = 21,
                          Songtitle = "Bad Is Bad",
                          Duration = "3:48",

                      },
                      new Songs()
                      {
                          ID = 22,
                          Songtitle = "I Want A New Drug",
                          Duration = "4:46",

                      },
                      new Songs()
                      {
                          ID = 23,
                          Songtitle = "Walking On A Thin Line",
                          Duration = "5:11",

                      },
                      new Songs()
                      {
                          ID = 24,
                          Songtitle = "Finally Found A Home",
                          Duration = "3:53",

                      },
                      new Songs()
                      {
                          ID = 25,
                          Songtitle = "If This Is It",
                          Duration = "3:53",

                      },
                      new Songs()
                      {
                          ID = 26,
                          Songtitle = "You Crack Me Up",
                          Duration = "3:43",

                      },
                      new Songs()
                      {
                          ID = 27,
                          Songtitle = "Honky Tonk Blues",
                          Duration = "3:21",

                      },
                      new Songs()
                      {
                          ID = 28,
                          Songtitle = "Intro",
                          Duration = "2:09",

                      },
                      new Songs()
                      {
                          ID = 29,
                          Songtitle = "January 28th",
                          Duration = "4:02",

                      },
                      new Songs()
                      {
                          ID = 30,
                          Songtitle = "Wet Dreamz",
                          Duration = "3:59",

                      },
                      new Songs()
                      {
                          ID = 31,
                          Songtitle = "03' Adolescence",
                          Duration = "4:24",

                      },
                      new Songs()
                      {
                          ID = 32,
                          Songtitle = "A Tale of 2 Citiez",
                          Duration = "4:29",

                      },
                      new Songs()
                      {
                          ID = 33,
                          Songtitle = "Fire Squad",
                          Duration = "4:48",

                      },
                      new Songs()
                      {
                          ID = 34,
                          Songtitle = "St. Tropez",
                          Duration = "4:17",

                      },
                      new Songs()
                      {
                          ID = 35,
                          Songtitle = "G.O.M.D.",
                          Duration = "5:01",

                      },
                      new Songs()
                      {
                          ID = 36,
                          Songtitle = "No Role Modelz",
                          Duration = "4:52",

                      },
                      new Songs()
                      {
                          ID = 37,
                          Songtitle = "Hello",
                          Duration = "3:39",

                      },
                      new Songs()
                      {
                          ID = 38,
                          Songtitle = "Apparently",
                          Duration = "4:53",

                      },
                      new Songs()
                      {
                          ID = 39,
                          Songtitle = "Love Yourz",
                          Duration = "3:31",

                      },
                      new Songs()
                      {
                          ID = 40,
                          Songtitle = "Note to Self",
                          Duration = "14:35",

                      },
                      new Songs()
                      {
                          ID = 41,
                          Songtitle = "I Never Really",
                          Duration = "4:15",

                      },
                      new Songs()
                      {
                          ID = 42,
                          Songtitle = "My Soul I",
                          Duration = "3:59",

                      },
                      new Songs()
                      {
                          ID = 43,
                          Songtitle = "Wandered Away",
                          Duration = "3:45",

                      },
                      new Songs()
                      {
                          ID = 44,
                          Songtitle = "If You Only",
                          Duration = "3:05",

                      },
                      new Songs()
                      {
                          ID = 45,
                          Songtitle = "Into the Cold",
                          Duration = "3:48",

                      },
                      new Songs()
                      {
                          ID = 46,
                          Songtitle = "Time to Relax",
                          Duration = "0:25",

                      },
                      new Songs()
                      {
                          ID = 47,
                          Songtitle = "Nitro",
                          Duration = "2:27",

                      },
                      new Songs()
                      {
                          ID = 48,
                          Songtitle = "Bad Habit",
                          Duration = "3:52",

                      },
                      new Songs()
                      {
                          ID = 49,
                          Songtitle = "Gotta Get Away",
                          Duration = "3:52",

                      },
                      new Songs()
                      {
                          ID = 50,
                          Songtitle = "Genocide",
                          Duration = "3:33",

                      },
                      new Songs()
                      {
                          ID = 51,
                          Songtitle = "Something to Believe In",
                          Duration = "3:17",

                      },
                      new Songs()
                      {
                          ID = 52,
                          Songtitle = "Come Out and Play",
                          Duration = "3:17",

                      },
                      new Songs()
                      {
                          ID = 53,
                          Songtitle = "Self Esteem",
                          Duration = "4:17",

                      },
                      new Songs()
                      {
                          ID = 54,
                          Songtitle = "It’ll Be a Long Time",
                          Duration = "2:43",

                      },
                      new Songs()
                      {
                          ID = 55,
                          Songtitle = "Killboy Powerhead",
                          Duration = "2:02",

                      },
                      new Songs()
                      {
                          ID = 56,
                          Songtitle = "What Happened to You?",
                          Duration = "2:12",

                      },
                      new Songs()
                      {
                          ID = 57,
                          Songtitle = "So Alone",
                          Duration = "1:17",

                      },
                      new Songs()
                      {
                          ID = 58,
                          Songtitle = "Not the One",
                          Duration = "2:54",

                      },
                      new Songs()
                      {
                          ID = 59,
                          Songtitle = "Smash",
                          Duration = "10:42",

                      },
                      new Songs()
                      {
                          ID = 60,
                          Songtitle = "Burnou",
                          Duration = "2:07",

                      },
                      new Songs()
                      {
                          ID = 61,
                          Songtitle = "Having a Blast",
                          Duration = "2:54",

                      },
                      new Songs()
                      {
                          ID = 62,
                          Songtitle = "Chump",
                          Duration = "2:54",

                      },
                      new Songs()
                      {
                          ID = 63,
                          Songtitle = "Longview",
                          Duration = "3:59",

                      },
                      new Songs()
                      {
                          ID = 64,
                          Songtitle = "Welcome to Paradise",
                          Duration = "3:44",

                      },
                      new Songs()
                      {
                          ID = 65,
                          Songtitle = "Pulling Teeth",
                          Duration = "2:31",

                      },
                      new Songs()
                      {
                          ID = 66,
                          Songtitle = "Basket Case",
                          Duration = "3:01",

                      },
                      new Songs()
                      {
                          ID = 67,
                          Songtitle = "She",
                          Duration = "2:14",

                      },
                      new Songs()
                      {
                          ID = 68,
                          Songtitle = "Sassafras Roots",
                          Duration = "2:37",

                      },
                      new Songs()
                      {
                          ID = 69,
                          Songtitle = "When I Come Around",
                          Duration = "2:58",

                      },
                      new Songs()
                      {
                          ID = 70,
                          Songtitle = "Coming Clean",
                          Duration = "1:34",

                      },
                      new Songs()
                      {
                          ID = 71,
                          Songtitle = "Emenius Sleepus",
                          Duration = "1:43",

                      },
                      new Songs()
                      {
                          ID = 72,
                          Songtitle = "In the End",
                          Duration = "1:46",

                      },
                      new Songs()
                      {
                          ID = 73,
                          Songtitle = "F.O.D.",
                          Duration = "5:46",

                      },
                      new Songs()
                      {
                          ID = 74,
                          Songtitle = "Where The Streets Have No Name",
                          Duration = "5:38",

                      },
                      new Songs()
                      {
                          ID = 75,
                          Songtitle = "I Still Haven’t Found What I’m Looking For",
                          Duration = "4:38",

                      },
                      new Songs()
                      {
                          ID = 76,
                          Songtitle = "With or Without You",
                          Duration = "4:56",

                      },
                      new Songs()
                      {
                          ID = 77,
                          Songtitle = "Bullet the Blue Sky",
                          Duration = "4:32",

                      },
                      new Songs()
                      {
                          ID = 78,
                          Songtitle = "Running to Stand STill",
                          Duration = "4:18",

                      },
                      new Songs()
                      {
                          ID = 79,
                          Songtitle = "Red Hill Mining Town",
                          Duration = "4:54",

                      },
                      new Songs()
                      {
                          ID = 80,
                          Songtitle = "In God’s Country",
                          Duration = "2:57",

                      },
                      new Songs()
                      {
                          ID = 81,
                          Songtitle = "Trip Through Your Wires",
                          Duration = "3:33",
                      },
                      new Songs()
                      {
                          ID = 82,
                          Songtitle = "One Tree Hill",
                          Duration = "5:23",
                      },
                      new Songs()
                      {
                          ID = 83,
                          Songtitle = "Exit",
                          Duration = "4:13",
                      },
                      new Songs()
                      {
                          ID = 84,
                          Songtitle = "Mothers of the Disappeared",
                          Duration = "5:12",
                      }

                    );

        }


    }
}
