using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SystemZarzadzaniaProjektami.Data.Migrations
{
    /// <inheritdoc />
    public partial class final_migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "ProjectTask",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "ProjectTask");
        }
    }
}
