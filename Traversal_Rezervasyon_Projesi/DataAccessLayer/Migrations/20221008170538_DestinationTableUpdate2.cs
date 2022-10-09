using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class DestinationTableUpdate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image2",
                table: "Destinations");

            migrationBuilder.DropColumn(
                name: "Image3",
                table: "Destinations");

            migrationBuilder.DropColumn(
                name: "Image4",
                table: "Destinations");

            migrationBuilder.DropColumn(
                name: "Image5",
                table: "Destinations");

            migrationBuilder.AddColumn<string>(
                name: "Photo",
                table: "MeaningfulArticles",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Photo",
                table: "MeaningfulArticles");

            migrationBuilder.AddColumn<string>(
                name: "Image2",
                table: "Destinations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image3",
                table: "Destinations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image4",
                table: "Destinations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image5",
                table: "Destinations",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
