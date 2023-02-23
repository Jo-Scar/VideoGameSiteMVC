using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VideoGameReviewSite.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VideoGame",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Reviews = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Publisher = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReleaseDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cost = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoGame", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "VideoGame",
                columns: new[] { "Id", "Cost", "Description", "ImageURL", "Publisher", "ReleaseDate", "Reviews", "Title" },
                values: new object[,]
                {
                    { 1, 1.0, "Call of Duty: Modern Warfare 2 is a 2009 first-person shooter game developed by Infinity Ward and published by Activision. It is the sixth installment in the Call of Duty series and the direct sequel to Call of Duty 4: Modern Warfare", "https://imgs.callofduty.com/content/dam/atvi/callofduty/cod-touchui/mw2/common/cod-mw2-logo.png", "Activision", "11/10/2009", "Troll Capital and full of glitches TL;DR: UI is full of bugs and issues. DMZ is full of squad hunting Trolls, multiplayer is full of hyped up Call of Duty League wanna bees, with either Smgs or no scope Snipers. The assault rifles all suck by comparision. ", "Call Of Duty Modern Warefare II" },
                    { 2, 65.950000000000003, "It is a simulation of the daily activities of one or more virtual people,Players control customizable Sims as they pursue career and relationship goals. Players can also use their Sims' income to renovate their living space, and purchase home furnishings, or clothing for their household. Players can also choose to pursue a social and successful life.", "https://upload.wikimedia.org/wikipedia/en/2/22/The_Sims_Coverart.png", "Electronic Arts", "02/04/2000", "This game is so, so, so, good, but has it's problems. The OST is some of the best I've heard in video games as a whole, the gameplay is challenging and exciting, and this game as so much personality to it. However, the game is wayyy too hard to actually relax in it ", "The Sims" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VideoGame");
        }
    }
}
