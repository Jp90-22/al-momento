using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlMomento.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Noticia",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Sumario = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Lead = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    Cuerpo = table.Column<string>(type: "ntext", nullable: false),
                    Categoria = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FechaPublicacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaRedaccion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false),
                    Autor = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    AutorContacto = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Foto = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    FotoPie = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Video = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Localidad = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CantidadVisitas = table.Column<long>(type: "bigint", nullable: false),
                    CantidadLikes = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Noticia", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Noticia");
        }
    }
}
