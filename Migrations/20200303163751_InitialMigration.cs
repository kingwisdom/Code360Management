using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Code360StudentApp.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.CreateTable(
                name: "AcademyPrograms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProgSystemId = table.Column<Guid>(nullable: false),
                    Cost = table.Column<double>(nullable: false),
                    ProgramName = table.Column<int>(nullable: false),
                    Duration = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcademyPrograms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    ContactName = table.Column<string>(nullable: true),
                    ContactEmail = table.Column<string>(nullable: true),
                    ContactPhone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Course_Name = table.Column<int>(nullable: false),
                    Level = table.Column<int>(nullable: false),
                    Cost = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "guarantors",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    StudentId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_guarantors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_guarantors_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(nullable: false),
                    AmouontPaid = table.Column<double>(nullable: false),
                    PaymentMethod = table.Column<int>(nullable: false),
                    PaymentDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payments_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Student_Id = table.Column<int>(nullable: false),
                    Project_Status = table.Column<int>(nullable: false),
                    ProjectUrl = table.Column<string>(nullable: true),
                    studentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Projects_Students_studentId",
                        column: x => x.studentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Batches",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AcademyProgramId = table.Column<int>(nullable: false),
                    Name = table.Column<int>(nullable: false),
                    Supervisor = table.Column<string>(nullable: true),
                    Year = table.Column<int>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Batches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Batches_AcademyPrograms_AcademyProgramId",
                        column: x => x.AcademyProgramId,
                        principalTable: "AcademyPrograms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employments",
                columns: table => new
                {
                    CompanyId = table.Column<int>(nullable: false),
                    StudentId = table.Column<int>(nullable: false),
                    Id = table.Column<int>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employments", x => new { x.StudentId, x.CompanyId });
                    table.ForeignKey(
                        name: "FK_Employments_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employments_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProgramCourses",
                columns: table => new
                {
                    AcademyProgramId = table.Column<int>(nullable: false),
                    CourseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgramCourses", x => new { x.AcademyProgramId, x.CourseId });
                    table.ForeignKey(
                        name: "FK_ProgramCourses_AcademyPrograms_AcademyProgramId",
                        column: x => x.AcademyProgramId,
                        principalTable: "AcademyPrograms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProgramCourses_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentsInBatches",
                columns: table => new
                {
                    StudentId = table.Column<int>(nullable: false),
                    BatchId = table.Column<int>(nullable: false),
                    StdStatus = table.Column<int>(nullable: false),
                    StdGrade = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentsInBatches", x => new { x.StudentId, x.BatchId });
                    table.ForeignKey(
                        name: "FK_StudentsInBatches_Batches_BatchId",
                        column: x => x.BatchId,
                        principalTable: "Batches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentsInBatches_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Salaries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmploymentId = table.Column<int>(nullable: false),
                    Role = table.Column<string>(nullable: true),
                    Amount = table.Column<double>(nullable: false),
                    PayDay = table.Column<string>(nullable: true),
                    EmploymentCompanyId = table.Column<int>(nullable: false),
                    EmploymentStudentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salaries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Salaries_Employments_EmploymentStudentId_EmploymentCompanyId",
                        columns: x => new { x.EmploymentStudentId, x.EmploymentCompanyId },
                        principalTable: "Employments",
                        principalColumns: new[] { "StudentId", "CompanyId" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Batches_AcademyProgramId",
                table: "Batches",
                column: "AcademyProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_Employments_CompanyId",
                table: "Employments",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_guarantors_StudentId",
                table: "guarantors",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_StudentId",
                table: "Payments",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgramCourses_CourseId",
                table: "ProgramCourses",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_studentId",
                table: "Projects",
                column: "studentId");

            migrationBuilder.CreateIndex(
                name: "IX_Salaries_EmploymentStudentId_EmploymentCompanyId",
                table: "Salaries",
                columns: new[] { "EmploymentStudentId", "EmploymentCompanyId" });

            migrationBuilder.CreateIndex(
                name: "IX_StudentsInBatches_BatchId",
                table: "StudentsInBatches",
                column: "BatchId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "guarantors");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "ProgramCourses");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Salaries");

            migrationBuilder.DropTable(
                name: "StudentsInBatches");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Employments");

            migrationBuilder.DropTable(
                name: "Batches");

            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "AcademyPrograms");

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Address", "AdmissionType", "DateOfBirth", "Email", "Gender", "HealthCondition", "Identification", "MaritalStatus", "Name", "Nationalty", "NextOFKinName", "NextOfKinAddress", "NextOfKinDocuments", "NextOfKinNumber", "PhoneNumber", "Photo", "Status" },
                values: new object[] { 1, "jdj dvdjkdjdsjknbssdsjdsj", null, null, "tunde@gmail.com", null, null, null, null, "Tunde", 2, null, "jwjsjsjdsajdsajsaj", null, null, null, null, null });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Address", "AdmissionType", "DateOfBirth", "Email", "Gender", "HealthCondition", "Identification", "MaritalStatus", "Name", "Nationalty", "NextOFKinName", "NextOfKinAddress", "NextOfKinDocuments", "NextOfKinNumber", "PhoneNumber", "Photo", "Status" },
                values: new object[] { 2, "jdj dvdjkdjdsjknbssdsjdsj", null, null, "grace@gmail.com", null, null, null, null, "Emmmanuella Grace", 30, null, "jwjsjsjdsajdsajsaj", null, null, null, null, null });
        }
    }
}
