using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace warehousebe.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Warehouse",
                columns: table => new
                {
                    _id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warehouse", x => x._id);
                });

            migrationBuilder.CreateTable(
                name: "Car",
                columns: table => new
                {
                    CarId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WarehouseId = table.Column<int>(type: "int", nullable: false),
                    location = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Car", x => x.CarId);
                    table.ForeignKey(
                        name: "FK_Car_Warehouse_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "Warehouse",
                        principalColumn: "_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    LocationId = table.Column<int>(type: "int", nullable: false),
                    WarehouseId = table.Column<int>(type: "int", nullable: false),
                    lat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    @long = table.Column<string>(name: "long", type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.LocationId);
                    table.ForeignKey(
                        name: "FK_Location_Warehouse_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Warehouse",
                        principalColumn: "_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vehicle",
                columns: table => new
                {
                    _id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarId = table.Column<int>(type: "int", nullable: false),
                    make = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    year_model = table.Column<int>(type: "int", nullable: false),
                    price = table.Column<double>(type: "float", nullable: false),
                    licensed = table.Column<bool>(type: "bit", nullable: false),
                    date_added = table.Column<DateTime>(type: "Date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicle", x => x._id);
                    table.ForeignKey(
                        name: "FK_Vehicle_Car_CarId",
                        column: x => x.CarId,
                        principalTable: "Car",
                        principalColumn: "CarId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Car_WarehouseId",
                table: "Car",
                column: "WarehouseId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_CarId",
                table: "Vehicle",
                column: "CarId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "Vehicle");

            migrationBuilder.DropTable(
                name: "Car");

            migrationBuilder.DropTable(
                name: "Warehouse");
        }
    }
}
