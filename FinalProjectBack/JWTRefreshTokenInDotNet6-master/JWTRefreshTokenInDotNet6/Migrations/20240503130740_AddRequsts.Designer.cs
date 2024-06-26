﻿// <auto-generated />
using System;
using JWTRefreshTokenInDotNet6.Entities.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JWTRefreshTokenInDotNet6.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240503130740_AddRequsts")]
    partial class AddRequsts
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("JWTRefreshTokenInDotNet6.Entities.Models.AttendEvent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("eventID")
                        .HasColumnType("int");

                    b.Property<bool>("isPaid")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.HasIndex("eventID");

                    b.ToTable("AttendEvents");
                });

            modelBuilder.Entity("JWTRefreshTokenInDotNet6.Entities.Models.BookHall", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("BookDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CollageName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BookHalls");
                });

            modelBuilder.Entity("JWTRefreshTokenInDotNet6.Entities.Models.ContactUs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subject")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ContactUs");
                });

            modelBuilder.Entity("JWTRefreshTokenInDotNet6.Entities.Models.Event", b =>
                {
                    b.Property<int>("eventID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("eventID"), 1L, 1);

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("descriptionAr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("endEvent")
                        .HasColumnType("datetime2");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nameAr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("numberOfSpeaker")
                        .HasColumnType("int");

                    b.Property<float>("price")
                        .HasColumnType("real");

                    b.Property<DateTime>("startEvent")
                        .HasColumnType("datetime2");

                    b.Property<int>("ticketNo")
                        .HasColumnType("int");

                    b.HasKey("eventID");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("JWTRefreshTokenInDotNet6.Entities.Models.EventRequest", b =>
                {
                    b.Property<int>("requestID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("requestID"), 1L, 1);

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("descriptionAr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("endEvent")
                        .HasColumnType("datetime2");

                    b.Property<bool>("isConfirm")
                        .HasColumnType("bit");

                    b.Property<bool>("mediaCoverage")
                        .HasColumnType("bit");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nameAr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("needLunch")
                        .HasColumnType("bit");

                    b.Property<int>("numberOfCamera")
                        .HasColumnType("int");

                    b.Property<int>("numberOfSpeaker")
                        .HasColumnType("int");

                    b.Property<float>("price")
                        .HasColumnType("real");

                    b.Property<string>("specialRequest")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("startEvent")
                        .HasColumnType("datetime2");

                    b.Property<int>("ticketNo")
                        .HasColumnType("int");

                    b.Property<string>("userID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("requestID");

                    b.HasIndex("userID");

                    b.ToTable("EventRequests");
                });

            modelBuilder.Entity("JWTRefreshTokenInDotNet6.Entities.Models.EventSeats", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("EventID")
                        .HasColumnType("int");

                    b.Property<bool>("IsavailableSeat")
                        .HasColumnType("bit");

                    b.Property<string>("SeatName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EventID");

                    b.ToTable("EventSeats");
                });

            modelBuilder.Entity("JWTRefreshTokenInDotNet6.Entities.Models.EventSpeaker", b =>
                {
                    b.Property<int>("EventSpeakerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EventSpeakerID"), 1L, 1);

                    b.Property<int>("eventID")
                        .HasColumnType("int");

                    b.Property<string>("speakerBio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("speakerImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("speakerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("speaketTalkingEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("speaketTalkingStart")
                        .HasColumnType("datetime2");

                    b.HasKey("EventSpeakerID");

                    b.HasIndex("eventID");

                    b.ToTable("EventSpeakers");
                });

            modelBuilder.Entity("JWTRefreshTokenInDotNet6.Entities.Models.Garage", b =>
                {
                    b.Property<int>("garageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("garageID"), 1L, 1);

                    b.Property<string>("location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("locationLink")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("spotsNo")
                        .HasColumnType("int");

                    b.HasKey("garageID");

                    b.ToTable("Garages");
                });

            modelBuilder.Entity("JWTRefreshTokenInDotNet6.Entities.Models.HospitalCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("HospitalCategories");
                });

            modelBuilder.Entity("JWTRefreshTokenInDotNet6.Entities.Models.HospitalCategoryDoctors", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("HospitalCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("HospitalCategoryId");

                    b.ToTable("HospitalCategoryDoctors");
                });

            modelBuilder.Entity("JWTRefreshTokenInDotNet6.Entities.Models.HospitalRequest", b =>
                {
                    b.Property<int>("HospitalRequestID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HospitalRequestID"), 1L, 1);

                    b.Property<int>("HospitalCategoryDoctorId")
                        .HasColumnType("int");

                    b.Property<int>("HospitalCategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("appointment")
                        .HasColumnType("datetime2");

                    b.Property<int?>("doctorId")
                        .HasColumnType("int");

                    b.Property<string>("medicalImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nationality")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nationalityImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userID")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("HospitalRequestID");

                    b.HasIndex("HospitalCategoryId");

                    b.HasIndex("doctorId");

                    b.HasIndex("userID");

                    b.ToTable("HospitalRequests");
                });

            modelBuilder.Entity("JWTRefreshTokenInDotNet6.Entities.Models.Spot", b =>
                {
                    b.Property<int>("spotID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("spotID"), 1L, 1);

                    b.Property<bool>("IsavailableSpot")
                        .HasColumnType("bit");

                    b.Property<string>("SpotName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("garageID")
                        .HasColumnType("int");

                    b.HasKey("spotID");

                    b.HasIndex("garageID");

                    b.ToTable("Spots");
                });

            modelBuilder.Entity("JWTRefreshTokenInDotNet6.Entities.Models.SpotHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("checkin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("checkout")
                        .HasColumnType("datetime2");

                    b.Property<int>("garageID")
                        .HasColumnType("int");

                    b.Property<int>("spotID")
                        .HasColumnType("int");

                    b.Property<string>("userID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("garageID");

                    b.HasIndex("userID");

                    b.ToTable("SpotHistories");
                });

            modelBuilder.Entity("JWTRefreshTokenInDotNet6.Entities.Models.StudentCertificateRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AddNote")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Cost")
                        .HasColumnType("float");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Document")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NationalIDNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumberOne")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumberTwo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RecipientName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userID")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("userID");

                    b.ToTable("StudentCertificateRequests");
                });

            modelBuilder.Entity("JWTRefreshTokenInDotNet6.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("JWTRefreshTokenInDotNet6.Entities.Models.AttendEvent", b =>
                {
                    b.HasOne("JWTRefreshTokenInDotNet6.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JWTRefreshTokenInDotNet6.Entities.Models.Event", "Event")
                        .WithMany()
                        .HasForeignKey("eventID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Event");

                    b.Navigation("User");
                });

            modelBuilder.Entity("JWTRefreshTokenInDotNet6.Entities.Models.EventRequest", b =>
                {
                    b.HasOne("JWTRefreshTokenInDotNet6.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("userID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("JWTRefreshTokenInDotNet6.Entities.Models.EventSeats", b =>
                {
                    b.HasOne("JWTRefreshTokenInDotNet6.Entities.Models.Event", "Event")
                        .WithMany()
                        .HasForeignKey("EventID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Event");
                });

            modelBuilder.Entity("JWTRefreshTokenInDotNet6.Entities.Models.EventSpeaker", b =>
                {
                    b.HasOne("JWTRefreshTokenInDotNet6.Entities.Models.Event", "Event")
                        .WithMany("EventSpeakers")
                        .HasForeignKey("eventID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Event");
                });

            modelBuilder.Entity("JWTRefreshTokenInDotNet6.Entities.Models.HospitalCategoryDoctors", b =>
                {
                    b.HasOne("JWTRefreshTokenInDotNet6.Entities.Models.HospitalCategory", "HospitalCategory")
                        .WithMany()
                        .HasForeignKey("HospitalCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HospitalCategory");
                });

            modelBuilder.Entity("JWTRefreshTokenInDotNet6.Entities.Models.HospitalRequest", b =>
                {
                    b.HasOne("JWTRefreshTokenInDotNet6.Entities.Models.HospitalCategory", "HospitalCategory")
                        .WithMany()
                        .HasForeignKey("HospitalCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JWTRefreshTokenInDotNet6.Entities.Models.HospitalCategoryDoctors", "doctor")
                        .WithMany()
                        .HasForeignKey("doctorId");

                    b.HasOne("JWTRefreshTokenInDotNet6.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("userID");

                    b.Navigation("HospitalCategory");

                    b.Navigation("User");

                    b.Navigation("doctor");
                });

            modelBuilder.Entity("JWTRefreshTokenInDotNet6.Entities.Models.Spot", b =>
                {
                    b.HasOne("JWTRefreshTokenInDotNet6.Entities.Models.Garage", "Garage")
                        .WithMany("Spots")
                        .HasForeignKey("garageID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Garage");
                });

            modelBuilder.Entity("JWTRefreshTokenInDotNet6.Entities.Models.SpotHistory", b =>
                {
                    b.HasOne("JWTRefreshTokenInDotNet6.Entities.Models.Garage", "Garage")
                        .WithMany()
                        .HasForeignKey("garageID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JWTRefreshTokenInDotNet6.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("userID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Garage");

                    b.Navigation("User");
                });

            modelBuilder.Entity("JWTRefreshTokenInDotNet6.Entities.Models.StudentCertificateRequest", b =>
                {
                    b.HasOne("JWTRefreshTokenInDotNet6.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("userID");

                    b.Navigation("User");
                });

            modelBuilder.Entity("JWTRefreshTokenInDotNet6.Models.ApplicationUser", b =>
                {
                    b.OwnsMany("JWTRefreshTokenInDotNet6.Models.RefreshToken", "RefreshTokens", b1 =>
                        {
                            b1.Property<string>("ApplicationUserId")
                                .HasColumnType("nvarchar(450)");

                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int");

                            SqlServerPropertyBuilderExtensions.UseIdentityColumn(b1.Property<int>("Id"), 1L, 1);

                            b1.Property<DateTime>("CreatedOn")
                                .HasColumnType("datetime2");

                            b1.Property<DateTime>("ExpiresOn")
                                .HasColumnType("datetime2");

                            b1.Property<DateTime?>("RevokedOn")
                                .HasColumnType("datetime2");

                            b1.Property<string>("Token")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("ApplicationUserId", "Id");

                            b1.ToTable("RefreshToken");

                            b1.WithOwner()
                                .HasForeignKey("ApplicationUserId");
                        });

                    b.Navigation("RefreshTokens");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("JWTRefreshTokenInDotNet6.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("JWTRefreshTokenInDotNet6.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JWTRefreshTokenInDotNet6.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("JWTRefreshTokenInDotNet6.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("JWTRefreshTokenInDotNet6.Entities.Models.Event", b =>
                {
                    b.Navigation("EventSpeakers");
                });

            modelBuilder.Entity("JWTRefreshTokenInDotNet6.Entities.Models.Garage", b =>
                {
                    b.Navigation("Spots");
                });
#pragma warning restore 612, 618
        }
    }
}
