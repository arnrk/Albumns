using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AlbumCollection.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artists",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Recordlabel = table.Column<string>(nullable: true),
                    Hometown = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artists", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Albums",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Recordlabel = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    ArtistsID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Albums_Artists_ArtistsID",
                        column: x => x.ArtistsID,
                        principalTable: "Artists",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Songs",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Duration = table.Column<string>(nullable: true),
                    AlbumsID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Songs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Songs_Albums_AlbumsID",
                        column: x => x.AlbumsID,
                        principalTable: "Albums",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ID", "Age", "Hometown", "Image", "Name", "Recordlabel" },
                values: new object[,]
                {
                    { 1, 35, "Cleveland, OH", "/images/kidcudiartistpic.jpg", "Kid Cudi", "Wicked Awesome" },
                    { 2, 40, "San Francisco, CA", "/images/Huey-Lewis.jpg", "Heuy Lewis And The News", "Chrysalis Records" },
                    { 3, 34, "Fayetteville, NC", "/images/JCole.jpg", "J. Cole", "Dreamville" },
                    { 4, 23, "Stockholm, Sweden", "/images/AnnaLeone.jpg", "Anna Leone", "Half Awake" },
                    { 5, 35, "Garden Grove, CA", "/images/offspringbandpic.jpg", "The Offspring", "Nitro Records" },
                    { 6, 33, "Oakland, CA", "/images/greendaybandpic.jpg", "Green Day", "Lookout!" },
                    { 7, 32, "Dublin, Ireland", "/images/U2.jpg", "U2", "Island Records" }
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "ID", "ArtistsID", "Image", "Name", "Recordlabel" },
                values: new object[,]
                {
                    { 1, 1, "/images/indicudalbum.jpeg", "Indicud", "Wicked Awesome" },
                    { 2, 2, "/images/Sports-Huey-Lewis.jpg", "Sports", "Chrysalis Records" },
                    { 3, 3, "/images/Jcolealbum.jpg", "2014 Forest Hills Drive", "Dreamville" },
                    { 4, 4, "/images/wanderedaway.jpg", "Wandered Away", "Half Awake" },
                    { 5, 5, "/images/offspringSmashalbumcover.jpg", "Smash", "Nitro Records" },
                    { 6, 6, "/images/greendayDookiealbumcover.jpg", "Dookie", "Lookout!" },
                    { 7, 7, "/images/U2album.jpg", "Joshua Tree", "Island Records" }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "ID", "AlbumsID", "Duration", "Name" },
                values: new object[,]
                {
                    { 1, 1, "2:40", "the resurrection of scott mescud" },
                    { 61, 6, "2:54", "Having a Blast" },
                    { 60, 6, "2:07", "Burnou" },
                    { 59, 5, "10:42", "Smash" },
                    { 58, 5, "2:54", "Not the One" },
                    { 57, 5, "1:17", "So Alone" },
                    { 56, 5, "2:12", "What Happened to You?" },
                    { 55, 5, "2:02", "Killboy Powerhead" },
                    { 54, 5, "2:43", "It’ll Be a Long Time" },
                    { 53, 5, "4:17", "Self Esteem" },
                    { 52, 5, "3:17", "Come Out and Play" },
                    { 51, 5, "3:17", "Something to Believe In" },
                    { 50, 5, "3:33", "Genocide" },
                    { 49, 5, "3:52", "Gotta Get Away" },
                    { 48, 5, "3:52", "Bad Habit" },
                    { 47, 5, "2:27", "Nitro" },
                    { 46, 5, "0:25", "Time to Relax" },
                    { 45, 4, "3:48", "Into the Cold" },
                    { 62, 6, "2:54", "Chump" },
                    { 44, 4, "3:05", "If You Only" },
                    { 63, 6, "3:59", "Longview" },
                    { 65, 6, "2:31", "Pulling Teeth" },
                    { 82, 7, "5:23", "One Tree Hill" },
                    { 81, 7, "3:33", "Trip Through Your Wires" },
                    { 80, 7, "2:57", "In God’s Country" },
                    { 79, 7, "4:54", "Red Hill Mining Town" },
                    { 78, 7, "4:18", "Running to Stand STill" },
                    { 77, 7, "4:32", "Bullet the Blue Sky" },
                    { 76, 7, "4:56", "With or Without You" },
                    { 75, 7, "4:38", "I Still Haven’t Found What I’m Looking For" },
                    { 74, 7, "5:38", "Where The Streets Have No Name" },
                    { 73, 6, "5:46", "F.O.D." },
                    { 72, 6, "1:46", "In the End" },
                    { 71, 6, "1:43", "Emenius Sleepus" },
                    { 70, 6, "1:34", "Coming Clean" },
                    { 69, 6, "2:58", "When I Come Around" },
                    { 68, 6, "2:37", "Sassafras Roots" },
                    { 67, 6, "2:14", "She" },
                    { 66, 6, "3:01", "Basket Case" },
                    { 64, 6, "3:44", "Welcome to Paradise" },
                    { 43, 4, "3:45", "Wandered Away" },
                    { 42, 4, "3:59", "My Soul I" },
                    { 41, 4, "4:15", "I Never Really" },
                    { 18, 1, "2:51", "The Flight of the Moon Man" },
                    { 17, 1, "9:03", "Afterwards (Bring yo Friends)" },
                    { 16, 1, "2:32", "Cold Blooded" },
                    { 15, 1, "2:46", "Lord of the Sad and Lonely" },
                    { 14, 1, "2:58", "Burn Baby Burn" },
                    { 13, 1, "4:41", "Brothers" },
                    { 12, 1, "3:13", "Beez" },
                    { 11, 1, "4:08", "Mad solar " },
                    { 10, 1, "3:54", "Red Eye " },
                    { 9, 1, "1:53", "New York City Rage Fest " },
                    { 8, 1, "4:27", "Girls" },
                    { 7, 1, "3:34", "Solo Duo, Part II " },
                    { 6, 1, "5:01", "Immortal " },
                    { 5, 1, "4:16", "King Wizard" },
                    { 4, 1, "4:24", "Young Lady" },
                    { 3, 1, "3:48", "Just What I Am" },
                    { 2, 1, "4:35", "Unfuckwittable" },
                    { 19, 2, "5:05", "The Heart Of Rock And Roll" },
                    { 20, 2, "4:13", "Heart And Soul" },
                    { 21, 2, "3:48", "Bad Is Bad" },
                    { 22, 2, "4:46", "I Want A New Drug" },
                    { 40, 3, "14:35", "Note to Self" },
                    { 39, 3, "3:31", "Love Yourz" },
                    { 38, 3, "4:53", "Apparently" },
                    { 37, 3, "3:39", "Hello" },
                    { 36, 3, "4:52", "No Role Modelz" },
                    { 35, 3, "5:01", "G.O.M.D." },
                    { 34, 3, "4:17", "St. Tropez" },
                    { 33, 3, "4:48", "Fire Squad" },
                    { 83, 7, "4:13", "Exit" },
                    { 32, 3, "4:29", "A Tale of 2 Citiez" },
                    { 30, 3, "3:59", "Wet Dreamz" },
                    { 29, 3, "4:02", "January 28th" },
                    { 28, 3, "2:09", "Intro" },
                    { 27, 2, "3:21", "Honky Tonk Blues" },
                    { 26, 2, "3:43", "You Crack Me Up" },
                    { 25, 2, "3:53", "If This Is It" },
                    { 24, 2, "3:53", "Finally Found A Home" },
                    { 23, 2, "5:11", "Walking On A Thin Line" },
                    { 31, 3, "4:24", "03' Adolescence" },
                    { 84, 7, "5:12", "Mothers of the Disappeared" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Albums_ArtistsID",
                table: "Albums",
                column: "ArtistsID");

            migrationBuilder.CreateIndex(
                name: "IX_Songs_AlbumsID",
                table: "Songs",
                column: "AlbumsID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Songs");

            migrationBuilder.DropTable(
                name: "Albums");

            migrationBuilder.DropTable(
                name: "Artists");
        }
    }
}
