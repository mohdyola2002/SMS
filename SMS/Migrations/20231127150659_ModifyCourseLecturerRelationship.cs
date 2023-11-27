using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMS.Migrations
{
    /// <inheritdoc />
    public partial class ModifyCourseLecturerRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateIndex(
                name: "IX_Courses_LecturerId",
                table: "Courses",
                column: "LecturerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Lecturers_LecturerId",
                table: "Courses",
                column: "LecturerId",
                principalTable: "Lecturers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Lecturers_LecturerId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_LecturerId",
                table: "Courses");

            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "Lecturers",
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
    }
}
