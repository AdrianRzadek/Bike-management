using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjP.Migrations
{
    public partial class Wypozyczalnia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Faktura",
                columns: table => new
                {
                    FakturaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NIP = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Nazwa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataWystawienia = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faktura", x => x.FakturaId);
                });

            migrationBuilder.CreateTable(
                name: "Klient",
                columns: table => new
                {
                    PeselKey = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Nazwisko = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Imię = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NrTelefon = table.Column<string>(type: "nvarchar(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Klient", x => x.PeselKey);
                });

            migrationBuilder.CreateTable(
                name: "Pracownik",
                columns: table => new
                {
                    PracownikId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pesel = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    NazwiskoPracownik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImięPracownik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Stanowisko = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NrTelefonu = table.Column<string>(type: "nvarchar(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pracownik", x => x.PracownikId);
                });

            migrationBuilder.CreateTable(
                name: "Rower",
                columns: table => new
                {
                    RowerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kolor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RowerType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RozmiarRamy = table.Column<float>(type: "real", nullable: false),
                    RozmiarOpon = table.Column<float>(type: "real", nullable: false),
                    Biegi = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rower", x => x.RowerId);
                });

            migrationBuilder.CreateTable(
                name: "Wypożyczenie",
                columns: table => new
                {
                    WypożyczenieId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataWypożyczenia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataOddania = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Cena = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    KlientPeselKey = table.Column<string>(type: "nvarchar(1)", nullable: true),
                    RowerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wypożyczenie", x => x.WypożyczenieId);
                    table.ForeignKey(
                        name: "FK_Wypożyczenie_Klient_KlientPeselKey",
                        column: x => x.KlientPeselKey,
                        principalTable: "Klient",
                        principalColumn: "PeselKey");
                    table.ForeignKey(
                        name: "FK_Wypożyczenie_Rower_RowerId",
                        column: x => x.RowerId,
                        principalTable: "Rower",
                        principalColumn: "RowerId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Wypożyczenie_KlientPeselKey",
                table: "Wypożyczenie",
                column: "KlientPeselKey");

            migrationBuilder.CreateIndex(
                name: "IX_Wypożyczenie_RowerId",
                table: "Wypożyczenie",
                column: "RowerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Faktura");

            migrationBuilder.DropTable(
                name: "Pracownik");

            migrationBuilder.DropTable(
                name: "Wypożyczenie");

            migrationBuilder.DropTable(
                name: "Klient");

            migrationBuilder.DropTable(
                name: "Rower");
        }
    }
}
