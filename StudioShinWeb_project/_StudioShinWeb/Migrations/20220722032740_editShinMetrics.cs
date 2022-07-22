using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _StudioShinWeb.Migrations
{
    public partial class editShinMetrics : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "pageViewsDebug",
                table: "shinSiteMetrics");

            migrationBuilder.DropColumn(
                name: "pageViewsRelease",
                table: "shinSiteMetrics");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "pageViewsDebug",
                table: "shinSiteMetrics",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "pageViewsRelease",
                table: "shinSiteMetrics",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
