using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjP.Migrations
{
    public partial class Wypozyczalnia1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Faktura",
                columns: table => new
                {
                    FakturaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NIP = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Nazwa = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
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
                    PeselKey = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Nazwisko = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Imię = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    NrTelefon = table.Column<string>(type: "nvarchar(24)", maxLength: 24, nullable: false)
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
                    Pesel = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    NazwiskoPracownik = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    ImięPracownik = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Stanowisko = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    NrTelefonu = table.Column<string>(type: "nvarchar(24)", maxLength: 24, nullable: false)
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
                    Kolor = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    RowerType = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
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
                    Cena = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    FakturaId = table.Column<int>(type: "int", nullable: false),
                    PracownikId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wypożyczenie", x => x.WypożyczenieId);
                    table.ForeignKey(
                        name: "FK_Wypożyczenie_Faktura_FakturaId",
                        column: x => x.FakturaId,
                        principalTable: "Faktura",
                        principalColumn: "FakturaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Wypożyczenie_Pracownik_PracownikId",
                        column: x => x.PracownikId,
                        principalTable: "Pracownik",
                        principalColumn: "PracownikId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KlientWypożyczenie",
                columns: table => new
                {
                    KlienciPeselKey = table.Column<string>(type: "nvarchar(11)", nullable: false),
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

            migrationBuilder.CreateIndex(
                name: "IX_Wypożyczenie_FakturaId",
                table: "Wypożyczenie",
                column: "FakturaId");

            migrationBuilder.CreateIndex(
                name: "IX_Wypożyczenie_PracownikId",
                table: "Wypożyczenie",
                column: "PracownikId");





        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KlientWypożyczenie");

            migrationBuilder.DropTable(
                name: "RowerWypożyczenie");

            migrationBuilder.DropTable(
                name: "Klient");

            migrationBuilder.DropTable(
                name: "Rower");

            migrationBuilder.DropTable(
                name: "Wypożyczenie");

            migrationBuilder.DropTable(
                name: "Faktura");

            migrationBuilder.DropTable(
                name: "Pracownik");
        }
    }
}
