using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PS_1_Backend.Migrations
{
    /// <inheritdoc />
    public partial class AddColumnsToCHOActivity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CHO_Activities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HSc_List = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Finanicial_Year_list = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Financial_Month_List = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ASHA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ANM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CHO = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CHO_Activities", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CHO_Activities");
        }
    }
}
