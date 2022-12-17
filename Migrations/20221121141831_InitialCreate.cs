using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Test2.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FixturesAndResults",
                columns: table => new
                {
                    Matchid = table.Column<int>(name: "Match_id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Hometeam = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Awayteam = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Homescore = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Awayscore = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DatefGame = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FixturesAndResults", x => x.Matchid);
                });

            migrationBuilder.CreateTable(
                name: "Leagues",
                columns: table => new
                {
                    Leagueid = table.Column<int>(name: "League_id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Leaguename = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LeagueDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Level = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leagues", x => x.Leagueid);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Playerid = table.Column<int>(name: "Player_id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeamName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Points = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rebounds = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Assists = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Blocks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Steals = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Playerid);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LeagueName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Userid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Leagueid = table.Column<int>(name: "League_id", type: "int", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Userpassword = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Userid);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FixturesAndResults");

            migrationBuilder.DropTable(
                name: "Leagues");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
