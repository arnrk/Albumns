using Microsoft.EntityFrameworkCore.Migrations;

namespace AlbumCollection.Migrations
{
    public partial class ImagePathway : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "ID",
                keyValue: 1,
                column: "Image",
                value: "./css/images/indicudalbum.jpeg");

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "ID",
                keyValue: 2,
                column: "Image",
                value: "./css/images/Sports-Huey-Lewis.jpg");

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "ID",
                keyValue: 3,
                column: "Image",
                value: "./css/images/Jcolealbum.jpeg");

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "ID",
                keyValue: 4,
                column: "Image",
                value: "./css/images/wanderedaway.jpg");

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "ID",
                keyValue: 5,
                column: "Image",
                value: "./css/images/offspringSmashalbumcover.jpg");

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "ID",
                keyValue: 6,
                column: "Image",
                value: "./css/images/greendayDookiealbumcover.jpg");

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "ID",
                keyValue: 7,
                column: "Image",
                value: "./css/images/U2album.jpg");

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "ID",
                keyValue: 1,
                column: "Image",
                value: "./css/images/kidcudiartistpic.jpg");

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "ID",
                keyValue: 2,
                column: "Image",
                value: "./css/images/Huey-Lewis.jpg");

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "ID",
                keyValue: 3,
                column: "Image",
                value: "./css/images/JCole.jpg");

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "ID",
                keyValue: 4,
                column: "Image",
                value: "./css/images/AnnaLeone.jpg");

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "ID",
                keyValue: 5,
                column: "Image",
                value: "./css/images/offspringbandpic.jpg");

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "ID",
                keyValue: 6,
                column: "Image",
                value: "./css/images/greendaybandpic.jpg");

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "ID",
                keyValue: 7,
                column: "Image",
                value: "./css/images/U2.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "ID",
                keyValue: 1,
                column: "Image",
                value: "/images/indicudalbum.jpeg");

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "ID",
                keyValue: 2,
                column: "Image",
                value: "/images/Sports-Huey-Lewis.jpg");

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "ID",
                keyValue: 3,
                column: "Image",
                value: "/images/Jcolealbum.jpeg");

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "ID",
                keyValue: 4,
                column: "Image",
                value: "/images/wanderedaway.jpg");

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "ID",
                keyValue: 5,
                column: "Image",
                value: "/images/offspringSmashalbumcover.jpg");

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "ID",
                keyValue: 6,
                column: "Image",
                value: "/images/greendayDookiealbumcover.jpg");

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "ID",
                keyValue: 7,
                column: "Image",
                value: "/images/U2album.jpg");

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "ID",
                keyValue: 1,
                column: "Image",
                value: "/images/kidcudiartistpic.jpg");

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "ID",
                keyValue: 2,
                column: "Image",
                value: "/images/Huey-Lewis.jpg");

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "ID",
                keyValue: 3,
                column: "Image",
                value: "/images/JCole.jpg");

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "ID",
                keyValue: 4,
                column: "Image",
                value: "/images/AnnaLeone.jpg");

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "ID",
                keyValue: 5,
                column: "Image",
                value: "/images/offspringbandpic.jpg");

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "ID",
                keyValue: 6,
                column: "Image",
                value: "/images/greendaybandpic.jpg");

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "ID",
                keyValue: 7,
                column: "Image",
                value: "/images/U2.jpg");
        }
    }
}
