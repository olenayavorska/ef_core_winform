using Microsoft.EntityFrameworkCore.Migrations;

namespace SWP_1.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    IdBook = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.IdBook);
                });

            migrationBuilder.CreateTable(
                name: "Sages",
                columns: table => new
                {
                    IdSage = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    age = table.Column<int>(type: "int", nullable: false),
                    photo = table.Column<int>(type: "int", nullable: false),
                    city = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sages", x => x.IdSage);
                });

            migrationBuilder.CreateTable(
                name: "SageBooks",
                columns: table => new
                {
                    idSage = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SageIdSage = table.Column<int>(type: "int", nullable: true),
                    IdBook = table.Column<int>(type: "int", nullable: false),
                    BookIdBook = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SageBooks", x => x.idSage);
                    table.ForeignKey(
                        name: "FK_SageBooks_Books_BookIdBook",
                        column: x => x.BookIdBook,
                        principalTable: "Books",
                        principalColumn: "IdBook",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SageBooks_Sages_SageIdSage",
                        column: x => x.SageIdSage,
                        principalTable: "Sages",
                        principalColumn: "IdSage",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SageBooks_BookIdBook",
                table: "SageBooks",
                column: "BookIdBook");

            migrationBuilder.CreateIndex(
                name: "IX_SageBooks_SageIdSage",
                table: "SageBooks",
                column: "SageIdSage");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SageBooks");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Sages");
        }
    }
}
