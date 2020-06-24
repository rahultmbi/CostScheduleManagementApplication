using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
    public partial class ImprinttableUpdateMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ContriutorName",
                table: "Imprint",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CoverType",
                table: "Imprint",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EditorName",
                table: "Imprint",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImprintType",
                table: "CostTempletes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RoyaltyTemplateName",
                table: "CostTempletes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SalesType",
                table: "CostTempletes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContriutorName",
                table: "Imprint");

            migrationBuilder.DropColumn(
                name: "CoverType",
                table: "Imprint");

            migrationBuilder.DropColumn(
                name: "EditorName",
                table: "Imprint");

            migrationBuilder.DropColumn(
                name: "ImprintType",
                table: "CostTempletes");

            migrationBuilder.DropColumn(
                name: "RoyaltyTemplateName",
                table: "CostTempletes");

            migrationBuilder.DropColumn(
                name: "SalesType",
                table: "CostTempletes");
        }
    }
}
