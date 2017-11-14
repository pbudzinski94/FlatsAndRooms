using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace FlatsAndRooms.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Equipments",
                columns: table => new
                {
                    EquipmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EquipmentName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipments", x => x.EquipmentId);
                });

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    LocationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Latitude = table.Column<float>(type: "real", nullable: false),
                    Longitude = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.LocationId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NickName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "ObjectToRents",
                columns: table => new
                {
                    ObjectToRentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Floor = table.Column<int>(type: "int", nullable: false),
                    LocationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    RoomsNumber = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ObjectToRents", x => x.ObjectToRentId);
                    table.ForeignKey(
                        name: "FK_ObjectToRents_Location_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Location",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ObjectToRents_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EquipmentObjectToRents",
                columns: table => new
                {
                    EquipmentObjectToRentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EquipmentDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EquipmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ObjectToRentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentObjectToRents", x => x.EquipmentObjectToRentId);
                    table.ForeignKey(
                        name: "FK_EquipmentObjectToRents_Equipments_EquipmentId",
                        column: x => x.EquipmentId,
                        principalTable: "Equipments",
                        principalColumn: "EquipmentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EquipmentObjectToRents_ObjectToRents_ObjectToRentId",
                        column: x => x.ObjectToRentId,
                        principalTable: "ObjectToRents",
                        principalColumn: "ObjectToRentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ObjectToRentPreferences",
                columns: table => new
                {
                    ObjectToRentPreferenceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ObjectToRentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PreferenceDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ObjectToRentPreferences", x => x.ObjectToRentPreferenceId);
                    table.ForeignKey(
                        name: "FK_ObjectToRentPreferences_ObjectToRents_ObjectToRentId",
                        column: x => x.ObjectToRentId,
                        principalTable: "ObjectToRents",
                        principalColumn: "ObjectToRentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserPreference",
                columns: table => new
                {
                    UserPreferenceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ObjectToRentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PreferenceDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPreference", x => x.UserPreferenceId);
                    table.ForeignKey(
                        name: "FK_UserPreference_ObjectToRents_ObjectToRentId",
                        column: x => x.ObjectToRentId,
                        principalTable: "ObjectToRents",
                        principalColumn: "ObjectToRentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserPreference_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentObjectToRents_EquipmentId",
                table: "EquipmentObjectToRents",
                column: "EquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentObjectToRents_ObjectToRentId",
                table: "EquipmentObjectToRents",
                column: "ObjectToRentId");

            migrationBuilder.CreateIndex(
                name: "IX_ObjectToRentPreferences_ObjectToRentId",
                table: "ObjectToRentPreferences",
                column: "ObjectToRentId");

            migrationBuilder.CreateIndex(
                name: "IX_ObjectToRents_LocationId",
                table: "ObjectToRents",
                column: "LocationId",
                unique: true,
                filter: "[LocationId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ObjectToRents_UserId",
                table: "ObjectToRents",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPreference_ObjectToRentId",
                table: "UserPreference",
                column: "ObjectToRentId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPreference_UserId",
                table: "UserPreference",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EquipmentObjectToRents");

            migrationBuilder.DropTable(
                name: "ObjectToRentPreferences");

            migrationBuilder.DropTable(
                name: "UserPreference");

            migrationBuilder.DropTable(
                name: "Equipments");

            migrationBuilder.DropTable(
                name: "ObjectToRents");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
