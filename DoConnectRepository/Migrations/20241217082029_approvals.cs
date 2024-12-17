using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoConnectRepository.Migrations
{
    /// <inheritdoc />
    public partial class approvals : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "approved",
                table: "Questions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "approved",
                table: "Answers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "approved",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "approved",
                table: "Answers");
        }
    }
}
