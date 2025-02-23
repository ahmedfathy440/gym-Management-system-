using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymEf.Migrations
{
    /// <inheritdoc />
    public partial class makemembershipIdnotuniqe : Migration
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
                column: "MembershipTypeID");
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
                column: "MembershipTypeID",
                unique: true,
                filter: "[MembershipTypeID] IS NOT NULL");
        }
    }
}
