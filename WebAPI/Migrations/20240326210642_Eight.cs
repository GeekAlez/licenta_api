using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class Eight : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdsRestaurantSelectat",
                table: "Pachet");

            migrationBuilder.DropColumn(
                name: "ListaIdsRestaurante",
                table: "Pachet");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdsRestaurantSelectat",
                table: "Pachet",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ListaIdsRestaurante",
                table: "Pachet",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
