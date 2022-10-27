﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RealWorldApi.Migrations
{
    public partial class AddUniqueUserUsername : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_USERS_Username",
                table: "USERS",
                column: "Username",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_USERS_Username",
                table: "USERS");
        }
    }
}
