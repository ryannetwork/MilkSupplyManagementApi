﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace MilkManagement.Domain.Migrations
{
    public partial class removedCustomerTypeFromCustomerRates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerRates_CustomerTypes_CustomerTypeId",
                table: "CustomerRates");

            migrationBuilder.DropIndex(
                name: "IX_CustomerRates_CustomerTypeId",
                table: "CustomerRates");

            migrationBuilder.DropColumn(
                name: "CustomerTypeId",
                table: "CustomerRates");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerTypeId",
                table: "CustomerRates",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CustomerRates_CustomerTypeId",
                table: "CustomerRates",
                column: "CustomerTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerRates_CustomerTypes_CustomerTypeId",
                table: "CustomerRates",
                column: "CustomerTypeId",
                principalTable: "CustomerTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
