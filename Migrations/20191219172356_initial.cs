using Microsoft.EntityFrameworkCore.Migrations;

namespace CorporateWebsite.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropColumn(
            //    name: "FirstName",
            //    table: "AspNetUsers");

            //migrationBuilder.DropColumn(
            //    name: "LastName",
            //    table: "AspNetUsers");

            //migrationBuilder.DropColumn(
            //    name: "Patronymic",
            //    table: "AspNetUsers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Patronymic",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
