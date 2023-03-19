using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClothingShopApi.Database.Migrations
{
    /// <inheritdoc />
    public partial class UpdateClothingPrice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClothingSizes_Clothings_ClothingId",
                table: "ClothingSizes");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "ClothingSizes");

            migrationBuilder.AlterColumn<int>(
                name: "ClothingId",
                table: "ClothingSizes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ClothingSizes_Clothings_ClothingId",
                table: "ClothingSizes",
                column: "ClothingId",
                principalTable: "Clothings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClothingSizes_Clothings_ClothingId",
                table: "ClothingSizes");

            migrationBuilder.AlterColumn<int>(
                name: "ClothingId",
                table: "ClothingSizes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "ClothingSizes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_ClothingSizes_Clothings_ClothingId",
                table: "ClothingSizes",
                column: "ClothingId",
                principalTable: "Clothings",
                principalColumn: "Id");
        }
    }
}
