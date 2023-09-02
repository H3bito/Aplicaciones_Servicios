using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class initialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "proyecto",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    fechainicio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fechafin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lider = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    descripccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    areaInvestigacion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_proyecto", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "proyectos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    documento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    firtname = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    lastname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    afiliacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    especializacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    rol = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_proyectos", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_proyecto_name",
                table: "proyecto",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_proyectos_firtname",
                table: "proyectos",
                column: "firtname",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "proyecto");

            migrationBuilder.DropTable(
                name: "proyectos");
        }
    }
}
