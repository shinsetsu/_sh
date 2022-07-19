using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _StudioShinWeb.Migrations
{
    public partial class shinip : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "shinIps2",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IpType = table.Column<int>(type: "int", nullable: true),
                    seenDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    timesSeenDay = table.Column<int>(type: "int", nullable: true),
                    timesSeenCount = table.Column<long>(type: "bigint", nullable: true),
                    totalIpsSeen = table.Column<long>(type: "bigint", nullable: true),
                    countCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    countName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    stateABR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    state = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    city = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    zip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    latitude = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    longitude = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shinIps2", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "shinIps2");
        }
    }
}
