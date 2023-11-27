using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMS.Migrations
{
    /// <inheritdoc />
    public partial class AddCourseLecturerRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "Lecturers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LecturerId",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Lecturers_CourseId",
                table: "Lecturers",
                column: "CourseId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Lecturers_Courses_CourseId",
                table: "Lecturers",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lecturers_Courses_CourseId",
                table: "Lecturers");

            migrationBuilder.DropIndex(
                name: "IX_Lecturers_CourseId",
                table: "Lecturers");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Lecturers");

            migrationBuilder.DropColumn(
                name: "LecturerId",
                table: "Courses");
        }
    }
}
