using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PS_1_Backend.Migrations
{
    /// <inheritdoc />
    public partial class AddDistrictAndBlockToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Block_Name",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "District_Name",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Block_Name",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "District_Name",
                table: "Users");
        }
    }
}
