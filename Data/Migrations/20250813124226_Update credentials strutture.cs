using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CredentialsAPI.Data.Migrations
{
    /// <inheritdoc />
    public partial class Updatecredentialsstrutture : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Credentials",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Credentials",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Credentials",
                type: "nvarchar(70)",
                maxLength: 70,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Area",
                table: "Credentials",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Codice_Dispositivo",
                table: "Credentials",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Codice_Sicurezza",
                table: "Credentials",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Data_Scadenza",
                table: "Credentials",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Expired_Date",
                table: "Credentials",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Frase_Identificativa",
                table: "Credentials",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IBAN",
                table: "Credentials",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Machine_IP",
                table: "Credentials",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Machine_Name",
                table: "Credentials",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Machine_Type",
                table: "Credentials",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nickname",
                table: "Credentials",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "Credentials",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Numero_Carta",
                table: "Credentials",
                type: "nvarchar(16)",
                maxLength: 16,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Numero_Cliente",
                table: "Credentials",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Operativity",
                table: "Credentials",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PIN",
                table: "Credentials",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PIN_App",
                table: "Credentials",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PIN_Carta",
                table: "Credentials",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PUK",
                table: "Credentials",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password_3D_Secure",
                table: "Credentials",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password_Admin",
                table: "Credentials",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password_Dispositiva",
                table: "Credentials",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password_First",
                table: "Credentials",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password_History",
                table: "Credentials",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Profilo",
                table: "Credentials",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SIM_Operator",
                table: "Credentials",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SIM_Serial",
                table: "Credentials",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Section",
                table: "Credentials",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SmartPhone_IMEI",
                table: "Credentials",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SmartPhone_Model",
                table: "Credentials",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SmartPhone_Serial",
                table: "Credentials",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SmartPhone_Supplier",
                table: "Credentials",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Subject_ID",
                table: "Credentials",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "User_Admin",
                table: "Credentials",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Area",
                table: "Credentials");

            migrationBuilder.DropColumn(
                name: "Codice_Dispositivo",
                table: "Credentials");

            migrationBuilder.DropColumn(
                name: "Codice_Sicurezza",
                table: "Credentials");

            migrationBuilder.DropColumn(
                name: "Data_Scadenza",
                table: "Credentials");

            migrationBuilder.DropColumn(
                name: "Expired_Date",
                table: "Credentials");

            migrationBuilder.DropColumn(
                name: "Frase_Identificativa",
                table: "Credentials");

            migrationBuilder.DropColumn(
                name: "IBAN",
                table: "Credentials");

            migrationBuilder.DropColumn(
                name: "Machine_IP",
                table: "Credentials");

            migrationBuilder.DropColumn(
                name: "Machine_Name",
                table: "Credentials");

            migrationBuilder.DropColumn(
                name: "Machine_Type",
                table: "Credentials");

            migrationBuilder.DropColumn(
                name: "Nickname",
                table: "Credentials");

            migrationBuilder.DropColumn(
                name: "Note",
                table: "Credentials");

            migrationBuilder.DropColumn(
                name: "Numero_Carta",
                table: "Credentials");

            migrationBuilder.DropColumn(
                name: "Numero_Cliente",
                table: "Credentials");

            migrationBuilder.DropColumn(
                name: "Operativity",
                table: "Credentials");

            migrationBuilder.DropColumn(
                name: "PIN",
                table: "Credentials");

            migrationBuilder.DropColumn(
                name: "PIN_App",
                table: "Credentials");

            migrationBuilder.DropColumn(
                name: "PIN_Carta",
                table: "Credentials");

            migrationBuilder.DropColumn(
                name: "PUK",
                table: "Credentials");

            migrationBuilder.DropColumn(
                name: "Password_3D_Secure",
                table: "Credentials");

            migrationBuilder.DropColumn(
                name: "Password_Admin",
                table: "Credentials");

            migrationBuilder.DropColumn(
                name: "Password_Dispositiva",
                table: "Credentials");

            migrationBuilder.DropColumn(
                name: "Password_First",
                table: "Credentials");

            migrationBuilder.DropColumn(
                name: "Password_History",
                table: "Credentials");

            migrationBuilder.DropColumn(
                name: "Profilo",
                table: "Credentials");

            migrationBuilder.DropColumn(
                name: "SIM_Operator",
                table: "Credentials");

            migrationBuilder.DropColumn(
                name: "SIM_Serial",
                table: "Credentials");

            migrationBuilder.DropColumn(
                name: "Section",
                table: "Credentials");

            migrationBuilder.DropColumn(
                name: "SmartPhone_IMEI",
                table: "Credentials");

            migrationBuilder.DropColumn(
                name: "SmartPhone_Model",
                table: "Credentials");

            migrationBuilder.DropColumn(
                name: "SmartPhone_Serial",
                table: "Credentials");

            migrationBuilder.DropColumn(
                name: "SmartPhone_Supplier",
                table: "Credentials");

            migrationBuilder.DropColumn(
                name: "Subject_ID",
                table: "Credentials");

            migrationBuilder.DropColumn(
                name: "User_Admin",
                table: "Credentials");

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Credentials",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Credentials",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Credentials",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(70)",
                oldMaxLength: 70,
                oldNullable: true);
        }
    }
}
