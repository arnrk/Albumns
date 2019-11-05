using Microsoft.EntityFrameworkCore.Migrations;

namespace AlbumCollection.Migrations
{
    public partial class EditName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Songtitle",
                table: "Songs",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Albums",
                newName: "Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Songs",
                newName: "Songtitle");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Albums",
                newName: "Title");
        }
    }
}
