using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PS_1_Backend.Migrations
{
    /// <inheritdoc />
    public partial class AddCHONameToInsertActivity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CHO_Name",
                table: "Insert_Activities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CHO_Name",
                table: "Insert_Activities");
        }
    }
}
