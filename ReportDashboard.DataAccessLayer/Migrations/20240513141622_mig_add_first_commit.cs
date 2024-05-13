using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReportDashboard.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_add_first_commit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DbTables",
                columns: table => new
                {
                    DbTableID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DbTable_ServerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DbTable_Database = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DbTable_UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DbTable_Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DbTables", x => x.DbTableID);
                });

            migrationBuilder.CreateTable(
                name: "Reports",
                columns: table => new
                {
                    ReportID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReportName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DbTableID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reports", x => x.ReportID);
                    table.ForeignKey(
                        name: "FK_Reports_DbTables_DbTableID",
                        column: x => x.DbTableID,
                        principalTable: "DbTables",
                        principalColumn: "DbTableID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reports_DbTableID",
                table: "Reports",
                column: "DbTableID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reports");

            migrationBuilder.DropTable(
                name: "DbTables");
        }
    }
}
