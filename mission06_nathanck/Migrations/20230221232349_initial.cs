using Microsoft.EntityFrameworkCore.Migrations;

namespace mission06_nathanck.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "responses",
                columns: table => new
                {
                    MovieId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(nullable: true),
                    Year = table.Column<short>(nullable: false),
                    Director = table.Column<string>(nullable: true),
                    Rating = table.Column<string>(nullable: true),
                    Edited = table.Column<bool>(nullable: false),
                    LentTo = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    MovieCategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_responses", x => x.MovieId);
                    table.ForeignKey(
                        name: "FK_responses_Movies_MovieCategoryId",
                        column: x => x.MovieCategoryId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CategoryName" },
                values: new object[] { 1, "Action/Adventure" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CategoryName" },
                values: new object[] { 2, "Comedy" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CategoryName" },
                values: new object[] { 3, "Drama" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CategoryName" },
                values: new object[] { 4, "Family" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CategoryName" },
                values: new object[] { 5, "Horror/suspense" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CategoryName" },
                values: new object[] { 6, "Misc" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CategoryName" },
                values: new object[] { 7, "Drama" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CategoryName" },
                values: new object[] { 8, "TV" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CategoryName" },
                values: new object[] { 9, "VHS" });

            migrationBuilder.CreateIndex(
                name: "IX_responses_MovieCategoryId",
                table: "responses",
                column: "MovieCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "responses");

            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
