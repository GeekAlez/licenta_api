using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class Sixth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pachet_Rezervare_RezervareId",
                table: "Pachet");

            migrationBuilder.DropIndex(
                name: "IX_Pachet_RezervareId",
                table: "Pachet");

            migrationBuilder.DropColumn(
                name: "Data",
                table: "Rezervare");

            migrationBuilder.DropColumn(
                name: "RezervareId",
                table: "Pachet");

            migrationBuilder.AddColumn<int>(
                name: "Nume",
                table: "Rezervare",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nume",
                table: "Rezervare");

            migrationBuilder.AddColumn<DateTime>(
                name: "Data",
                table: "Rezervare",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "RezervareId",
                table: "Pachet",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pachet_RezervareId",
                table: "Pachet",
                column: "RezervareId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pachet_Rezervare_RezervareId",
                table: "Pachet",
                column: "RezervareId",
                principalTable: "Rezervare",
                principalColumn: "Id");
        }
    }
}
