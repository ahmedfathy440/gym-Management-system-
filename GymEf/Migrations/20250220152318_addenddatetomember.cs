using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymEf.Migrations
{
    /// <inheritdoc />
    public partial class addenddatetomember : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PayEndedDate",
                table: "Payments");

            migrationBuilder.AddColumn<DateTime>(
                name: "MembershipEndDate",
                table: "Members",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MembershipEndDate",
                table: "Members");

            migrationBuilder.AddColumn<DateTime>(
                name: "PayEndedDate",
                table: "Payments",
                type: "datetime2",
                nullable: true);
        }
    }
}
