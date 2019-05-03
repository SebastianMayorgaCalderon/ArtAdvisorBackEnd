using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtAdvisorBackEnd.Migrations
{
    public partial class addedMuseumAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prices_Museums_MuseumId",
                table: "Prices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Prices",
                table: "Prices");

            migrationBuilder.RenameTable(
                name: "Prices",
                newName: "Price");

            migrationBuilder.RenameIndex(
                name: "IX_Prices_MuseumId",
                table: "Price",
                newName: "IX_Price_MuseumId");

            migrationBuilder.AddColumn<Guid>(
                name: "MuseumAdminId",
                table: "Museums",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Price",
                table: "Price",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Museums_MuseumAdminId",
                table: "Museums",
                column: "MuseumAdminId");

            migrationBuilder.AddForeignKey(
                name: "FK_Museums_Users_MuseumAdminId",
                table: "Museums",
                column: "MuseumAdminId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Price_Museums_MuseumId",
                table: "Price",
                column: "MuseumId",
                principalTable: "Museums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Museums_Users_MuseumAdminId",
                table: "Museums");

            migrationBuilder.DropForeignKey(
                name: "FK_Price_Museums_MuseumId",
                table: "Price");

            migrationBuilder.DropIndex(
                name: "IX_Museums_MuseumAdminId",
                table: "Museums");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Price",
                table: "Price");

            migrationBuilder.DropColumn(
                name: "MuseumAdminId",
                table: "Museums");

            migrationBuilder.RenameTable(
                name: "Price",
                newName: "Prices");

            migrationBuilder.RenameIndex(
                name: "IX_Price_MuseumId",
                table: "Prices",
                newName: "IX_Prices_MuseumId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Prices",
                table: "Prices",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Prices_Museums_MuseumId",
                table: "Prices",
                column: "MuseumId",
                principalTable: "Museums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
