using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eproject_prep2.Migrations
{
    /// <inheritdoc />
    public partial class addimagepathtoproduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Imagepath",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Imagepath",
                table: "Products");
        }
    }
}
