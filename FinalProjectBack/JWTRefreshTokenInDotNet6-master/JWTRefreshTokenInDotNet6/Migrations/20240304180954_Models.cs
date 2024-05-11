using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JWTRefreshTokenInDotNet6.Migrations
{
    public partial class Models : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EventRequests",
                columns: table => new
                {
                    requestID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nameAr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    descriptionAr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    price = table.Column<float>(type: "real", nullable: false),
                    endEvent = table.Column<DateTime>(type: "datetime2", nullable: false),
                    startEvent = table.Column<DateTime>(type: "datetime2", nullable: false),
                    numberOfSpeaker = table.Column<int>(type: "int", nullable: false),
                    ticketNo = table.Column<int>(type: "int", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    specialRequest = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mediaCoverage = table.Column<bool>(type: "bit", nullable: false),
                    numberOfCamera = table.Column<int>(type: "int", nullable: false),
                    needLunch = table.Column<bool>(type: "bit", nullable: false),
                    isConfirm = table.Column<bool>(type: "bit", nullable: false),
                    userID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventRequests", x => x.requestID);
                    table.ForeignKey(
                        name: "FK_EventRequests_AspNetUsers_userID",
                        column: x => x.userID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    eventID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nameAr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    descriptionAr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    price = table.Column<float>(type: "real", nullable: false),
                    endEvent = table.Column<DateTime>(type: "datetime2", nullable: false),
                    startEvent = table.Column<DateTime>(type: "datetime2", nullable: false),
                    numberOfSpeaker = table.Column<int>(type: "int", nullable: false),
                    ticketNo = table.Column<int>(type: "int", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.eventID);
                });

            migrationBuilder.CreateTable(
                name: "Garages",
                columns: table => new
                {
                    garageID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    spotsNo = table.Column<int>(type: "int", nullable: false),
                    locationLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    location = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Garages", x => x.garageID);
                });

            migrationBuilder.CreateTable(
                name: "HospitalRequests",
                columns: table => new
                {
                    HospitalRequestID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    medicalImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nationalityImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nationality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    appointment = table.Column<DateTime>(type: "datetime2", nullable: false),
                    department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    userID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HospitalRequests", x => x.HospitalRequestID);
                    table.ForeignKey(
                        name: "FK_HospitalRequests_AspNetUsers_userID",
                        column: x => x.userID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentCertificateRequests",
                columns: table => new
                {
                    StudentCertificateRequestID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    submitDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    passportNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nationalityNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    birthCertificate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    userID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentCertificateRequests", x => x.StudentCertificateRequestID);
                    table.ForeignKey(
                        name: "FK_StudentCertificateRequests_AspNetUsers_userID",
                        column: x => x.userID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AttendEvents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    isPaid = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    eventID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttendEvents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AttendEvents_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AttendEvents_Events_eventID",
                        column: x => x.eventID,
                        principalTable: "Events",
                        principalColumn: "eventID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EventSpeakers",
                columns: table => new
                {
                    EventSpeakerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    speaketTalkingStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    speaketTalkingEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    speakerImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    speakerBio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    speakerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    eventID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventSpeakers", x => x.EventSpeakerID);
                    table.ForeignKey(
                        name: "FK_EventSpeakers_Events_eventID",
                        column: x => x.eventID,
                        principalTable: "Events",
                        principalColumn: "eventID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SpotHistories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    spotID = table.Column<int>(type: "int", nullable: false),
                    checkin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    checkout = table.Column<DateTime>(type: "datetime2", nullable: true),
                    garageID = table.Column<int>(type: "int", nullable: false),
                    userID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpotHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SpotHistories_AspNetUsers_userID",
                        column: x => x.userID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SpotHistories_Garages_garageID",
                        column: x => x.garageID,
                        principalTable: "Garages",
                        principalColumn: "garageID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Spots",
                columns: table => new
                {
                    spotID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsavailableSpot = table.Column<bool>(type: "bit", nullable: false),
                    garageID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spots", x => x.spotID);
                    table.ForeignKey(
                        name: "FK_Spots_Garages_garageID",
                        column: x => x.garageID,
                        principalTable: "Garages",
                        principalColumn: "garageID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AttendEvents_eventID",
                table: "AttendEvents",
                column: "eventID");

            migrationBuilder.CreateIndex(
                name: "IX_AttendEvents_UserId",
                table: "AttendEvents",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_EventRequests_userID",
                table: "EventRequests",
                column: "userID");

            migrationBuilder.CreateIndex(
                name: "IX_EventSpeakers_eventID",
                table: "EventSpeakers",
                column: "eventID");

            migrationBuilder.CreateIndex(
                name: "IX_HospitalRequests_userID",
                table: "HospitalRequests",
                column: "userID");

            migrationBuilder.CreateIndex(
                name: "IX_SpotHistories_garageID",
                table: "SpotHistories",
                column: "garageID");

            migrationBuilder.CreateIndex(
                name: "IX_SpotHistories_userID",
                table: "SpotHistories",
                column: "userID");

            migrationBuilder.CreateIndex(
                name: "IX_Spots_garageID",
                table: "Spots",
                column: "garageID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCertificateRequests_userID",
                table: "StudentCertificateRequests",
                column: "userID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AttendEvents");

            migrationBuilder.DropTable(
                name: "EventRequests");

            migrationBuilder.DropTable(
                name: "EventSpeakers");

            migrationBuilder.DropTable(
                name: "HospitalRequests");

            migrationBuilder.DropTable(
                name: "SpotHistories");

            migrationBuilder.DropTable(
                name: "Spots");

            migrationBuilder.DropTable(
                name: "StudentCertificateRequests");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Garages");
        }
    }
}
