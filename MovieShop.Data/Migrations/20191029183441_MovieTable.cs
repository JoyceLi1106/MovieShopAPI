using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieShop.Data.Migrations
{
    public partial class MovieTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 256, nullable: true),
                    Overview = table.Column<string>(maxLength: 4096, nullable: true),
                    Tagline = table.Column<string>(maxLength: 512, nullable: true),
                    Budget = table.Column<decimal>(nullable: true),
                    Revenue = table.Column<decimal>(nullable: true),
                    HomePage = table.Column<string>(maxLength: 2084, nullable: true),
                    ImdbUrl = table.Column<string>(maxLength: 2084, nullable: true),
                    TmdbUrl = table.Column<string>(nullable: true),
                    PosterUrl = table.Column<string>(maxLength: 2084, nullable: true),
                    BackdropUrl = table.Column<string>(maxLength: 2084, nullable: true),
                    OriginalLanguage = table.Column<string>(maxLength: 64, nullable: true),
                    ReleaseDate = table.Column<DateTime>(nullable: true),
                    RunTime = table.Column<int>(nullable: true),
                    IsReleased = table.Column<bool>(nullable: true),
                    Price = table.Column<decimal>(type: "decimal(5, 2)", nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movie_Title",
                table: "Movie",
                column: "Title");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movie");
        }
    }
}
