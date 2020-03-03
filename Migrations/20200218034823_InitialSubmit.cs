using Microsoft.EntityFrameworkCore.Migrations;

namespace Code360StudentApp.Migrations
{
    public partial class InitialSubmit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Gender = table.Column<int>(nullable: true),
                    DateOfBirth = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    Identification = table.Column<string>(nullable: true),
                    Nationalty = table.Column<int>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Photo = table.Column<string>(nullable: true),
                    HealthCondition = table.Column<string>(nullable: true),
                    MaritalStatus = table.Column<int>(nullable: true),
                    Status = table.Column<int>(nullable: true),
                    AdmissionType = table.Column<int>(nullable: true),
                    NextOFKinName = table.Column<string>(maxLength: 50, nullable: false),
                    NextOfKinNumber = table.Column<string>(nullable: false),
                    NextOfKinAddress = table.Column<string>(nullable: true),
                    NextOfKinDocuments = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
