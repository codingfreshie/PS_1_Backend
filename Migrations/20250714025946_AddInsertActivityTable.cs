using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PS_1_Backend.Migrations
{
    /// <inheritdoc />
    public partial class AddInsertActivityTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Insert_Activities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Source_of_Verification = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Denominator = table.Column<int>(type: "int", nullable: false),
                    Numerator = table.Column<int>(type: "int", nullable: false),
                    Work_Percentage = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Insert_Activities", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Insert_Activities");
        }
    }
}
