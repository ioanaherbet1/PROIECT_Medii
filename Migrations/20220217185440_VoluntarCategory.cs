using Microsoft.EntityFrameworkCore.Migrations;

namespace Herbet_Ioana_ONG.Migrations
{
    public partial class VoluntarCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartamentID",
                table: "Voluntar",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Departament",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartamentName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departament", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "VoluntarCategory",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VoluntarID = table.Column<int>(type: "int", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VoluntarCategory", x => x.ID);
                    table.ForeignKey(
                        name: "FK_VoluntarCategory_Category_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Category",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VoluntarCategory_Voluntar_VoluntarID",
                        column: x => x.VoluntarID,
                        principalTable: "Voluntar",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Voluntar_DepartamentID",
                table: "Voluntar",
                column: "DepartamentID");

            migrationBuilder.CreateIndex(
                name: "IX_VoluntarCategory_CategoryID",
                table: "VoluntarCategory",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_VoluntarCategory_VoluntarID",
                table: "VoluntarCategory",
                column: "VoluntarID");

            migrationBuilder.AddForeignKey(
                name: "FK_Voluntar_Departament_DepartamentID",
                table: "Voluntar",
                column: "DepartamentID",
                principalTable: "Departament",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Voluntar_Departament_DepartamentID",
                table: "Voluntar");

            migrationBuilder.DropTable(
                name: "Departament");

            migrationBuilder.DropTable(
                name: "VoluntarCategory");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropIndex(
                name: "IX_Voluntar_DepartamentID",
                table: "Voluntar");

            migrationBuilder.DropColumn(
                name: "DepartamentID",
                table: "Voluntar");
        }
    }
}
