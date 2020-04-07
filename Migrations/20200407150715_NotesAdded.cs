using Microsoft.EntityFrameworkCore.Migrations;

namespace AnniesTeaShop.Migrations
{
    public partial class NotesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "Teas",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "Pies",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Notes",
                table: "Teas");

            migrationBuilder.DropColumn(
                name: "Notes",
                table: "Pies");
        }
    }
}
