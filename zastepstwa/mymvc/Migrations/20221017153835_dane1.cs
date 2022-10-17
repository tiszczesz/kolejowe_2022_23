using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mymvc.Migrations
{
    public partial class dane1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Firstname", "Lastname" },
                values: new object[,]
                {
                    { 1, "Antoni", "Małecki" },
                    { 2, "Antoni", "Małecki" },
                    { 3, "Monika", "Gruszka" },
                    { 4, "Renata", "Malina" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
