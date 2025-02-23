using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymEf.Migrations
{
    /// <inheritdoc />
    public partial class classtrain1tom : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TrainerID",
                table: "classes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_classes_TrainerID",
                table: "classes",
                column: "TrainerID");

            migrationBuilder.AddForeignKey(
                name: "FK_classes_Trainers_TrainerID",
                table: "classes",
                column: "TrainerID",
                principalTable: "Trainers",
                principalColumn: "TrainerID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_classes_Trainers_TrainerID",
                table: "classes");

            migrationBuilder.DropIndex(
                name: "IX_classes_TrainerID",
                table: "classes");

            migrationBuilder.DropColumn(
                name: "TrainerID",
                table: "classes");
        }
    }
}
