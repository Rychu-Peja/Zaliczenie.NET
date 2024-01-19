using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjektnaASP.Migrations
{
    /// <inheritdoc />
    public partial class addProductsToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListPrice = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Price5 = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ListPrice", "Price", "Price5", "Title" },
                values: new object[,]
                {
                    { 1, "\"Star Wars\" is a space opera about the battle between the Jedi and the Sith. Centered around characters like Luke Skywalker and Darth Vader, the saga explores themes of family and the eternal struggle between good and evil.", 45.0, 45.0, 40.0, "Star Wars" },
                    { 2, "\"The Hobbit\" is a fantasy novel by J.R.R. Tolkien, following the journey of Bilbo Baggins as he accompanies a group of dwarves on a quest to reclaim their homeland. Filled with magical creatures, epic adventures, and the discovery of a powerful ring, the story sets the stage for the events of \"The Lord of the Rings\" trilogy.", 40.0, 40.0, 35.0, "Hobbit" },
                    { 3, "\r\n\"Indiana Jones\" is an action-adventure film series created by George Lucas and Steven Spielberg. The stories follow the adventures of Dr. Indiana Jones, an archaeologist and professor, as he travels the globe in pursuit of mystical artifacts. Known for its thrilling action sequences and iconic character, the franchise captures the essence of classic adventure storytelling", 55.0, 55.0, 50.0, "Vanish in the Sunset" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);
        }
    }
}
