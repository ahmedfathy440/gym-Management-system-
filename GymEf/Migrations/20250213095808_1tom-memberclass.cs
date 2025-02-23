using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymEf.Migrations
{
    /// <inheritdoc />
    public partial class _1tommemberclass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClassId",
                table: "Members",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Members_ClassId",
                table: "Members",
                column: "ClassId");

            migrationBuilder.AddForeignKey(
                name: "FK_Members_classes_ClassId",
                table: "Members",
                column: "ClassId",
                principalTable: "classes",
                principalColumn: "ClassID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Members_classes_ClassId",
                table: "Members");

            migrationBuilder.DropIndex(
                name: "IX_Members_ClassId",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "ClassId",
                table: "Members");
        }
    }
}
