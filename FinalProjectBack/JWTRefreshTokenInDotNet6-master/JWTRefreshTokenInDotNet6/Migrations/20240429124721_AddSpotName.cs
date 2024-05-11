using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JWTRefreshTokenInDotNet6.Migrations
{
    public partial class AddSpotName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SpotName",
                table: "Spots",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SpotName",
                table: "Spots");
        }
    }
}
