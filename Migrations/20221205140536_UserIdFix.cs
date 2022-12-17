using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Test2.Migrations
{
    /// <inheritdoc />
    public partial class UserIdFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BasketballNiId",
                table: "Teams",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BasketballNiId",
                table: "Players",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BasketballNiId",
                table: "Leagues",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BasketballNiId",
                table: "FixturesAndResults",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BasketballNiId",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "BasketballNiId",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "BasketballNiId",
                table: "Leagues");

            migrationBuilder.DropColumn(
                name: "BasketballNiId",
                table: "FixturesAndResults");
        }
    }
}
