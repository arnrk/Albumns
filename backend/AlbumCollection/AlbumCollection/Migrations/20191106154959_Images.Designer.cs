﻿// <auto-generated />
using System;
using AlbumCollection.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AlbumCollection.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20191106154959_Images")]
    partial class Images
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AlbumCollection.Models.Albums", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ArtistID");

                    b.Property<int?>("ArtistsID");

                    b.Property<string>("Image");

                    b.Property<string>("Name");

                    b.Property<string>("Recordlabel");

                    b.HasKey("ID");

                    b.HasIndex("ArtistsID");

                    b.ToTable("Albums");

                    b.HasData(
                        new { ID = 1, ArtistID = 1, Image = "/images/indicudalbum.jpeg", Name = "Indicud", Recordlabel = "Wicked Awesome" },
                        new { ID = 2, ArtistID = 2, Image = "/images/Sports-Huey-Lewis.jpg", Name = "Sports", Recordlabel = "Chrysalis Records" },
                        new { ID = 3, ArtistID = 3, Image = "/images/Jcolealbum.jpeg", Name = "2014 Forest Hills Drive", Recordlabel = "Dreamville" },
                        new { ID = 4, ArtistID = 4, Image = "/images/wanderedaway.jpg", Name = "Wandered Away", Recordlabel = "Half Awake" },
                        new { ID = 5, ArtistID = 5, Image = "/images/offspringSmashalbumcover.jpg", Name = "Smash", Recordlabel = "Nitro Records" },
                        new { ID = 6, ArtistID = 6, Image = "/images/greendayDookiealbumcover.jpg", Name = "Dookie", Recordlabel = "Lookout!" },
                        new { ID = 7, ArtistID = 7, Image = "/images/U2album.jpg", Name = "Joshua Tree", Recordlabel = "Island Records" }
                    );
                });

            modelBuilder.Entity("AlbumCollection.Models.Artists", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age");

                    b.Property<string>("Hometown");

                    b.Property<string>("Image");

                    b.Property<string>("Name");

                    b.Property<string>("Recordlabel");

                    b.HasKey("ID");

                    b.ToTable("Artists");

                    b.HasData(
                        new { ID = 1, Age = 35, Hometown = "Cleveland, OH", Image = "/images/kidcudiartistpic.jpg", Name = "Kid Cudi", Recordlabel = "Wicked Awesome" },
                        new { ID = 2, Age = 40, Hometown = "San Francisco, CA", Image = "/images/Huey-Lewis.jpg", Name = "Heuy Lewis And The News", Recordlabel = "Chrysalis Records" },
                        new { ID = 3, Age = 34, Hometown = "Fayetteville, NC", Image = "/images/JCole.jpg", Name = "J. Cole", Recordlabel = "Dreamville" },
                        new { ID = 4, Age = 23, Hometown = "Stockholm, Sweden", Image = "/images/AnnaLeone.jpg", Name = "Anna Leone", Recordlabel = "Half Awake" },
                        new { ID = 5, Age = 35, Hometown = "Garden Grove, CA", Image = "/images/offspringbandpic.jpg", Name = "The Offspring", Recordlabel = "Nitro Records" },
                        new { ID = 6, Age = 33, Hometown = "Oakland, CA", Image = "/images/greendaybandpic.jpg", Name = "Green Day", Recordlabel = "Lookout!" },
                        new { ID = 7, Age = 32, Hometown = "Dublin, Ireland", Image = "/images/U2.jpg", Name = "U2", Recordlabel = "Island Records" }
                    );
                });

            modelBuilder.Entity("AlbumCollection.Models.Songs", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AlbumID");

                    b.Property<int?>("AlbumsID");

                    b.Property<string>("Duration");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.HasIndex("AlbumsID");

                    b.ToTable("Songs");

                    b.HasData(
                        new { ID = 1, AlbumID = 1, Duration = "2:40", Name = "the resurrection of scott mescud" },
                        new { ID = 2, AlbumID = 1, Duration = "4:35", Name = "Unfuckwittable" },
                        new { ID = 3, AlbumID = 1, Duration = "3:48", Name = "Just What I Am" },
                        new { ID = 4, AlbumID = 1, Duration = "4:24", Name = "Young Lady" },
                        new { ID = 5, AlbumID = 1, Duration = "4:16", Name = "King Wizard" },
                        new { ID = 6, AlbumID = 1, Duration = "5:01", Name = "Immortal " },
                        new { ID = 7, AlbumID = 1, Duration = "3:34", Name = "Solo Duo, Part II " },
                        new { ID = 8, AlbumID = 1, Duration = "4:27", Name = "Girls" },
                        new { ID = 9, AlbumID = 1, Duration = "1:53", Name = "New York City Rage Fest " },
                        new { ID = 10, AlbumID = 1, Duration = "3:54", Name = "Red Eye " },
                        new { ID = 11, AlbumID = 1, Duration = "4:08", Name = "Mad solar " },
                        new { ID = 12, AlbumID = 1, Duration = "3:13", Name = "Beez" },
                        new { ID = 13, AlbumID = 1, Duration = "4:41", Name = "Brothers" },
                        new { ID = 14, AlbumID = 1, Duration = "2:58", Name = "Burn Baby Burn" },
                        new { ID = 15, AlbumID = 1, Duration = "2:46", Name = "Lord of the Sad and Lonely" },
                        new { ID = 16, AlbumID = 1, Duration = "2:32", Name = "Cold Blooded" },
                        new { ID = 17, AlbumID = 1, Duration = "9:03", Name = "Afterwards (Bring yo Friends)" },
                        new { ID = 18, AlbumID = 1, Duration = "2:51", Name = "The Flight of the Moon Man" },
                        new { ID = 19, AlbumID = 2, Duration = "5:05", Name = "The Heart Of Rock And Roll" },
                        new { ID = 20, AlbumID = 2, Duration = "4:13", Name = "Heart And Soul" },
                        new { ID = 21, AlbumID = 2, Duration = "3:48", Name = "Bad Is Bad" },
                        new { ID = 22, AlbumID = 2, Duration = "4:46", Name = "I Want A New Drug" },
                        new { ID = 23, AlbumID = 2, Duration = "5:11", Name = "Walking On A Thin Line" },
                        new { ID = 24, AlbumID = 2, Duration = "3:53", Name = "Finally Found A Home" },
                        new { ID = 25, AlbumID = 2, Duration = "3:53", Name = "If This Is It" },
                        new { ID = 26, AlbumID = 2, Duration = "3:43", Name = "You Crack Me Up" },
                        new { ID = 27, AlbumID = 2, Duration = "3:21", Name = "Honky Tonk Blues" },
                        new { ID = 28, AlbumID = 3, Duration = "2:09", Name = "Intro" },
                        new { ID = 29, AlbumID = 3, Duration = "4:02", Name = "January 28th" },
                        new { ID = 30, AlbumID = 3, Duration = "3:59", Name = "Wet Dreamz" },
                        new { ID = 31, AlbumID = 3, Duration = "4:24", Name = "03' Adolescence" },
                        new { ID = 32, AlbumID = 3, Duration = "4:29", Name = "A Tale of 2 Citiez" },
                        new { ID = 33, AlbumID = 3, Duration = "4:48", Name = "Fire Squad" },
                        new { ID = 34, AlbumID = 3, Duration = "4:17", Name = "St. Tropez" },
                        new { ID = 35, AlbumID = 3, Duration = "5:01", Name = "G.O.M.D." },
                        new { ID = 36, AlbumID = 3, Duration = "4:52", Name = "No Role Modelz" },
                        new { ID = 37, AlbumID = 3, Duration = "3:39", Name = "Hello" },
                        new { ID = 38, AlbumID = 3, Duration = "4:53", Name = "Apparently" },
                        new { ID = 39, AlbumID = 3, Duration = "3:31", Name = "Love Yourz" },
                        new { ID = 40, AlbumID = 3, Duration = "14:35", Name = "Note to Self" },
                        new { ID = 41, AlbumID = 4, Duration = "4:15", Name = "I Never Really" },
                        new { ID = 42, AlbumID = 4, Duration = "3:59", Name = "My Soul I" },
                        new { ID = 43, AlbumID = 4, Duration = "3:45", Name = "Wandered Away" },
                        new { ID = 44, AlbumID = 4, Duration = "3:05", Name = "If You Only" },
                        new { ID = 45, AlbumID = 4, Duration = "3:48", Name = "Into the Cold" },
                        new { ID = 46, AlbumID = 5, Duration = "0:25", Name = "Time to Relax" },
                        new { ID = 47, AlbumID = 5, Duration = "2:27", Name = "Nitro" },
                        new { ID = 48, AlbumID = 5, Duration = "3:52", Name = "Bad Habit" },
                        new { ID = 49, AlbumID = 5, Duration = "3:52", Name = "Gotta Get Away" },
                        new { ID = 50, AlbumID = 5, Duration = "3:33", Name = "Genocide" },
                        new { ID = 51, AlbumID = 5, Duration = "3:17", Name = "Something to Believe In" },
                        new { ID = 52, AlbumID = 5, Duration = "3:17", Name = "Come Out and Play" },
                        new { ID = 53, AlbumID = 5, Duration = "4:17", Name = "Self Esteem" },
                        new { ID = 54, AlbumID = 5, Duration = "2:43", Name = "It’ll Be a Long Time" },
                        new { ID = 55, AlbumID = 5, Duration = "2:02", Name = "Killboy Powerhead" },
                        new { ID = 56, AlbumID = 5, Duration = "2:12", Name = "What Happened to You?" },
                        new { ID = 57, AlbumID = 5, Duration = "1:17", Name = "So Alone" },
                        new { ID = 58, AlbumID = 5, Duration = "2:54", Name = "Not the One" },
                        new { ID = 59, AlbumID = 5, Duration = "10:42", Name = "Smash" },
                        new { ID = 60, AlbumID = 6, Duration = "2:07", Name = "Burnou" },
                        new { ID = 61, AlbumID = 6, Duration = "2:54", Name = "Having a Blast" },
                        new { ID = 62, AlbumID = 6, Duration = "2:54", Name = "Chump" },
                        new { ID = 63, AlbumID = 6, Duration = "3:59", Name = "Longview" },
                        new { ID = 64, AlbumID = 6, Duration = "3:44", Name = "Welcome to Paradise" },
                        new { ID = 65, AlbumID = 6, Duration = "2:31", Name = "Pulling Teeth" },
                        new { ID = 66, AlbumID = 6, Duration = "3:01", Name = "Basket Case" },
                        new { ID = 67, AlbumID = 6, Duration = "2:14", Name = "She" },
                        new { ID = 68, AlbumID = 6, Duration = "2:37", Name = "Sassafras Roots" },
                        new { ID = 69, AlbumID = 6, Duration = "2:58", Name = "When I Come Around" },
                        new { ID = 70, AlbumID = 6, Duration = "1:34", Name = "Coming Clean" },
                        new { ID = 71, AlbumID = 6, Duration = "1:43", Name = "Emenius Sleepus" },
                        new { ID = 72, AlbumID = 6, Duration = "1:46", Name = "In the End" },
                        new { ID = 73, AlbumID = 6, Duration = "5:46", Name = "F.O.D." },
                        new { ID = 74, AlbumID = 7, Duration = "5:38", Name = "Where The Streets Have No Name" },
                        new { ID = 75, AlbumID = 7, Duration = "4:38", Name = "I Still Haven’t Found What I’m Looking For" },
                        new { ID = 76, AlbumID = 7, Duration = "4:56", Name = "With or Without You" },
                        new { ID = 77, AlbumID = 7, Duration = "4:32", Name = "Bullet the Blue Sky" },
                        new { ID = 78, AlbumID = 7, Duration = "4:18", Name = "Running to Stand STill" },
                        new { ID = 79, AlbumID = 7, Duration = "4:54", Name = "Red Hill Mining Town" },
                        new { ID = 80, AlbumID = 7, Duration = "2:57", Name = "In God’s Country" },
                        new { ID = 81, AlbumID = 7, Duration = "3:33", Name = "Trip Through Your Wires" },
                        new { ID = 82, AlbumID = 7, Duration = "5:23", Name = "One Tree Hill" },
                        new { ID = 83, AlbumID = 7, Duration = "4:13", Name = "Exit" },
                        new { ID = 84, AlbumID = 7, Duration = "5:12", Name = "Mothers of the Disappeared" }
                    );
                });

            modelBuilder.Entity("AlbumCollection.Models.Albums", b =>
                {
                    b.HasOne("AlbumCollection.Models.Artists", "Artists")
                        .WithMany("Albums")
                        .HasForeignKey("ArtistsID");
                });

            modelBuilder.Entity("AlbumCollection.Models.Songs", b =>
                {
                    b.HasOne("AlbumCollection.Models.Albums", "Albums")
                        .WithMany("Songs")
                        .HasForeignKey("AlbumsID");
                });
#pragma warning restore 612, 618
        }
    }
}
