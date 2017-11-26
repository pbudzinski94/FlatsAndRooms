using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace FlatsAndRooms.Migrations
{
    public partial class AddForeignKeysToAllEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EquipmentObjectToRents_Equipments_EquipmentId",
                table: "EquipmentObjectToRents");

            migrationBuilder.DropForeignKey(
                name: "FK_EquipmentObjectToRents_ObjectToRents_ObjectToRentId",
                table: "EquipmentObjectToRents");

            migrationBuilder.DropForeignKey(
                name: "FK_ObjectToRentPreferences_ObjectToRents_ObjectToRentId",
                table: "ObjectToRentPreferences");

            migrationBuilder.DropForeignKey(
                name: "FK_UserPreference_Users_UserId",
                table: "UserPreference");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "UserPreference",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ObjectToRentId",
                table: "ObjectToRentPreferences",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ObjectToRentId",
                table: "EquipmentObjectToRents",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "EquipmentId",
                table: "EquipmentObjectToRents",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_EquipmentObjectToRents_Equipments_EquipmentId",
                table: "EquipmentObjectToRents",
                column: "EquipmentId",
                principalTable: "Equipments",
                principalColumn: "EquipmentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EquipmentObjectToRents_ObjectToRents_ObjectToRentId",
                table: "EquipmentObjectToRents",
                column: "ObjectToRentId",
                principalTable: "ObjectToRents",
                principalColumn: "ObjectToRentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ObjectToRentPreferences_ObjectToRents_ObjectToRentId",
                table: "ObjectToRentPreferences",
                column: "ObjectToRentId",
                principalTable: "ObjectToRents",
                principalColumn: "ObjectToRentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserPreference_Users_UserId",
                table: "UserPreference",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EquipmentObjectToRents_Equipments_EquipmentId",
                table: "EquipmentObjectToRents");

            migrationBuilder.DropForeignKey(
                name: "FK_EquipmentObjectToRents_ObjectToRents_ObjectToRentId",
                table: "EquipmentObjectToRents");

            migrationBuilder.DropForeignKey(
                name: "FK_ObjectToRentPreferences_ObjectToRents_ObjectToRentId",
                table: "ObjectToRentPreferences");

            migrationBuilder.DropForeignKey(
                name: "FK_UserPreference_Users_UserId",
                table: "UserPreference");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "UserPreference",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "ObjectToRentId",
                table: "ObjectToRentPreferences",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "ObjectToRentId",
                table: "EquipmentObjectToRents",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "EquipmentId",
                table: "EquipmentObjectToRents",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_EquipmentObjectToRents_Equipments_EquipmentId",
                table: "EquipmentObjectToRents",
                column: "EquipmentId",
                principalTable: "Equipments",
                principalColumn: "EquipmentId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EquipmentObjectToRents_ObjectToRents_ObjectToRentId",
                table: "EquipmentObjectToRents",
                column: "ObjectToRentId",
                principalTable: "ObjectToRents",
                principalColumn: "ObjectToRentId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ObjectToRentPreferences_ObjectToRents_ObjectToRentId",
                table: "ObjectToRentPreferences",
                column: "ObjectToRentId",
                principalTable: "ObjectToRents",
                principalColumn: "ObjectToRentId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserPreference_Users_UserId",
                table: "UserPreference",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
