using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminPanelGetWay.DAL.EF.Migrations
{
    public partial class initalإ : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Access_ActionName",
                table: "AccessLevels");

            migrationBuilder.DropColumn(
                name: "Access_ControllName",
                table: "AccessLevels");

            migrationBuilder.AddColumn<string>(
                name: "Access_RoleAccess",
                table: "AccessLevels",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Access_RoleAccess",
                table: "AccessLevels");

            migrationBuilder.AddColumn<string>(
                name: "Access_ActionName",
                table: "AccessLevels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Access_ControllName",
                table: "AccessLevels",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
