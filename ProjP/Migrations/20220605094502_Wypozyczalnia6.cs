using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjP.Migrations
{
    public partial class Wypozyczalnia6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FakturaId",
                table: "Wypożyczenie",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PracownikId",
                table: "Wypożyczenie",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Wypożyczenie_FakturaId",
                table: "Wypożyczenie",
                column: "FakturaId");

            migrationBuilder.CreateIndex(
                name: "IX_Wypożyczenie_PracownikId",
                table: "Wypożyczenie",
                column: "PracownikId");

            migrationBuilder.AddForeignKey(
                name: "FK_Wypożyczenie_Faktura_FakturaId",
                table: "Wypożyczenie",
                column: "FakturaId",
                principalTable: "Faktura",
                principalColumn: "FakturaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Wypożyczenie_Pracownik_PracownikId",
                table: "Wypożyczenie",
                column: "PracownikId",
                principalTable: "Pracownik",
                principalColumn: "PracownikId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Wypożyczenie_Faktura_FakturaId",
                table: "Wypożyczenie");

            migrationBuilder.DropForeignKey(
                name: "FK_Wypożyczenie_Pracownik_PracownikId",
                table: "Wypożyczenie");

            migrationBuilder.DropIndex(
                name: "IX_Wypożyczenie_FakturaId",
                table: "Wypożyczenie");

            migrationBuilder.DropIndex(
                name: "IX_Wypożyczenie_PracownikId",
                table: "Wypożyczenie");

            migrationBuilder.DropColumn(
                name: "FakturaId",
                table: "Wypożyczenie");

            migrationBuilder.DropColumn(
                name: "PracownikId",
                table: "Wypożyczenie");
        }
    }
}
