using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Torok_Erika_Tunde.Migrations
{
    public partial class Material : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MaterialID",
                table: "Client",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Material",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaterialName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Material", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Client_MaterialID",
                table: "Client",
                column: "MaterialID");

            migrationBuilder.AddForeignKey(
                name: "FK_Client_Material_MaterialID",
                table: "Client",
                column: "MaterialID",
                principalTable: "Material",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Client_Material_MaterialID",
                table: "Client");

            migrationBuilder.DropTable(
                name: "Material");

            migrationBuilder.DropIndex(
                name: "IX_Client_MaterialID",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "MaterialID",
                table: "Client");
        }
    }
}
