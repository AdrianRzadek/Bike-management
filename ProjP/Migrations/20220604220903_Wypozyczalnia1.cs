using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjP.Migrations
{
    public partial class Wypozyczalnia1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Wypożyczenie_Klient_KlientPeselKey",
                table: "Wypożyczenie");

            migrationBuilder.DropForeignKey(
                name: "FK_Wypożyczenie_Rower_RowerId",
                table: "Wypożyczenie");

            migrationBuilder.DropIndex(
                name: "IX_Wypożyczenie_KlientPeselKey",
                table: "Wypożyczenie");

            migrationBuilder.DropIndex(
                name: "IX_Wypożyczenie_RowerId",
                table: "Wypożyczenie");

            migrationBuilder.DropColumn(
                name: "KlientPeselKey",
                table: "Wypożyczenie");

            migrationBuilder.DropColumn(
                name: "RowerId",
                table: "Wypożyczenie");

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

            migrationBuilder.CreateTable(
                name: "RowerWypożyczenie",
                columns: table => new
                {
                    RoweryRowerId = table.Column<int>(type: "int", nullable: false),
                    WypożyczeniaWypożyczenieId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RowerWypożyczenie", x => new { x.RoweryRowerId, x.WypożyczeniaWypożyczenieId });
                    table.ForeignKey(
                        name: "FK_RowerWypożyczenie_Rower_RoweryRowerId",
                        column: x => x.RoweryRowerId,
                        principalTable: "Rower",
                        principalColumn: "RowerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RowerWypożyczenie_Wypożyczenie_WypożyczeniaWypożyczenieId",
                        column: x => x.WypożyczeniaWypożyczenieId,
                        principalTable: "Wypożyczenie",
                        principalColumn: "WypożyczenieId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_KlientWypożyczenie_WypożyczeniaWypożyczenieId",
                table: "KlientWypożyczenie",
                column: "WypożyczeniaWypożyczenieId");

            migrationBuilder.CreateIndex(
                name: "IX_RowerWypożyczenie_WypożyczeniaWypożyczenieId",
                table: "RowerWypożyczenie",
                column: "WypożyczeniaWypożyczenieId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KlientWypożyczenie");

            migrationBuilder.DropTable(
                name: "RowerWypożyczenie");

            migrationBuilder.AddColumn<string>(
                name: "KlientPeselKey",
                table: "Wypożyczenie",
                type: "nvarchar(1)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RowerId",
                table: "Wypożyczenie",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Wypożyczenie_KlientPeselKey",
                table: "Wypożyczenie",
                column: "KlientPeselKey");

            migrationBuilder.CreateIndex(
                name: "IX_Wypożyczenie_RowerId",
                table: "Wypożyczenie",
                column: "RowerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Wypożyczenie_Klient_KlientPeselKey",
                table: "Wypożyczenie",
                column: "KlientPeselKey",
                principalTable: "Klient",
                principalColumn: "PeselKey");

            migrationBuilder.AddForeignKey(
                name: "FK_Wypożyczenie_Rower_RowerId",
                table: "Wypożyczenie",
                column: "RowerId",
                principalTable: "Rower",
                principalColumn: "RowerId");
        }
    }
}
