using Microsoft.EntityFrameworkCore.Migrations;

namespace Reto_Programacion.Migrations
{
    public partial class ClientesATM : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreCliente = table.Column<string>(maxLength: 50, nullable: false),
                    Cncsn = table.Column<string>(maxLength: 50, nullable: true),
                    Cdad = table.Column<string>(maxLength: 50, nullable: true),
                    Tlfno = table.Column<string>(nullable: true),
                    Status = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cliente");
        }
    }
}
