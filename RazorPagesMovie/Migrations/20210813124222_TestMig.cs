using Microsoft.EntityFrameworkCore.Migrations;

namespace RazorPagesMovie.Migrations
{
    public partial class TestMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TestMig",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestMig", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TestMig");
        }
    }
}
