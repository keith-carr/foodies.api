using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace foodies.Migrations
{
    public partial class SecondPath : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NewOtherItem",
                table: "accounts",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NewOtherItem",
                table: "accounts");
        }
    }
}
