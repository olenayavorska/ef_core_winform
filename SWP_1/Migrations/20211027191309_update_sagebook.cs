using Microsoft.EntityFrameworkCore.Migrations;

namespace SWP_1.Migrations
{
    public partial class update_sagebook : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "idSage_sage",
                table: "SageBooks",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "idSage_sage",
                table: "SageBooks");
        }
    }
}
