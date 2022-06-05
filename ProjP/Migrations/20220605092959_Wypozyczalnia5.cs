using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjP.Migrations
{
    public partial class Wypozyczalnia5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Klient_Wypożyczenie_WypożyczenieId",
                table: "Klient");

            migrationBuilder.DropIndex(
                name: "IX_Klient_WypożyczenieId",
                table: "Klient");

            migrationBuilder.DropColumn(
                name: "WypożyczenieId",
                table: "Klient");

            migrationBuilder.CreateTable(
                name: "KlientWypożyczenie",
                columns: table => new
                {
                    KlienciPeselKey = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    WypożyczeniaWypożyczenieId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KlientWypożyczenie", x => new { x.KlienciPeselKey, x.WypożyczeniaWypożyczenieId });
                    table.ForeignKey(
                        name: "FK_KlientWypożyczenie_Klient_KlienciPeselKey",
                        column: x => x.KlienciPeselKey,
                        principalTable: "Klient",
                        principalColumn: "PeselKey",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KlientWypożyczenie_Wypożyczenie_WypożyczeniaWypożyczenieId",
                        column: x => x.WypożyczeniaWypożyczenieId,
                        principalTable: "Wypożyczenie",
                        principalColumn: "WypożyczenieId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_KlientWypożyczenie_WypożyczeniaWypożyczenieId",
                table: "KlientWypożyczenie",
                column: "WypożyczeniaWypożyczenieId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KlientWypożyczenie");

            migrationBuilder.AddColumn<int>(
                name: "WypożyczenieId",
                table: "Klient",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Klient_WypożyczenieId",
                table: "Klient",
                column: "WypożyczenieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Klient_Wypożyczenie_WypożyczenieId",
                table: "Klient",
                column: "WypożyczenieId",
                principalTable: "Wypożyczenie",
                principalColumn: "WypożyczenieId");
        }
    }
}
