using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesWebProject.Migrations
{
    public partial class NovaMigracao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Integer",
                table: "SalesRecord");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Integer",
                table: "SalesRecord",
                nullable: false,
                defaultValue: 0);
        }
    }
}
