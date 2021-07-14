using Microsoft.EntityFrameworkCore.Migrations;

namespace DotNet_101.Infrastructure.Data.Migrations
{
    public partial class RemoveDescriptionProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Products");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
