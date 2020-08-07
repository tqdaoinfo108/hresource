using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace hrapi.Migrations
{
    public partial class UpdateMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "groupStaffs");

            migrationBuilder.DropColumn(
                name: "UserTypeID",
                table: "staffs");

            migrationBuilder.DropColumn(
                name: "CategoryNewsName",
                table: "newsCategories");

            migrationBuilder.DropColumn(
                name: "CompanyID",
                table: "newsCategories");

            migrationBuilder.DropColumn(
                name: "ContentTypeID",
                table: "newsCategories");

            migrationBuilder.DropColumn(
                name: "CategoryNewsID",
                table: "news");

            migrationBuilder.AddColumn<int>(
                name: "CompanysIDCompanyID",
                table: "staffs",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DepartmentsIDDepartmentID",
                table: "staffs",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PositionsIDPositionID",
                table: "staffs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Token",
                table: "staffs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CategoryNewsTitle",
                table: "newsCategories",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CompanyID1",
                table: "newsCategories",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CategoryNewsID1",
                table: "news",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentDepartmentID = table.Column<int>(nullable: true),
                    IsRootDepartment = table.Column<bool>(nullable: false),
                    DepartmentName = table.Column<string>(nullable: true),
                    DepartmentDescription = table.Column<string>(nullable: true),
                    StatusID = table.Column<int>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateUpdated = table.Column<DateTime>(nullable: false),
                    UserCreated = table.Column<string>(nullable: true),
                    UserUpdated = table.Column<string>(nullable: true),
                    CompanyID1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentID);
                    table.ForeignKey(
                        name: "FK_Departments_companys_CompanyID1",
                        column: x => x.CompanyID1,
                        principalTable: "companys",
                        principalColumn: "CompanyID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_staffs_CompanysIDCompanyID",
                table: "staffs",
                column: "CompanysIDCompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_staffs_DepartmentsIDDepartmentID",
                table: "staffs",
                column: "DepartmentsIDDepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_staffs_PositionsIDPositionID",
                table: "staffs",
                column: "PositionsIDPositionID");

            migrationBuilder.CreateIndex(
                name: "IX_newsCategories_CompanyID1",
                table: "newsCategories",
                column: "CompanyID1");

            migrationBuilder.CreateIndex(
                name: "IX_news_CategoryNewsID1",
                table: "news",
                column: "CategoryNewsID1");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_CompanyID1",
                table: "Departments",
                column: "CompanyID1");

            migrationBuilder.AddForeignKey(
                name: "FK_news_newsCategories_CategoryNewsID1",
                table: "news",
                column: "CategoryNewsID1",
                principalTable: "newsCategories",
                principalColumn: "CategoryNewsID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_newsCategories_companys_CompanyID1",
                table: "newsCategories",
                column: "CompanyID1",
                principalTable: "companys",
                principalColumn: "CompanyID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_staffs_companys_CompanysIDCompanyID",
                table: "staffs",
                column: "CompanysIDCompanyID",
                principalTable: "companys",
                principalColumn: "CompanyID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_staffs_Departments_DepartmentsIDDepartmentID",
                table: "staffs",
                column: "DepartmentsIDDepartmentID",
                principalTable: "Departments",
                principalColumn: "DepartmentID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_staffs_positions_PositionsIDPositionID",
                table: "staffs",
                column: "PositionsIDPositionID",
                principalTable: "positions",
                principalColumn: "PositionID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_news_newsCategories_CategoryNewsID1",
                table: "news");

            migrationBuilder.DropForeignKey(
                name: "FK_newsCategories_companys_CompanyID1",
                table: "newsCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_staffs_companys_CompanysIDCompanyID",
                table: "staffs");

            migrationBuilder.DropForeignKey(
                name: "FK_staffs_Departments_DepartmentsIDDepartmentID",
                table: "staffs");

            migrationBuilder.DropForeignKey(
                name: "FK_staffs_positions_PositionsIDPositionID",
                table: "staffs");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_staffs_CompanysIDCompanyID",
                table: "staffs");

            migrationBuilder.DropIndex(
                name: "IX_staffs_DepartmentsIDDepartmentID",
                table: "staffs");

            migrationBuilder.DropIndex(
                name: "IX_staffs_PositionsIDPositionID",
                table: "staffs");

            migrationBuilder.DropIndex(
                name: "IX_newsCategories_CompanyID1",
                table: "newsCategories");

            migrationBuilder.DropIndex(
                name: "IX_news_CategoryNewsID1",
                table: "news");

            migrationBuilder.DropColumn(
                name: "CompanysIDCompanyID",
                table: "staffs");

            migrationBuilder.DropColumn(
                name: "DepartmentsIDDepartmentID",
                table: "staffs");

            migrationBuilder.DropColumn(
                name: "PositionsIDPositionID",
                table: "staffs");

            migrationBuilder.DropColumn(
                name: "Token",
                table: "staffs");

            migrationBuilder.DropColumn(
                name: "CategoryNewsTitle",
                table: "newsCategories");

            migrationBuilder.DropColumn(
                name: "CompanyID1",
                table: "newsCategories");

            migrationBuilder.DropColumn(
                name: "CategoryNewsID1",
                table: "news");

            migrationBuilder.AddColumn<int>(
                name: "UserTypeID",
                table: "staffs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CategoryNewsName",
                table: "newsCategories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CompanyID",
                table: "newsCategories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ContentTypeID",
                table: "newsCategories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CategoryNewsID",
                table: "news",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "groupStaffs",
                columns: table => new
                {
                    GroupStaffID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GroupID = table.Column<int>(type: "int", nullable: false),
                    GroupsGroupID = table.Column<int>(type: "int", nullable: true),
                    StaffID = table.Column<int>(type: "int", nullable: false),
                    StaffsStaffID = table.Column<int>(type: "int", nullable: true),
                    StatusID = table.Column<int>(type: "int", nullable: false),
                    UserCreated = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserUpdated = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_groupStaffs", x => x.GroupStaffID);
                    table.ForeignKey(
                        name: "FK_groupStaffs_groups_GroupsGroupID",
                        column: x => x.GroupsGroupID,
                        principalTable: "groups",
                        principalColumn: "GroupID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_groupStaffs_staffs_StaffsStaffID",
                        column: x => x.StaffsStaffID,
                        principalTable: "staffs",
                        principalColumn: "StaffID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_groupStaffs_GroupsGroupID",
                table: "groupStaffs",
                column: "GroupsGroupID");

            migrationBuilder.CreateIndex(
                name: "IX_groupStaffs_StaffsStaffID",
                table: "groupStaffs",
                column: "StaffsStaffID");
        }
    }
}
