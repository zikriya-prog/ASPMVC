using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class init1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tbl_Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "tbl_Students",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Ali" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tbl_Students",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.InsertData(
                table: "tbl_Students",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Ali" });
        }
    }
}
