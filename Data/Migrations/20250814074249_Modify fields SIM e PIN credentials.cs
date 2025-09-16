using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CredentialsAPI.Data.Migrations
{
    /// <inheritdoc />
    public partial class ModifyfieldsSIMePINcredentials : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SIM_Serial",
                table: "Credentials",
                newName: "Sim_Serial");

            migrationBuilder.RenameColumn(
                name: "SIM_Operator",
                table: "Credentials",
                newName: "Sim_Operator");

            migrationBuilder.RenameColumn(
                name: "PUK",
                table: "Credentials",
                newName: "Puk");

            migrationBuilder.RenameColumn(
                name: "PIN_Carta",
                table: "Credentials",
                newName: "Pin_Carta");

            migrationBuilder.RenameColumn(
                name: "PIN_App",
                table: "Credentials",
                newName: "Pin_App");

            migrationBuilder.RenameColumn(
                name: "PIN",
                table: "Credentials",
                newName: "Pin");

            migrationBuilder.RenameColumn(
                name: "IBAN",
                table: "Credentials",
                newName: "Iban");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Sim_Serial",
                table: "Credentials",
                newName: "SIM_Serial");

            migrationBuilder.RenameColumn(
                name: "Sim_Operator",
                table: "Credentials",
                newName: "SIM_Operator");

            migrationBuilder.RenameColumn(
                name: "Puk",
                table: "Credentials",
                newName: "PUK");

            migrationBuilder.RenameColumn(
                name: "Pin_Carta",
                table: "Credentials",
                newName: "PIN_Carta");

            migrationBuilder.RenameColumn(
                name: "Pin_App",
                table: "Credentials",
                newName: "PIN_App");

            migrationBuilder.RenameColumn(
                name: "Pin",
                table: "Credentials",
                newName: "PIN");

            migrationBuilder.RenameColumn(
                name: "Iban",
                table: "Credentials",
                newName: "IBAN");
        }
    }
}
