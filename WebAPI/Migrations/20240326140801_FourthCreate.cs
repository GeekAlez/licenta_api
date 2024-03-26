using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class FourthCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageSource",
                table: "Restaurant");

            migrationBuilder.DropColumn(
                name: "Credit",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "Poza",
                table: "Category");

            migrationBuilder.AlterColumn<int>(
                name: "Locatie",
                table: "Pachet",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Eveniment",
                table: "Pachet",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Category",
                type: "int",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageSource",
                table: "Restaurant",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Locatie",
                table: "Pachet",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Eveniment",
                table: "Pachet",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<short>(
                name: "Id",
                table: "Category",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "Credit",
                table: "Category",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<short>(
                name: "ParentId",
                table: "Category",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<string>(
                name: "Poza",
                table: "Category",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
