using Microsoft.EntityFrameworkCore.Migrations;

namespace CaseStudy3_FoodDonationManagement.Migrations
{
    public partial class m1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "schoolDonarModels",
                columns: table => new
                {
                    StudentDonarId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentDonarName = table.Column<string>(nullable: true),
                    StudentDonarCity = table.Column<string>(nullable: true),
                    StudentDonarAddress = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_schoolDonarModels", x => x.StudentDonarId);
                });

            migrationBuilder.InsertData(
                table: "schoolDonarModels",
                columns: new[] { "StudentDonarId", "StudentDonarAddress", "StudentDonarCity", "StudentDonarName" },
                values: new object[] { 1, "Najafgarh", "Delhi", "hareet" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "schoolDonarModels");
        }
    }
}
