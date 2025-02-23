using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymEf.Migrations
{
    /// <inheritdoc />
    public partial class _1to1membership : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Members_MembershipTypeID",
                table: "Members");

            migrationBuilder.CreateIndex(
                name: "IX_Members_MembershipTypeID",
                table: "Members",
                column: "MembershipTypeID",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Members_MembershipTypeID",
                table: "Members");

            migrationBuilder.CreateIndex(
                name: "IX_Members_MembershipTypeID",
                table: "Members",
                column: "MembershipTypeID");
        }
    }
}
