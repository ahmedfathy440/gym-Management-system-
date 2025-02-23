using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymEf.Migrations
{
    /// <inheritdoc />
    public partial class _1to1memberpayment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "memberId",
                table: "Payments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Payments_memberId",
                table: "Payments",
                column: "memberId");

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Members_memberId",
                table: "Payments",
                column: "memberId",
                principalTable: "Members",
                principalColumn: "MemberID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Members_memberId",
                table: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_Payments_memberId",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "memberId",
                table: "Payments");
        }
    }
}
