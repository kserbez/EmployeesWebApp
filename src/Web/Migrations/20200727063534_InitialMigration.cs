using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Surname = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Position",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Position", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeePosition",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(nullable: false),
                    PositionId = table.Column<int>(nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(12, 4)", nullable: false),
                    DateFrom = table.Column<DateTime>(nullable: false),
                    DateTo = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeePosition", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeePosition_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeePosition_Position_PositionId",
                        column: x => x.PositionId,
                        principalTable: "Position",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "Name", "Surname" },
                values: new object[,]
                {
                    { 1, "Иван", "Маслов" },
                    { 2, "Александр", "Прыгунок" },
                    { 3, "Анастасия", "Капустина" }
                });

            migrationBuilder.InsertData(
                table: "Position",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Middle Dev" },
                    { 2, "Junior Dev" },
                    { 3, "Junior QA" },
                    { 4, "Senior BA" }
                });

            migrationBuilder.InsertData(
                table: "EmployeePosition",
                columns: new[] { "Id", "DateFrom", "DateTo", "EmployeeId", "PositionId", "Salary" },
                values: new object[,]
                {
                    { 2, new DateTime(2018, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 1, 1500m },
                    { 1, new DateTime(2016, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, 1500m },
                    { 3, new DateTime(2016, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3, 600m },
                    { 4, new DateTime(2015, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, 4, 1800m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeePosition_EmployeeId",
                table: "EmployeePosition",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeePosition_PositionId",
                table: "EmployeePosition",
                column: "PositionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeePosition");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Position");
        }
    }
}
