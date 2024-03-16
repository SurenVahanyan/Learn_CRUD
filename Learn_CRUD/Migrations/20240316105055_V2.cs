using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Learn_CRUD.Migrations
{
    /// <inheritdoc />
    public partial class V2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_NewsTable",
                table: "NewsTable");

            migrationBuilder.RenameTable(
                name: "NewsTable",
                newName: "FoodTable");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FoodTable",
                table: "FoodTable",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_FoodTable",
                table: "FoodTable");

            migrationBuilder.RenameTable(
                name: "FoodTable",
                newName: "NewsTable");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NewsTable",
                table: "NewsTable",
                column: "Id");
        }
    }
}
