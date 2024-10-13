using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentMigrations.Migrations
{
    /// <inheritdoc />
    public partial class AddedWeight : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Weight",
                table: "Students",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            //migrationBuilder.CreateTable(
            //    name: "Students",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Age = table.Column<int>(type: "int", nullable: false),
            //        GPA = table.Column<double>(type: "float", nullable: false),
            //        Weight = table.Column<double>(type: "float", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Students", x => x.Id);
            //    });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Weight",
                table: "Students");

            //migrationBuilder.DropTable(
            //    name: "Students");
        }
    }
}
