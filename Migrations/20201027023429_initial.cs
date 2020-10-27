using Microsoft.EntityFrameworkCore.Migrations;

namespace PropertyRental.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PropertyType",
                table: "Properties",
                newName: "propertyType");

            migrationBuilder.RenameColumn(
                name: "PropertyStories",
                table: "Properties",
                newName: "propertyStories");

            migrationBuilder.RenameColumn(
                name: "PropertySize",
                table: "Properties",
                newName: "propertySize");

            migrationBuilder.RenameColumn(
                name: "OtherDetails",
                table: "Properties",
                newName: "otherDetails");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Properties",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Properties",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Bedrooms",
                table: "Properties",
                newName: "bedrooms");

            migrationBuilder.RenameColumn(
                name: "Bathrooms",
                table: "Properties",
                newName: "bathrooms");

            migrationBuilder.AddColumn<string>(
                name: "imageUrl",
                table: "Properties",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "parking",
                table: "Properties",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<decimal>(
                name: "price",
                table: "Properties",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "title",
                table: "Properties",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "imageUrl",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "parking",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "price",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "title",
                table: "Properties");

            migrationBuilder.RenameColumn(
                name: "propertyType",
                table: "Properties",
                newName: "PropertyType");

            migrationBuilder.RenameColumn(
                name: "propertyStories",
                table: "Properties",
                newName: "PropertyStories");

            migrationBuilder.RenameColumn(
                name: "propertySize",
                table: "Properties",
                newName: "PropertySize");

            migrationBuilder.RenameColumn(
                name: "otherDetails",
                table: "Properties",
                newName: "OtherDetails");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Properties",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Properties",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "bedrooms",
                table: "Properties",
                newName: "Bedrooms");

            migrationBuilder.RenameColumn(
                name: "bathrooms",
                table: "Properties",
                newName: "Bathrooms");
        }
    }
}
