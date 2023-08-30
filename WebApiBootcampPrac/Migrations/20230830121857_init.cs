using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiBootcampPrac.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Assessments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Git = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    SQL = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CSharp = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    HtmlCssJs = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Angular = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assessments", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assessments");
        }
    }
}
