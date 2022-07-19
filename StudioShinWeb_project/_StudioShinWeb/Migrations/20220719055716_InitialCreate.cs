using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _StudioShinWeb.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "shinSiteMetrics",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pageViewsDebug = table.Column<int>(type: "int", nullable: false),
                    pageViewsRelease = table.Column<int>(type: "int", nullable: false),
                    EventsFiredRelease = table.Column<int>(type: "int", nullable: false),
                    EventsFiredDebug = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shinSiteMetrics", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "shinSiteMetrics");
        }
    }
}
