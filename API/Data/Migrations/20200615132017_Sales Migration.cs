using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
    public partial class SalesMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CostTempletes",
                columns: table => new
                {
                    CostTempleteId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ImprintId = table.Column<int>(nullable: true),
                    RoyaltyTemplateId = table.Column<int>(nullable: true),
                    SalesTemplateId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CostTempletes", x => x.CostTempleteId);
                });

            migrationBuilder.CreateTable(
                name: "SalesTemplates",
                columns: table => new
                {
                    SalesTemplatesId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SalesTemplateName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesTemplates", x => x.SalesTemplatesId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CostTempletes");

            migrationBuilder.DropTable(
                name: "SalesTemplates");
        }
    }
}
