using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CredentialsAPI.Data.Migrations
{
    /// <inheritdoc />
    public partial class UsageCounteLastUsed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "LastUsed",
                table: "Credentials",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UsageCount",
                table: "Credentials",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastUsed",
                table: "Credentials");

            migrationBuilder.DropColumn(
                name: "UsageCount",
                table: "Credentials");
        }
    }
}
