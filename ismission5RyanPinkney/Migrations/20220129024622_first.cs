using Microsoft.EntityFrameworkCore.Migrations;

namespace ismission5RyanPinkney.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categories",
                columns: table => new
                {
                    Category_id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    sCategory_name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categories", x => x.Category_id);
                });

            migrationBuilder.CreateTable(
                name: "responses",
                columns: table => new
                {
                    movie_id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    sTitle = table.Column<string>(nullable: false),
                    sYear = table.Column<string>(nullable: false),
                    sDirector = table.Column<string>(nullable: false),
                    sRating = table.Column<string>(nullable: false),
                    bIsEdited = table.Column<bool>(nullable: false),
                    sLentToName = table.Column<string>(nullable: true),
                    sNotes = table.Column<string>(nullable: true),
                    Category_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_responses", x => x.movie_id);
                    table.ForeignKey(
                        name: "FK_responses_categories_Category_id",
                        column: x => x.Category_id,
                        principalTable: "categories",
                        principalColumn: "Category_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "Category_id", "sCategory_name" },
                values: new object[] { 1, "Action/Adventure" });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "Category_id", "sCategory_name" },
                values: new object[] { 2, "Comedy" });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "Category_id", "sCategory_name" },
                values: new object[] { 3, "Drama" });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "Category_id", "sCategory_name" },
                values: new object[] { 4, "Family" });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "Category_id", "sCategory_name" },
                values: new object[] { 5, "Horror/Suspense" });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "Category_id", "sCategory_name" },
                values: new object[] { 6, "Miscellaneous" });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "Category_id", "sCategory_name" },
                values: new object[] { 7, "Television" });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "Category_id", "sCategory_name" },
                values: new object[] { 8, "VHS" });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "movie_id", "Category_id", "bIsEdited", "sDirector", "sLentToName", "sNotes", "sRating", "sTitle", "sYear" },
                values: new object[] { 1, 1, false, "Joss Whedon", "", "", "PG-13", "Avenger, The", "2012" });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "movie_id", "Category_id", "bIsEdited", "sDirector", "sLentToName", "sNotes", "sRating", "sTitle", "sYear" },
                values: new object[] { 2, 1, false, "Tim Burton", "", "", "PG-13", "Batman", "1989" });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "movie_id", "Category_id", "bIsEdited", "sDirector", "sLentToName", "sNotes", "sRating", "sTitle", "sYear" },
                values: new object[] { 3, 1, false, "Joel Schumacher", "", "", "PG-13", "Batman & Robin", "1997" });

            migrationBuilder.CreateIndex(
                name: "IX_responses_Category_id",
                table: "responses",
                column: "Category_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "responses");

            migrationBuilder.DropTable(
                name: "categories");
        }
    }
}
