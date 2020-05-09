using Microsoft.EntityFrameworkCore.Migrations;

namespace DesignManagement.Migrations
{
    public partial class AddDesignSupervision : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn("PricePerSquareMeter", "Projects", "Price");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Projects",
                type: "decimal(8,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)");

            migrationBuilder.AddColumn<bool>(
                name: "HasDesignSupervision",
                table: "Projects",
                nullable: true,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HasDesignSupervision",
                table: "Projects");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Projects",
                type: "decimal(18,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(8,2)");
        }
    }
}
