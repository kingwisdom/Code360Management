using Microsoft.EntityFrameworkCore.Migrations;

namespace Code360StudentApp.Migrations
{
    public partial class SeedEmployeesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NextOfKinNumber",
                table: "Students",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "NextOFKinName",
                table: "Students",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Address", "AdmissionType", "DateOfBirth", "Email", "Gender", "HealthCondition", "Identification", "MaritalStatus", "Name", "Nationalty", "NextOFKinName", "NextOfKinAddress", "NextOfKinDocuments", "NextOfKinNumber", "PhoneNumber", "Photo", "Status" },
                values: new object[] { 1, "jdj dvdjkdjdsjknbssdsjdsj", null, null, "tunde@gmail.com", null, null, null, null, "Tunde", 2, null, "jwjsjsjdsajdsajsaj", null, null, null, null, null });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Address", "AdmissionType", "DateOfBirth", "Email", "Gender", "HealthCondition", "Identification", "MaritalStatus", "Name", "Nationalty", "NextOFKinName", "NextOfKinAddress", "NextOfKinDocuments", "NextOfKinNumber", "PhoneNumber", "Photo", "Status" },
                values: new object[] { 2, "jdj dvdjkdjdsjknbssdsjdsj", null, null, "grace@gmail.com", null, null, null, null, "Emmmanuella Grace", 30, null, "jwjsjsjdsajdsajsaj", null, null, null, null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<string>(
                name: "NextOfKinNumber",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NextOFKinName",
                table: "Students",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
