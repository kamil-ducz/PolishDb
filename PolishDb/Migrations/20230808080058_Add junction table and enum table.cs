using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PolishDb.Migrations
{
    /// <inheritdoc />
    public partial class Addjunctiontableandenumtable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanyPerson_Companies_CompanyId",
                table: "CompanyPerson");

            migrationBuilder.DropForeignKey(
                name: "FK_CompanyPerson_Persons_PersonId",
                table: "CompanyPerson");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CompanyPerson",
                table: "CompanyPerson");

            migrationBuilder.RenameTable(
                name: "CompanyPerson",
                newName: "CompanyPersons");

            migrationBuilder.RenameIndex(
                name: "IX_CompanyPerson_PersonId",
                table: "CompanyPersons",
                newName: "IX_CompanyPersons_PersonId");

            migrationBuilder.AddColumn<int>(
                name: "EmploymentTypeId",
                table: "CompanyPersons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Employments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employments", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompanyPersons_CompanyId",
                table: "CompanyPersons",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyPersons_EmploymentTypeId",
                table: "CompanyPersons",
                column: "EmploymentTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyPersons_Companies_CompanyId",
                table: "CompanyPersons",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyPersons_Employments_EmploymentTypeId",
                table: "CompanyPersons",
                column: "EmploymentTypeId",
                principalTable: "Employments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyPersons_Persons_PersonId",
                table: "CompanyPersons",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanyPersons_Companies_CompanyId",
                table: "CompanyPersons");

            migrationBuilder.DropForeignKey(
                name: "FK_CompanyPersons_Employments_EmploymentTypeId",
                table: "CompanyPersons");

            migrationBuilder.DropForeignKey(
                name: "FK_CompanyPersons_Persons_PersonId",
                table: "CompanyPersons");

            migrationBuilder.DropTable(
                name: "Employments");

            migrationBuilder.DropIndex(
                name: "IX_CompanyPersons_CompanyId",
                table: "CompanyPersons");

            migrationBuilder.DropIndex(
                name: "IX_CompanyPersons_EmploymentTypeId",
                table: "CompanyPersons");

            migrationBuilder.DropColumn(
                name: "EmploymentTypeId",
                table: "CompanyPersons");

            migrationBuilder.RenameTable(
                name: "CompanyPersons",
                newName: "CompanyPerson");

            migrationBuilder.RenameIndex(
                name: "IX_CompanyPersons_PersonId",
                table: "CompanyPerson",
                newName: "IX_CompanyPerson_PersonId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CompanyPerson",
                table: "CompanyPerson",
                columns: new[] { "CompanyId", "PersonId" });

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyPerson_Companies_CompanyId",
                table: "CompanyPerson",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyPerson_Persons_PersonId",
                table: "CompanyPerson",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
