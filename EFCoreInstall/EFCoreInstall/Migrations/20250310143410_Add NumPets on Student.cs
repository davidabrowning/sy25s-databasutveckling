using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreInstall.Migrations
{
    /// <inheritdoc />
    public partial class AddNumPetsonStudent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumPets",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumPets",
                table: "Students");
        }
    }
}
