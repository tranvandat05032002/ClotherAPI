﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClotherAPI.Migrations
{
    /// <inheritdoc />
    public partial class DBInit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    userId = table.Column<string>(type: "text", nullable: false),
                    userName = table.Column<string>(type: "text", nullable: false),
                    email = table.Column<string>(type: "text", nullable: false),
                    password = table.Column<string>(type: "text", nullable: false),
                    verified = table.Column<int>(type: "integer", nullable: false),
                    resetToken = table.Column<string>(type: "text", nullable: false),
                    role = table.Column<int>(type: "integer", nullable: false),
                    avatar = table.Column<string>(type: "text", nullable: false),
                    phoneNumber = table.Column<string>(type: "text", nullable: false),
                    dateOfBirth = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.userId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
