using Microsoft.EntityFrameworkCore.Migrations;

namespace CorporateWebsite.Migrations
{
    public partial class modules : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContentModules",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContentModules", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ModuleSections",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    ContentModuleId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModuleSections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ModuleSections_ContentModules_ContentModuleId",
                        column: x => x.ContentModuleId,
                        principalTable: "ContentModules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ModuleSections_ContentModuleId",
                table: "ModuleSections",
                column: "ContentModuleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ModuleSections");

            migrationBuilder.DropTable(
                name: "ContentModules");
        }
    }
}
