using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjP.Migrations
{
    public partial class Wypozyczalnia3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KlientWypożyczenie_Klient_KlienciId",
                table: "KlientWypożyczenie");

            migrationBuilder.DropForeignKey(
                name: "FK_KlientWypożyczenie_Wypożyczenie_WypożyczeniaId",
                table: "KlientWypożyczenie");

            migrationBuilder.DropForeignKey(
                name: "FK_RowerWypożyczenie_Rower_RoweryId",
                table: "RowerWypożyczenie");

            migrationBuilder.DropForeignKey(
                name: "FK_RowerWypożyczenie_Wypożyczenie_WypożyczeniaId",
                table: "RowerWypożyczenie");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Wypożyczenie",
                newName: "WypożyczenieId");

            migrationBuilder.RenameColumn(
                name: "WypożyczeniaId",
                table: "RowerWypożyczenie",
                newName: "WypożyczeniaWypożyczenieId");

            migrationBuilder.RenameColumn(
                name: "RoweryId",
                table: "RowerWypożyczenie",
                newName: "RoweryRowerId");

            migrationBuilder.RenameIndex(
                name: "IX_RowerWypożyczenie_WypożyczeniaId",
                table: "RowerWypożyczenie",
                newName: "IX_RowerWypożyczenie_WypożyczeniaWypożyczenieId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Rower",
                newName: "RowerId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Pracownik",
                newName: "PracownikId");

            migrationBuilder.RenameColumn(
                name: "WypożyczeniaId",
                table: "KlientWypożyczenie",
                newName: "WypożyczeniaWypożyczenieId");

            migrationBuilder.RenameColumn(
                name: "KlienciId",
                table: "KlientWypożyczenie",
                newName: "KlienciKlientId");

            migrationBuilder.RenameIndex(
                name: "IX_KlientWypożyczenie_WypożyczeniaId",
                table: "KlientWypożyczenie",
                newName: "IX_KlientWypożyczenie_WypożyczeniaWypożyczenieId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Klient",
                newName: "KlientId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Faktura",
                newName: "FakturaId");

            migrationBuilder.AddForeignKey(
                name: "FK_KlientWypożyczenie_Klient_KlienciKlientId",
                table: "KlientWypożyczenie",
                column: "KlienciKlientId",
                principalTable: "Klient",
                principalColumn: "KlientId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_KlientWypożyczenie_Wypożyczenie_WypożyczeniaWypożyczenieId",
                table: "KlientWypożyczenie",
                column: "WypożyczeniaWypożyczenieId",
                principalTable: "Wypożyczenie",
                principalColumn: "WypożyczenieId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RowerWypożyczenie_Rower_RoweryRowerId",
                table: "RowerWypożyczenie",
                column: "RoweryRowerId",
                principalTable: "Rower",
                principalColumn: "RowerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RowerWypożyczenie_Wypożyczenie_WypożyczeniaWypożyczenieId",
                table: "RowerWypożyczenie",
                column: "WypożyczeniaWypożyczenieId",
                principalTable: "Wypożyczenie",
                principalColumn: "WypożyczenieId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KlientWypożyczenie_Klient_KlienciKlientId",
                table: "KlientWypożyczenie");

            migrationBuilder.DropForeignKey(
                name: "FK_KlientWypożyczenie_Wypożyczenie_WypożyczeniaWypożyczenieId",
                table: "KlientWypożyczenie");

            migrationBuilder.DropForeignKey(
                name: "FK_RowerWypożyczenie_Rower_RoweryRowerId",
                table: "RowerWypożyczenie");

            migrationBuilder.DropForeignKey(
                name: "FK_RowerWypożyczenie_Wypożyczenie_WypożyczeniaWypożyczenieId",
                table: "RowerWypożyczenie");

            migrationBuilder.RenameColumn(
                name: "WypożyczenieId",
                table: "Wypożyczenie",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "WypożyczeniaWypożyczenieId",
                table: "RowerWypożyczenie",
                newName: "WypożyczeniaId");

            migrationBuilder.RenameColumn(
                name: "RoweryRowerId",
                table: "RowerWypożyczenie",
                newName: "RoweryId");

            migrationBuilder.RenameIndex(
                name: "IX_RowerWypożyczenie_WypożyczeniaWypożyczenieId",
                table: "RowerWypożyczenie",
                newName: "IX_RowerWypożyczenie_WypożyczeniaId");

            migrationBuilder.RenameColumn(
                name: "RowerId",
                table: "Rower",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "PracownikId",
                table: "Pracownik",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "WypożyczeniaWypożyczenieId",
                table: "KlientWypożyczenie",
                newName: "WypożyczeniaId");

            migrationBuilder.RenameColumn(
                name: "KlienciKlientId",
                table: "KlientWypożyczenie",
                newName: "KlienciId");

            migrationBuilder.RenameIndex(
                name: "IX_KlientWypożyczenie_WypożyczeniaWypożyczenieId",
                table: "KlientWypożyczenie",
                newName: "IX_KlientWypożyczenie_WypożyczeniaId");

            migrationBuilder.RenameColumn(
                name: "KlientId",
                table: "Klient",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "FakturaId",
                table: "Faktura",
                newName: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_KlientWypożyczenie_Klient_KlienciId",
                table: "KlientWypożyczenie",
                column: "KlienciId",
                principalTable: "Klient",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_KlientWypożyczenie_Wypożyczenie_WypożyczeniaId",
                table: "KlientWypożyczenie",
                column: "WypożyczeniaId",
                principalTable: "Wypożyczenie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RowerWypożyczenie_Rower_RoweryId",
                table: "RowerWypożyczenie",
                column: "RoweryId",
                principalTable: "Rower",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RowerWypożyczenie_Wypożyczenie_WypożyczeniaId",
                table: "RowerWypożyczenie",
                column: "WypożyczeniaId",
                principalTable: "Wypożyczenie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
