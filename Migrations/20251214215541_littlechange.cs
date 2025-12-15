using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoFinalTecWeb.Migrations
{
    /// <inheritdoc />
    public partial class littlechange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trips_Driveres_DriverId",
                table: "Trips");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Driveres_DriverId",
                table: "Vehicles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Driveres",
                table: "Driveres");

            migrationBuilder.RenameTable(
                name: "Driveres",
                newName: "Drivers");

            migrationBuilder.RenameColumn(
                name: "year",
                table: "Models",
                newName: "Year");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Drivers",
                table: "Drivers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Trips_Drivers_DriverId",
                table: "Trips",
                column: "DriverId",
                principalTable: "Drivers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Drivers_DriverId",
                table: "Vehicles",
                column: "DriverId",
                principalTable: "Drivers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trips_Drivers_DriverId",
                table: "Trips");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Drivers_DriverId",
                table: "Vehicles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Drivers",
                table: "Drivers");

            migrationBuilder.RenameTable(
                name: "Drivers",
                newName: "Driveres");

            migrationBuilder.RenameColumn(
                name: "Year",
                table: "Models",
                newName: "year");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Driveres",
                table: "Driveres",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Trips_Driveres_DriverId",
                table: "Trips",
                column: "DriverId",
                principalTable: "Driveres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Driveres_DriverId",
                table: "Vehicles",
                column: "DriverId",
                principalTable: "Driveres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
