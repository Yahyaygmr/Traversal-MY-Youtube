using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class updated_contact_us_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "ContactUses");

            migrationBuilder.RenameColumn(
                name: "Surname",
                table: "ContactUses",
                newName: "NameSurname");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NameSurname",
                table: "ContactUses",
                newName: "Surname");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "ContactUses",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
