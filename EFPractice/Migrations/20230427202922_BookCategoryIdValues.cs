using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFPractice.Migrations
{
    /// <inheritdoc />
    public partial class BookCategoryIdValues : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2,
                columns: new[] { "CategoryId", "Title" },
                values: new object[] { 2, "Title2" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "CategoryId", "Title" },
                values: new object[] { 1, 1, "Title" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2,
                columns: new[] { "CategoryId", "Title" },
                values: new object[] { 0, "Title" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "CategoryId", "Title" },
                values: new object[] { 3, 0, "Title2" });
        }
    }
}
