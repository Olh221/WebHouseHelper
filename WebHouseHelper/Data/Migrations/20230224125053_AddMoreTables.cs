using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebHouseHelper.Data.Migrations
{
    public partial class AddMoreTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Buildings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buildings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Designs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Designs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Driveways",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Driveways", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Electricitys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Electricitys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HouseCleanings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HouseCleanings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InsulationOfTheFacades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InsulationOfTheFacades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Landscapings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Landscapings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LayingTiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LayingTiles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Plumbinds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plumbinds", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoofCoverings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoofCoverings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WindowsInstalations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WindowsInstalations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MyServices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    ServicePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AverageUserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DrivewayId = table.Column<int>(type: "int", nullable: false),
                    InsulationOfTheFacadeId = table.Column<int>(type: "int", nullable: false),
                    WindowsInstalationId = table.Column<int>(type: "int", nullable: false),
                    HouseCleaningId = table.Column<int>(type: "int", nullable: false),
                    ElectricityId = table.Column<int>(type: "int", nullable: false),
                    BuildingId = table.Column<int>(type: "int", nullable: false),
                    RoofCoveringId = table.Column<int>(type: "int", nullable: false),
                    PlumbindId = table.Column<int>(type: "int", nullable: false),
                    LandscapingId = table.Column<int>(type: "int", nullable: false),
                    LayingTilesId = table.Column<int>(type: "int", nullable: false),
                    DesignId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MyServices_Buildings_BuildingId",
                        column: x => x.BuildingId,
                        principalTable: "Buildings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MyServices_Designs_DesignId",
                        column: x => x.DesignId,
                        principalTable: "Designs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MyServices_Driveways_DrivewayId",
                        column: x => x.DrivewayId,
                        principalTable: "Driveways",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MyServices_Electricitys_ElectricityId",
                        column: x => x.ElectricityId,
                        principalTable: "Electricitys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MyServices_HouseCleanings_HouseCleaningId",
                        column: x => x.HouseCleaningId,
                        principalTable: "HouseCleanings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MyServices_InsulationOfTheFacades_InsulationOfTheFacadeId",
                        column: x => x.InsulationOfTheFacadeId,
                        principalTable: "InsulationOfTheFacades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MyServices_Landscapings_LandscapingId",
                        column: x => x.LandscapingId,
                        principalTable: "Landscapings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MyServices_LayingTiles_LayingTilesId",
                        column: x => x.LayingTilesId,
                        principalTable: "LayingTiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MyServices_Plumbinds_PlumbindId",
                        column: x => x.PlumbindId,
                        principalTable: "Plumbinds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MyServices_RoofCoverings_RoofCoveringId",
                        column: x => x.RoofCoveringId,
                        principalTable: "RoofCoverings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MyServices_WindowsInstalations_WindowsInstalationId",
                        column: x => x.WindowsInstalationId,
                        principalTable: "WindowsInstalations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MyOrders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MyServicesId = table.Column<int>(type: "int", nullable: false),
                    DateOrdered = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Feedback = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AverageUserId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MyOrders_MyServices_MyServicesId",
                        column: x => x.MyServicesId,
                        principalTable: "MyServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MyOrders_MyServicesId",
                table: "MyOrders",
                column: "MyServicesId");

            migrationBuilder.CreateIndex(
                name: "IX_MyServices_BuildingId",
                table: "MyServices",
                column: "BuildingId");

            migrationBuilder.CreateIndex(
                name: "IX_MyServices_DesignId",
                table: "MyServices",
                column: "DesignId");

            migrationBuilder.CreateIndex(
                name: "IX_MyServices_DrivewayId",
                table: "MyServices",
                column: "DrivewayId");

            migrationBuilder.CreateIndex(
                name: "IX_MyServices_ElectricityId",
                table: "MyServices",
                column: "ElectricityId");

            migrationBuilder.CreateIndex(
                name: "IX_MyServices_HouseCleaningId",
                table: "MyServices",
                column: "HouseCleaningId");

            migrationBuilder.CreateIndex(
                name: "IX_MyServices_InsulationOfTheFacadeId",
                table: "MyServices",
                column: "InsulationOfTheFacadeId");

            migrationBuilder.CreateIndex(
                name: "IX_MyServices_LandscapingId",
                table: "MyServices",
                column: "LandscapingId");

            migrationBuilder.CreateIndex(
                name: "IX_MyServices_LayingTilesId",
                table: "MyServices",
                column: "LayingTilesId");

            migrationBuilder.CreateIndex(
                name: "IX_MyServices_PlumbindId",
                table: "MyServices",
                column: "PlumbindId");

            migrationBuilder.CreateIndex(
                name: "IX_MyServices_RoofCoveringId",
                table: "MyServices",
                column: "RoofCoveringId");

            migrationBuilder.CreateIndex(
                name: "IX_MyServices_WindowsInstalationId",
                table: "MyServices",
                column: "WindowsInstalationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MyOrders");

            migrationBuilder.DropTable(
                name: "MyServices");

            migrationBuilder.DropTable(
                name: "Buildings");

            migrationBuilder.DropTable(
                name: "Designs");

            migrationBuilder.DropTable(
                name: "Driveways");

            migrationBuilder.DropTable(
                name: "Electricitys");

            migrationBuilder.DropTable(
                name: "HouseCleanings");

            migrationBuilder.DropTable(
                name: "InsulationOfTheFacades");

            migrationBuilder.DropTable(
                name: "Landscapings");

            migrationBuilder.DropTable(
                name: "LayingTiles");

            migrationBuilder.DropTable(
                name: "Plumbinds");

            migrationBuilder.DropTable(
                name: "RoofCoverings");

            migrationBuilder.DropTable(
                name: "WindowsInstalations");
        }
    }
}
