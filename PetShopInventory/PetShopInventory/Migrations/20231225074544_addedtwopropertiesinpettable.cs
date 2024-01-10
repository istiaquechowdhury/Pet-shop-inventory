using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetShopInventory.Migrations
{
    /// <inheritdoc />
    public partial class addedtwopropertiesinpettable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pets_Aquariums_AquariumId",
                table: "Pets");

            migrationBuilder.DropForeignKey(
                name: "FK_Pets_Cages_CageId",
                table: "Pets");

            migrationBuilder.AlterColumn<int>(
                name: "CageId",
                table: "Pets",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AquariumId",
                table: "Pets",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Pets_Aquariums_AquariumId",
                table: "Pets",
                column: "AquariumId",
                principalTable: "Aquariums",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pets_Cages_CageId",
                table: "Pets",
                column: "CageId",
                principalTable: "Cages",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pets_Aquariums_AquariumId",
                table: "Pets");

            migrationBuilder.DropForeignKey(
                name: "FK_Pets_Cages_CageId",
                table: "Pets");

            migrationBuilder.AlterColumn<int>(
                name: "CageId",
                table: "Pets",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AquariumId",
                table: "Pets",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Pets_Aquariums_AquariumId",
                table: "Pets",
                column: "AquariumId",
                principalTable: "Aquariums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pets_Cages_CageId",
                table: "Pets",
                column: "CageId",
                principalTable: "Cages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
