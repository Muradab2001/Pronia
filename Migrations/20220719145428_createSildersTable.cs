using Microsoft.EntityFrameworkCore.Migrations;

namespace pronia.Migrations
{
    public partial class createSildersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "silders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(nullable: true),
                    Discount = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Article = table.Column<string>(nullable: true),
                    ButtonUrl = table.Column<string>(nullable: true),
                    Order = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_silders", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "silders");
        }
    }
}
