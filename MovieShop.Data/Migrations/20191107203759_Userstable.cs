using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieShop.Data.Migrations
{
    public partial class Userstable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 128, nullable: true),
                    LastName = table.Column<string>(maxLength: 128, nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    HashedPassword = table.Column<string>(maxLength: 1024, nullable: true),
                    Salt = table.Column<string>(maxLength: 1024, nullable: true),
                    PhoneNumber = table.Column<string>(maxLength: 16, nullable: true),
                    TwoFactorEnabled = table.Column<bool>(nullable: true),
                    LockoutEndDate = table.Column<DateTime>(nullable: true),
                    LastLoginDateTime = table.Column<DateTime>(nullable: true),
                    IsLocked = table.Column<bool>(nullable: true, defaultValue: false),
                    AccessFailedCount = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_User_Email",
                table: "User",
                column: "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
