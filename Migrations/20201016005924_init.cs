using Microsoft.EntityFrameworkCore.Migrations;

namespace PropertyRental.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Properties",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    PropertyType = table.Column<string>(nullable: true),
                    PropertyStories = table.Column<int>(nullable: false),
                    PropertySize = table.Column<int>(nullable: false),
                    Bedrooms = table.Column<int>(nullable: false),
                    Bathrooms = table.Column<int>(nullable: false),
                    OtherDetails = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Properties", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Properties");
        }
    }
}
