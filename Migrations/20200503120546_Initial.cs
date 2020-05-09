using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DesignManagement.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 64, nullable: false),
                    DesignStartDate = table.Column<DateTime>(nullable: false),
                    DesignEndDate = table.Column<DateTime>(nullable: false),
                    RealEstateType = table.Column<int>(nullable: false),
                    Area = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    Client = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Projects");
        }
    }
}
