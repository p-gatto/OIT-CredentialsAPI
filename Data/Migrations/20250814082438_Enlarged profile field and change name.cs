using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CredentialsAPI.Data.Migrations
{
    /// <inheritdoc />
    public partial class Enlargedprofilefieldandchangename : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Profilo",
                table: "Credentials");

            migrationBuilder.AddColumn<string>(
                name: "Profile",
                table: "Credentials",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Profile",
                table: "Credentials");

            migrationBuilder.AddColumn<string>(
                name: "Profilo",
                table: "Credentials",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);
        }
    }
}
