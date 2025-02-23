using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymEf.Migrations
{
    /// <inheritdoc />
    public partial class memmembership1tom : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MembershipTypeID",
                table: "Members",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Members_MembershipTypeID",
                table: "Members",
                column: "MembershipTypeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Members_membershipTypes_MembershipTypeID",
                table: "Members",
                column: "MembershipTypeID",
                principalTable: "membershipTypes",
                principalColumn: "MembershipTypeID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Members_membershipTypes_MembershipTypeID",
                table: "Members");

            migrationBuilder.DropIndex(
                name: "IX_Members_MembershipTypeID",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "MembershipTypeID",
                table: "Members");
        }
    }
}
