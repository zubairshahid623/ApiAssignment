using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class ffff : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User_Details",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    id = table.Column<int>(type: "int", nullable: false),
                    vtype = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    time = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    loc = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User_Details");
        }
    }
}
