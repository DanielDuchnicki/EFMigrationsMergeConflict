using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFMigrationsMergeConflictApi.Infrastructure.Migrations
{
    public partial class AddReaders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Readers",
                table: "Blogs",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Readers",
                table: "Blogs");
        }
    }
}
