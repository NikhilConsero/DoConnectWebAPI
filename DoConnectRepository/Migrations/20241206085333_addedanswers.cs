using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoConnectRepository.Migrations
{
    /// <inheritdoc />
    public partial class addedanswers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    Aid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    answer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Qid = table.Column<int>(type: "int", nullable: false),
                    questionsQid = table.Column<int>(type: "int", nullable: true),
                    UserID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.Aid);
                    table.ForeignKey(
                        name: "FK_Answers_Questions_questionsQid",
                        column: x => x.questionsQid,
                        principalTable: "Questions",
                        principalColumn: "Qid");
                    table.ForeignKey(
                        name: "FK_Answers_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "id"
                       );
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answers_questionsQid",
                table: "Answers",
                column: "questionsQid");

            migrationBuilder.CreateIndex(
                name: "IX_Answers_UserID",
                table: "Answers",
                column: "UserID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answers");
        }
    }
}
