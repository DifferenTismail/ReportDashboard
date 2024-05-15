using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReportDashboard.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mid_add_new_alan : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DBMS_Name",
                table: "DbTables",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DBMS_Name",
                table: "DbTables");
        }
    }
}
