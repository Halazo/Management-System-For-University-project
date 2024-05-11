using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JWTRefreshTokenInDotNet6.Migrations
{
    public partial class AddRequsts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HospitalRequests_AspNetUsers_userID",
                table: "HospitalRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentCertificateRequests_AspNetUsers_userID",
                table: "StudentCertificateRequests");

            migrationBuilder.DropColumn(
                name: "birthCertificate",
                table: "StudentCertificateRequests");

            migrationBuilder.DropColumn(
                name: "nationalityNo",
                table: "StudentCertificateRequests");

            migrationBuilder.DropColumn(
                name: "submitDate",
                table: "StudentCertificateRequests");

            migrationBuilder.DropColumn(
                name: "department",
                table: "HospitalRequests");

            migrationBuilder.RenameColumn(
                name: "passportNo",
                table: "StudentCertificateRequests",
                newName: "Document");

            migrationBuilder.RenameColumn(
                name: "StudentCertificateRequestID",
                table: "StudentCertificateRequests",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "userID",
                table: "StudentCertificateRequests",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "AddNote",
                table: "StudentCertificateRequests",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Cost",
                table: "StudentCertificateRequests",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "StudentCertificateRequests",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NationalIDNumber",
                table: "StudentCertificateRequests",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumberOne",
                table: "StudentCertificateRequests",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumberTwo",
                table: "StudentCertificateRequests",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RecipientName",
                table: "StudentCertificateRequests",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "userID",
                table: "HospitalRequests",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "nationalityImage",
                table: "HospitalRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "nationality",
                table: "HospitalRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "medicalImage",
                table: "HospitalRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "HospitalCategoryDoctorId",
                table: "HospitalRequests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HospitalCategoryId",
                table: "HospitalRequests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "doctorId",
                table: "HospitalRequests",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "BookHalls",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CollageName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookHalls", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HospitalRequests_doctorId",
                table: "HospitalRequests",
                column: "doctorId");

            migrationBuilder.CreateIndex(
                name: "IX_HospitalRequests_HospitalCategoryId",
                table: "HospitalRequests",
                column: "HospitalCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_HospitalRequests_AspNetUsers_userID",
                table: "HospitalRequests",
                column: "userID",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HospitalRequests_HospitalCategories_HospitalCategoryId",
                table: "HospitalRequests",
                column: "HospitalCategoryId",
                principalTable: "HospitalCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HospitalRequests_HospitalCategoryDoctors_doctorId",
                table: "HospitalRequests",
                column: "doctorId",
                principalTable: "HospitalCategoryDoctors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCertificateRequests_AspNetUsers_userID",
                table: "StudentCertificateRequests",
                column: "userID",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HospitalRequests_AspNetUsers_userID",
                table: "HospitalRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_HospitalRequests_HospitalCategories_HospitalCategoryId",
                table: "HospitalRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_HospitalRequests_HospitalCategoryDoctors_doctorId",
                table: "HospitalRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentCertificateRequests_AspNetUsers_userID",
                table: "StudentCertificateRequests");

            migrationBuilder.DropTable(
                name: "BookHalls");

            migrationBuilder.DropIndex(
                name: "IX_HospitalRequests_doctorId",
                table: "HospitalRequests");

            migrationBuilder.DropIndex(
                name: "IX_HospitalRequests_HospitalCategoryId",
                table: "HospitalRequests");

            migrationBuilder.DropColumn(
                name: "AddNote",
                table: "StudentCertificateRequests");

            migrationBuilder.DropColumn(
                name: "Cost",
                table: "StudentCertificateRequests");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "StudentCertificateRequests");

            migrationBuilder.DropColumn(
                name: "NationalIDNumber",
                table: "StudentCertificateRequests");

            migrationBuilder.DropColumn(
                name: "PhoneNumberOne",
                table: "StudentCertificateRequests");

            migrationBuilder.DropColumn(
                name: "PhoneNumberTwo",
                table: "StudentCertificateRequests");

            migrationBuilder.DropColumn(
                name: "RecipientName",
                table: "StudentCertificateRequests");

            migrationBuilder.DropColumn(
                name: "HospitalCategoryDoctorId",
                table: "HospitalRequests");

            migrationBuilder.DropColumn(
                name: "HospitalCategoryId",
                table: "HospitalRequests");

            migrationBuilder.DropColumn(
                name: "doctorId",
                table: "HospitalRequests");

            migrationBuilder.RenameColumn(
                name: "Document",
                table: "StudentCertificateRequests",
                newName: "passportNo");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "StudentCertificateRequests",
                newName: "StudentCertificateRequestID");

            migrationBuilder.AlterColumn<string>(
                name: "userID",
                table: "StudentCertificateRequests",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "birthCertificate",
                table: "StudentCertificateRequests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "nationalityNo",
                table: "StudentCertificateRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "submitDate",
                table: "StudentCertificateRequests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "userID",
                table: "HospitalRequests",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nationalityImage",
                table: "HospitalRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nationality",
                table: "HospitalRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "medicalImage",
                table: "HospitalRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "department",
                table: "HospitalRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_HospitalRequests_AspNetUsers_userID",
                table: "HospitalRequests",
                column: "userID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCertificateRequests_AspNetUsers_userID",
                table: "StudentCertificateRequests",
                column: "userID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
