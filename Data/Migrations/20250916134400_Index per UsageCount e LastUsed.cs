using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CredentialsAPI.Data.Migrations
{
    /// <inheritdoc />
    public partial class IndexperUsageCounteLastUsed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Credentials_Active_LastUsed",
                table: "Credentials",
                columns: new[] { "Active", "LastUsed" });

            migrationBuilder.CreateIndex(
                name: "IX_Credentials_Active_UsageCount",
                table: "Credentials",
                columns: new[] { "Active", "UsageCount" });

            migrationBuilder.CreateIndex(
                name: "IX_Credentials_LastUsed",
                table: "Credentials",
                column: "LastUsed");

            migrationBuilder.CreateIndex(
                name: "IX_Credentials_UsageCount",
                table: "Credentials",
                column: "UsageCount");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Credentials_Active_LastUsed",
                table: "Credentials");

            migrationBuilder.DropIndex(
                name: "IX_Credentials_Active_UsageCount",
                table: "Credentials");

            migrationBuilder.DropIndex(
                name: "IX_Credentials_LastUsed",
                table: "Credentials");

            migrationBuilder.DropIndex(
                name: "IX_Credentials_UsageCount",
                table: "Credentials");
        }
    }
}
