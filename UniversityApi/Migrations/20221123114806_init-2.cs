using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniversityApi.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Users_CreateUserId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Users_DeleteUserId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Users_UpdateUserId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Chapters_Users_CreateUserId",
                table: "Chapters");

            migrationBuilder.DropForeignKey(
                name: "FK_Chapters_Users_DeleteUserId",
                table: "Chapters");

            migrationBuilder.DropForeignKey(
                name: "FK_Chapters_Users_UpdateUserId",
                table: "Chapters");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Users_CreateUserId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Users_DeleteUserId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Users_UpdateUserId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Users_CreateUserId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Users_DeleteUserId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Users_UpdateUserId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Users_CreateUserId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Users_DeleteUserId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Users_UpdateUserId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_CreateUserId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_DeleteUserId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_UpdateUserId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Students_CreateUserId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_DeleteUserId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_UpdateUserId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Courses_CreateUserId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_DeleteUserId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_UpdateUserId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Chapters_CreateUserId",
                table: "Chapters");

            migrationBuilder.DropIndex(
                name: "IX_Chapters_DeleteUserId",
                table: "Chapters");

            migrationBuilder.DropIndex(
                name: "IX_Chapters_UpdateUserId",
                table: "Chapters");

            migrationBuilder.DropIndex(
                name: "IX_Categories_CreateUserId",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_DeleteUserId",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_UpdateUserId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "CreateUserId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DeleteUserId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UpdateUserId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CreateUserId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "DeleteUserId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "UpdateUserId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "CreateUserId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "DeleteUserId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "UpdateUserId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CreateUserId",
                table: "Chapters");

            migrationBuilder.DropColumn(
                name: "DeleteUserId",
                table: "Chapters");

            migrationBuilder.DropColumn(
                name: "UpdateUserId",
                table: "Chapters");

            migrationBuilder.DropColumn(
                name: "CreateUserId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "DeleteUserId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "UpdateUserId",
                table: "Categories");

            migrationBuilder.AddColumn<string>(
                name: "CreateBy",
                table: "Users",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "DeleteBy",
                table: "Users",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "UpdateBy",
                table: "Users",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "CreateBy",
                table: "Students",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "DeleteBy",
                table: "Students",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "UpdateBy",
                table: "Students",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "CreateBy",
                table: "Courses",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "DeleteBy",
                table: "Courses",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "UpdateBy",
                table: "Courses",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "CreateBy",
                table: "Chapters",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "DeleteBy",
                table: "Chapters",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "UpdateBy",
                table: "Chapters",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "CreateBy",
                table: "Categories",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "DeleteBy",
                table: "Categories",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "UpdateBy",
                table: "Categories",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DeleteBy",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "DeleteBy",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "DeleteBy",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "Chapters");

            migrationBuilder.DropColumn(
                name: "DeleteBy",
                table: "Chapters");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "Chapters");

            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "DeleteBy",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "Categories");

            migrationBuilder.AddColumn<int>(
                name: "CreateUserId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeleteUserId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdateUserId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreateUserId",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeleteUserId",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdateUserId",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreateUserId",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeleteUserId",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdateUserId",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreateUserId",
                table: "Chapters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeleteUserId",
                table: "Chapters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdateUserId",
                table: "Chapters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreateUserId",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeleteUserId",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdateUserId",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Users_CreateUserId",
                table: "Users",
                column: "CreateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_DeleteUserId",
                table: "Users",
                column: "DeleteUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UpdateUserId",
                table: "Users",
                column: "UpdateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_CreateUserId",
                table: "Students",
                column: "CreateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_DeleteUserId",
                table: "Students",
                column: "DeleteUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_UpdateUserId",
                table: "Students",
                column: "UpdateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CreateUserId",
                table: "Courses",
                column: "CreateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_DeleteUserId",
                table: "Courses",
                column: "DeleteUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_UpdateUserId",
                table: "Courses",
                column: "UpdateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Chapters_CreateUserId",
                table: "Chapters",
                column: "CreateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Chapters_DeleteUserId",
                table: "Chapters",
                column: "DeleteUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Chapters_UpdateUserId",
                table: "Chapters",
                column: "UpdateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_CreateUserId",
                table: "Categories",
                column: "CreateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_DeleteUserId",
                table: "Categories",
                column: "DeleteUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_UpdateUserId",
                table: "Categories",
                column: "UpdateUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Users_CreateUserId",
                table: "Categories",
                column: "CreateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Users_DeleteUserId",
                table: "Categories",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Users_UpdateUserId",
                table: "Categories",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Chapters_Users_CreateUserId",
                table: "Chapters",
                column: "CreateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Chapters_Users_DeleteUserId",
                table: "Chapters",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Chapters_Users_UpdateUserId",
                table: "Chapters",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Users_CreateUserId",
                table: "Courses",
                column: "CreateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Users_DeleteUserId",
                table: "Courses",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Users_UpdateUserId",
                table: "Courses",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Users_CreateUserId",
                table: "Students",
                column: "CreateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Users_DeleteUserId",
                table: "Students",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Users_UpdateUserId",
                table: "Students",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Users_CreateUserId",
                table: "Users",
                column: "CreateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Users_DeleteUserId",
                table: "Users",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Users_UpdateUserId",
                table: "Users",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
