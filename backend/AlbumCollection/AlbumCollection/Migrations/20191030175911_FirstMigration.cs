using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AlbumCollection.Migrations
{
    public partial class FirstMigration : Migration
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
                    Hometown = table.Column<string>(nullable: true)
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
                    Title = table.Column<string>(nullable: true),
                    Recordlabel = table.Column<string>(nullable: true),
                    ArtistID = table.Column<int>(nullable: false),
                    ArtistsID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Albums_Artists_ArtistsID",
                        column: x => x.ArtistsID,
                        principalTable: "Artists",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Songs",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Songtitle = table.Column<string>(nullable: true),
                    Duration = table.Column<string>(nullable: true),
                    AlbumID = table.Column<int>(nullable: false),
                    AlbumsID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Songs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Songs_Albums_AlbumsID",
                        column: x => x.AlbumsID,
                        principalTable: "Albums",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "ID", "ArtistID", "ArtistsID", "Recordlabel", "Title" },
                values: new object[,]
                {
                    { 1, 1, null, "Wicked Awesome", "Indicud" },
                    { 2, 2, null, "Chrysalis Records", "Sports" },
                    { 3, 3, null, "Dreamville", "2014 Forest Hills Drive" },
                    { 4, 4, null, "Half Awake", "Wandered Away" },
                    { 5, 5, null, "Nitro Records", "Smash" },
                    { 6, 6, null, "Lookout!", "Dookie" },
                    { 7, 7, null, "Island Records", "Joshua Tree" }
                });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ID", "Age", "Hometown", "Name", "Recordlabel" },
                values: new object[,]
                {
                    { 7, 32, "Dublin, Ireland", "U2", "Island Records" },
                    { 6, 33, "Oakland, CA", "Green Day", "Lookout!" },
                    { 5, 35, "Garden Grove, CA", "The Offspring", "Nitro Records" },
                    { 4, 23, "Stockholm, Sweden", "Anna Leone", "Half Awake" },
                    { 3, 34, "Fayetteville, NC", "J. Cole", "Dreamville" },
                    { 2, 40, "San Francisco, CA", "Heuy Lewis And The News", "Chrysalis Records" },
                    { 1, 35, "Cleveland, OH", "Kid Cudi", "Wicked Awesome" }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "ID", "AlbumID", "AlbumsID", "Duration", "Songtitle" },
                values: new object[,]
                {
                    { 60, 6, null, "2:07", "Burnou" },
                    { 59, 5, null, "10:42", "Smash" },
                    { 58, 5, null, "2:54", "Not the One" },
                    { 57, 5, null, "1:17", "So Alone" },
                    { 56, 5, null, "2:12", "What Happened to You?" },
                    { 55, 5, null, "2:02", "Killboy Powerhead" },
                    { 54, 5, null, "2:43", "It’ll Be a Long Time" },
                    { 53, 5, null, "4:17", "Self Esteem" },
                    { 46, 5, null, "0:25", "Time to Relax" },
                    { 51, 5, null, "3:17", "Something to Believe In" },
                    { 50, 5, null, "3:33", "Genocide" },
                    { 49, 5, null, "3:52", "Gotta Get Away" },
                    { 48, 5, null, "3:52", "Bad Habit" },
                    { 47, 5, null, "2:27", "Nitro" },
                    { 61, 6, null, "2:54", "Having a Blast" },
                    { 45, 4, null, "3:48", "Into the Cold" },
                    { 44, 4, null, "3:05", "If You Only" },
                    { 52, 5, null, "3:17", "Come Out and Play" },
                    { 62, 6, null, "2:54", "Chump" },
                    { 69, 6, null, "2:58", "When I Come Around" },
                    { 64, 6, null, "3:44", "Welcome to Paradise" },
                    { 82, 7, null, "5:23", "One Tree Hill" },
                    { 81, 7, null, "3:33", "Trip Through Your Wires" },
                    { 80, 7, null, "2:57", "In God’s Country" },
                    { 79, 7, null, "4:54", "Red Hill Mining Town" },
                    { 78, 7, null, "4:18", "Running to Stand STill" },
                    { 77, 7, null, "4:32", "Bullet the Blue Sky" },
                    { 76, 7, null, "4:56", "With or Without You" },
                    { 75, 7, null, "4:38", "I Still Haven’t Found What I’m Looking For" },
                    { 63, 6, null, "3:59", "Longview" },
                    { 74, 7, null, "5:38", "Where The Streets Have No Name" },
                    { 72, 6, null, "1:46", "In the End" },
                    { 71, 6, null, "1:43", "Emenius Sleepus" },
                    { 70, 6, null, "1:34", "Coming Clean" },
                    { 43, 4, null, "3:45", "Wandered Away" },
                    { 68, 6, null, "2:37", "Sassafras Roots" },
                    { 67, 6, null, "2:14", "She" },
                    { 66, 6, null, "3:01", "Basket Case" },
                    { 65, 6, null, "2:31", "Pulling Teeth" },
                    { 73, 6, null, "5:46", "F.O.D." },
                    { 42, 4, null, "3:59", "My Soul I" },
                    { 35, 3, null, "5:01", "G.O.M.D." },
                    { 40, 3, null, "14:35", "Note to Self" },
                    { 17, 1, null, "9:03", "Afterwards (Bring yo Friends)" },
                    { 16, 1, null, "2:32", "Cold Blooded" },
                    { 15, 1, null, "2:46", "Lord of the Sad and Lonely" },
                    { 14, 1, null, "2:58", "Burn Baby Burn" },
                    { 13, 1, null, "4:41", "Brothers" },
                    { 12, 1, null, "3:13", "Beez" },
                    { 11, 1, null, "4:08", "Mad solar " },
                    { 10, 1, null, "3:54", "Red Eye " },
                    { 9, 1, null, "1:53", "New York City Rage Fest " },
                    { 8, 1, null, "4:27", "Girls" },
                    { 7, 1, null, "3:34", "Solo Duo, Part II " },
                    { 6, 1, null, "5:01", "Immortal " },
                    { 5, 1, null, "4:16", "King Wizard" },
                    { 4, 1, null, "4:24", "Young Lady" },
                    { 3, 1, null, "3:48", "Just What I Am" },
                    { 2, 1, null, "4:35", "Unfuckwittable" },
                    { 1, 1, null, "2:40", "the resurrection of scott mescud" },
                    { 18, 1, null, "2:51", "The Flight of the Moon Man" },
                    { 19, 2, null, "5:05", "The Heart Of Rock And Roll" },
                    { 20, 2, null, "4:13", "Heart And Soul" },
                    { 21, 2, null, "3:48", "Bad Is Bad" },
                    { 39, 3, null, "3:31", "Love Yourz" },
                    { 38, 3, null, "4:53", "Apparently" },
                    { 37, 3, null, "3:39", "Hello" },
                    { 36, 3, null, "4:52", "No Role Modelz" },
                    { 83, 7, null, "4:13", "Exit" },
                    { 34, 3, null, "4:17", "St. Tropez" },
                    { 33, 3, null, "4:48", "Fire Squad" },
                    { 32, 3, null, "4:29", "A Tale of 2 Citiez" },
                    { 41, 4, null, "4:15", "I Never Really" },
                    { 31, 3, null, "4:24", "03' Adolescence" },
                    { 29, 3, null, "4:02", "January 28th" },
                    { 28, 3, null, "2:09", "Intro" },
                    { 27, 2, null, "3:21", "Honky Tonk Blues" },
                    { 26, 2, null, "3:43", "You Crack Me Up" },
                    { 25, 2, null, "3:53", "If This Is It" },
                    { 24, 2, null, "3:53", "Finally Found A Home" },
                    { 23, 2, null, "5:11", "Walking On A Thin Line" },
                    { 22, 2, null, "4:46", "I Want A New Drug" },
                    { 30, 3, null, "3:59", "Wet Dreamz" },
                    { 84, 7, null, "5:12", "Mothers of the Disappeared" }
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
