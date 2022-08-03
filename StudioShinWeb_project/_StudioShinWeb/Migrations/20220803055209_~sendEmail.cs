using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _StudioShinWeb.Migrations
{
    public partial class sendEmail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "seenDate",
                table: "shinIps2");

            migrationBuilder.DropColumn(
                name: "timesSeenCount",
                table: "shinIps2");

            migrationBuilder.RenameColumn(
                name: "timesSeenDay",
                table: "shinIps2",
                newName: "resumePageView");

            migrationBuilder.AddColumn<DateTime>(
                name: "firstSeenDate",
                table: "shinIps2",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "indexPageViews",
                table: "shinIps2",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "lastSeenDate",
                table: "shinIps2",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "shinEmail",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ToEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FromEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FromName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MessageBody = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shinEmail", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "shinEmail");

            migrationBuilder.DropColumn(
                name: "firstSeenDate",
                table: "shinIps2");

            migrationBuilder.DropColumn(
                name: "indexPageViews",
                table: "shinIps2");

            migrationBuilder.DropColumn(
                name: "lastSeenDate",
                table: "shinIps2");

            migrationBuilder.RenameColumn(
                name: "resumePageView",
                table: "shinIps2",
                newName: "timesSeenDay");

            migrationBuilder.AddColumn<DateTime>(
                name: "seenDate",
                table: "shinIps2",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "timesSeenCount",
                table: "shinIps2",
                type: "bigint",
                nullable: true);
        }
    }
}
