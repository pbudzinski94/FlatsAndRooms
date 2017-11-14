﻿using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace FlatsAndRooms.Migrations
{
    public partial class ChangesWhichAllowAddingObjectsToRent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ObjectToRents_Location_LocationId",
                table: "ObjectToRents");

            migrationBuilder.DropForeignKey(
                name: "FK_ObjectToRents_Users_UserId",
                table: "ObjectToRents");

            migrationBuilder.DropIndex(
                name: "IX_ObjectToRents_LocationId",
                table: "ObjectToRents");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "ObjectToRents",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "LocationId",
                table: "ObjectToRents",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ObjectToRents_LocationId",
                table: "ObjectToRents",
                column: "LocationId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ObjectToRents_Location_LocationId",
                table: "ObjectToRents",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ObjectToRents_Users_UserId",
                table: "ObjectToRents",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ObjectToRents_Location_LocationId",
                table: "ObjectToRents");

            migrationBuilder.DropForeignKey(
                name: "FK_ObjectToRents_Users_UserId",
                table: "ObjectToRents");

            migrationBuilder.DropIndex(
                name: "IX_ObjectToRents_LocationId",
                table: "ObjectToRents");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "ObjectToRents",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "LocationId",
                table: "ObjectToRents",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.CreateIndex(
                name: "IX_ObjectToRents_LocationId",
                table: "ObjectToRents",
                column: "LocationId",
                unique: true,
                filter: "[LocationId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_ObjectToRents_Location_LocationId",
                table: "ObjectToRents",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ObjectToRents_Users_UserId",
                table: "ObjectToRents",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
