using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjP.Migrations
{
    public partial class Wypozyczalnia2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KlientWypożyczenie_Klient_KlienciPeselKey",
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

            migrationBuilder.DropPrimaryKey(
                name: "PK_KlientWypożyczenie",
                table: "KlientWypożyczenie");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Klient",
                table: "Klient");

            migrationBuilder.DropColumn(
                name: "KlienciPeselKey",
                table: "KlientWypożyczenie");

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

            migrationBuilder.RenameIndex(
                name: "IX_KlientWypożyczenie_WypożyczeniaWypożyczenieId",
                table: "KlientWypożyczenie",
                newName: "IX_KlientWypożyczenie_WypożyczeniaId");

            migrationBuilder.RenameColumn(
                name: "PeselKey",
                table: "Klient",
                newName: "Pesel");

            migrationBuilder.RenameColumn(
                name: "FakturaId",
                table: "Faktura",
                newName: "Id");

            migrationBuilder.AddColumn<int>(
                name: "KlienciId",
                table: "KlientWypożyczenie",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Klient",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_KlientWypożyczenie",
                table: "KlientWypożyczenie",
                columns: new[] { "KlienciId", "WypożyczeniaId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Klient",
                table: "Klient",
                column: "Id");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropPrimaryKey(
                name: "PK_KlientWypożyczenie",
                table: "KlientWypożyczenie");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Klient",
                table: "Klient");

            migrationBuilder.DropColumn(
                name: "KlienciId",
                table: "KlientWypożyczenie");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Klient");

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

            migrationBuilder.RenameIndex(
                name: "IX_KlientWypożyczenie_WypożyczeniaId",
                table: "KlientWypożyczenie",
                newName: "IX_KlientWypożyczenie_WypożyczeniaWypożyczenieId");

            migrationBuilder.RenameColumn(
                name: "Pesel",
                table: "Klient",
                newName: "PeselKey");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Faktura",
                newName: "FakturaId");

            migrationBuilder.AddColumn<string>(
                name: "KlienciPeselKey",
                table: "KlientWypożyczenie",
                type: "nvarchar(11)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_KlientWypożyczenie",
                table: "KlientWypożyczenie",
                columns: new[] { "KlienciPeselKey", "WypożyczeniaWypożyczenieId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Klient",
                table: "Klient",
                column: "PeselKey");

            migrationBuilder.AddForeignKey(
                name: "FK_KlientWypożyczenie_Klient_KlienciPeselKey",
                table: "KlientWypożyczenie",
                column: "KlienciPeselKey",
                principalTable: "Klient",
                principalColumn: "PeselKey",
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
    }
}
