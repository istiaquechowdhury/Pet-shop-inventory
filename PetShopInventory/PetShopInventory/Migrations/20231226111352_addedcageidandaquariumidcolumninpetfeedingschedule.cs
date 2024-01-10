using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetShopInventory.Migrations
{
    /// <inheritdoc />
    public partial class addedcageidandaquariumidcolumninpetfeedingschedule : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AquariumId",
                table: "PetFeedingSchedules",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CageId",
                table: "PetFeedingSchedules",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PetFeedingSchedules_AquariumId",
                table: "PetFeedingSchedules",
                column: "AquariumId");

            migrationBuilder.CreateIndex(
                name: "IX_PetFeedingSchedules_CageId",
                table: "PetFeedingSchedules",
                column: "CageId");

            migrationBuilder.AddForeignKey(
                name: "FK_PetFeedingSchedules_Aquariums_AquariumId",
                table: "PetFeedingSchedules",
                column: "AquariumId",
                principalTable: "Aquariums",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PetFeedingSchedules_Cages_CageId",
                table: "PetFeedingSchedules",
                column: "CageId",
                principalTable: "Cages",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PetFeedingSchedules_Aquariums_AquariumId",
                table: "PetFeedingSchedules");

            migrationBuilder.DropForeignKey(
                name: "FK_PetFeedingSchedules_Cages_CageId",
                table: "PetFeedingSchedules");

            migrationBuilder.DropIndex(
                name: "IX_PetFeedingSchedules_AquariumId",
                table: "PetFeedingSchedules");

            migrationBuilder.DropIndex(
                name: "IX_PetFeedingSchedules_CageId",
                table: "PetFeedingSchedules");

            migrationBuilder.DropColumn(
                name: "AquariumId",
                table: "PetFeedingSchedules");

            migrationBuilder.DropColumn(
                name: "CageId",
                table: "PetFeedingSchedules");
        }
    }
}
