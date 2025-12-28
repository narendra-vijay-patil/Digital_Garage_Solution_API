using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Digital_Garage_Solutions_API.Migrations
{
    /// <inheritdoc />
    public partial class GarageRegistration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_GarageRegistratioin",
                table: "GarageRegistratioin");

            migrationBuilder.RenameTable(
                name: "GarageRegistratioin",
                newName: "GarageRegistration");

            migrationBuilder.AddColumn<bool>(
                name: "GISActive",
                table: "GarageRegistration",
                type: "bit",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_GarageRegistration",
                table: "GarageRegistration",
                column: "GarageId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_GarageRegistration",
                table: "GarageRegistration");

            migrationBuilder.DropColumn(
                name: "GISActive",
                table: "GarageRegistration");

            migrationBuilder.RenameTable(
                name: "GarageRegistration",
                newName: "GarageRegistratioin");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GarageRegistratioin",
                table: "GarageRegistratioin",
                column: "GarageId");
        }
    }
}
