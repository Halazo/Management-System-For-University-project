USE [master]
GO
/****** Object:  Database [db_aa85e7_finalproject]    Script Date: 24/05/2024 7:15:24 PM ******/
CREATE DATABASE [db_aa85e7_finalproject]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'db_aa85e7_finalproject_Data', FILENAME = N'H:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\db_aa85e7_finalproject_DATA.mdf' , SIZE = 8192KB , MAXSIZE = 1024000KB , FILEGROWTH = 10%)
 LOG ON 
( NAME = N'db_aa85e7_finalproject_Log', FILENAME = N'H:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\db_aa85e7_finalproject_Log.LDF' , SIZE = 3072KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [db_aa85e7_finalproject] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [db_aa85e7_finalproject].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [db_aa85e7_finalproject] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [db_aa85e7_finalproject] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [db_aa85e7_finalproject] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [db_aa85e7_finalproject] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [db_aa85e7_finalproject] SET ARITHABORT OFF 
GO
ALTER DATABASE [db_aa85e7_finalproject] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [db_aa85e7_finalproject] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [db_aa85e7_finalproject] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [db_aa85e7_finalproject] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [db_aa85e7_finalproject] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [db_aa85e7_finalproject] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [db_aa85e7_finalproject] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [db_aa85e7_finalproject] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [db_aa85e7_finalproject] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [db_aa85e7_finalproject] SET  ENABLE_BROKER 
GO
ALTER DATABASE [db_aa85e7_finalproject] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [db_aa85e7_finalproject] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [db_aa85e7_finalproject] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [db_aa85e7_finalproject] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [db_aa85e7_finalproject] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [db_aa85e7_finalproject] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [db_aa85e7_finalproject] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [db_aa85e7_finalproject] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [db_aa85e7_finalproject] SET  MULTI_USER 
GO
ALTER DATABASE [db_aa85e7_finalproject] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [db_aa85e7_finalproject] SET DB_CHAINING OFF 
GO
ALTER DATABASE [db_aa85e7_finalproject] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [db_aa85e7_finalproject] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [db_aa85e7_finalproject] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [db_aa85e7_finalproject] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [db_aa85e7_finalproject] SET QUERY_STORE = ON
GO
ALTER DATABASE [db_aa85e7_finalproject] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [db_aa85e7_finalproject]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 24/05/2024 7:15:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 24/05/2024 7:15:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 24/05/2024 7:15:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 24/05/2024 7:15:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 24/05/2024 7:15:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 24/05/2024 7:15:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 24/05/2024 7:15:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
	[address] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 24/05/2024 7:15:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AttendEvents]    Script Date: 24/05/2024 7:15:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AttendEvents](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[isPaid] [bit] NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[eventID] [int] NOT NULL,
 CONSTRAINT [PK_AttendEvents] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BookHalls]    Script Date: 24/05/2024 7:15:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookHalls](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CollageName] [nvarchar](max) NOT NULL,
	[Subject] [nvarchar](max) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[BookDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_BookHalls] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ContactUs]    Script Date: 24/05/2024 7:15:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContactUs](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Email] [nvarchar](max) NULL,
	[Phone] [nvarchar](max) NULL,
	[Subject] [nvarchar](max) NULL,
	[Content] [nvarchar](max) NULL,
 CONSTRAINT [PK_ContactUs] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EventRequests]    Script Date: 24/05/2024 7:15:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EventRequests](
	[requestID] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](max) NOT NULL,
	[nameAr] [nvarchar](max) NOT NULL,
	[description] [nvarchar](max) NOT NULL,
	[descriptionAr] [nvarchar](max) NOT NULL,
	[price] [real] NOT NULL,
	[endEvent] [datetime2](7) NOT NULL,
	[startEvent] [datetime2](7) NOT NULL,
	[numberOfSpeaker] [int] NOT NULL,
	[ticketNo] [int] NOT NULL,
	[email] [nvarchar](max) NOT NULL,
	[specialRequest] [nvarchar](max) NOT NULL,
	[mediaCoverage] [bit] NOT NULL,
	[numberOfCamera] [int] NOT NULL,
	[needLunch] [bit] NOT NULL,
	[isConfirm] [bit] NOT NULL,
	[userID] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_EventRequests] PRIMARY KEY CLUSTERED 
(
	[requestID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Events]    Script Date: 24/05/2024 7:15:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Events](
	[eventID] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](max) NOT NULL,
	[nameAr] [nvarchar](max) NOT NULL,
	[description] [nvarchar](max) NOT NULL,
	[descriptionAr] [nvarchar](max) NOT NULL,
	[price] [real] NOT NULL,
	[endEvent] [datetime2](7) NOT NULL,
	[startEvent] [datetime2](7) NOT NULL,
	[numberOfSpeaker] [int] NOT NULL,
	[ticketNo] [int] NOT NULL,
	[email] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Events] PRIMARY KEY CLUSTERED 
(
	[eventID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EventSeats]    Script Date: 24/05/2024 7:15:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EventSeats](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IsavailableSeat] [bit] NOT NULL,
	[SeatName] [nvarchar](max) NULL,
	[EventID] [int] NOT NULL,
 CONSTRAINT [PK_EventSeats] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EventSpeakers]    Script Date: 24/05/2024 7:15:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EventSpeakers](
	[EventSpeakerID] [int] IDENTITY(1,1) NOT NULL,
	[speaketTalkingStart] [datetime2](7) NOT NULL,
	[speaketTalkingEnd] [datetime2](7) NOT NULL,
	[speakerImage] [nvarchar](max) NOT NULL,
	[speakerBio] [nvarchar](max) NOT NULL,
	[speakerName] [nvarchar](max) NOT NULL,
	[eventID] [int] NOT NULL,
 CONSTRAINT [PK_EventSpeakers] PRIMARY KEY CLUSTERED 
(
	[EventSpeakerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Garages]    Script Date: 24/05/2024 7:15:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Garages](
	[garageID] [int] IDENTITY(1,1) NOT NULL,
	[spotsNo] [int] NOT NULL,
	[locationLink] [nvarchar](max) NOT NULL,
	[location] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Garages] PRIMARY KEY CLUSTERED 
(
	[garageID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HospitalCategories]    Script Date: 24/05/2024 7:15:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HospitalCategories](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_HospitalCategories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HospitalCategoryDoctors]    Script Date: 24/05/2024 7:15:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HospitalCategoryDoctors](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[HospitalCategoryId] [int] NOT NULL,
 CONSTRAINT [PK_HospitalCategoryDoctors] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HospitalRequests]    Script Date: 24/05/2024 7:15:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HospitalRequests](
	[HospitalRequestID] [int] IDENTITY(1,1) NOT NULL,
	[medicalImage] [nvarchar](max) NULL,
	[nationalityImage] [nvarchar](max) NULL,
	[nationality] [nvarchar](max) NULL,
	[appointment] [datetime2](7) NOT NULL,
	[userID] [nvarchar](450) NULL,
	[HospitalCategoryDoctorId] [int] NOT NULL,
	[HospitalCategoryId] [int] NOT NULL,
	[doctorId] [int] NULL,
 CONSTRAINT [PK_HospitalRequests] PRIMARY KEY CLUSTERED 
(
	[HospitalRequestID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RefreshToken]    Script Date: 24/05/2024 7:15:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RefreshToken](
	[ApplicationUserId] [nvarchar](450) NOT NULL,
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Token] [nvarchar](max) NOT NULL,
	[ExpiresOn] [datetime2](7) NOT NULL,
	[CreatedOn] [datetime2](7) NOT NULL,
	[RevokedOn] [datetime2](7) NULL,
 CONSTRAINT [PK_RefreshToken] PRIMARY KEY CLUSTERED 
(
	[ApplicationUserId] ASC,
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SpotHistories]    Script Date: 24/05/2024 7:15:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SpotHistories](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[spotID] [int] NOT NULL,
	[checkin] [datetime2](7) NOT NULL,
	[checkout] [datetime2](7) NULL,
	[garageID] [int] NOT NULL,
	[userID] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_SpotHistories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Spots]    Script Date: 24/05/2024 7:15:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Spots](
	[spotID] [int] IDENTITY(1,1) NOT NULL,
	[IsavailableSpot] [bit] NOT NULL,
	[garageID] [int] NOT NULL,
	[SpotName] [nvarchar](max) NULL,
 CONSTRAINT [PK_Spots] PRIMARY KEY CLUSTERED 
(
	[spotID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StudentCertificateRequests]    Script Date: 24/05/2024 7:15:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentCertificateRequests](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Document] [nvarchar](max) NOT NULL,
	[userID] [nvarchar](450) NULL,
	[AddNote] [nvarchar](max) NULL,
	[Cost] [float] NOT NULL,
	[CreatedDate] [datetime2](7) NULL,
	[NationalIDNumber] [nvarchar](max) NULL,
	[PhoneNumberOne] [nvarchar](max) NULL,
	[PhoneNumberTwo] [nvarchar](max) NULL,
	[RecipientName] [nvarchar](max) NULL,
 CONSTRAINT [PK_StudentCertificateRequests] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220208012433_InitialCreate', N'6.0.1')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220208012541_AddUserRole', N'6.0.1')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220209010050_AddRefreshTokensTable', N'6.0.1')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240304164622_Address', N'6.0.1')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240304180954_Models', N'6.0.1')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240429124721_AddSpotName', N'6.0.1')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240429161939_AddHospitalCol', N'6.0.1')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240429162217_AddHospitalCol1', N'6.0.1')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240503130740_AddRequsts', N'6.0.1')
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'072ddc69-5183-4087-9654-63685a06c232', N'Staff', N'STAFF', N'4768cce9-0db4-4c5c-9b74-cc41cfd82b0b')
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'29c99dbb-444d-4913-9a59-3adad01e4f94', N'Doctor', N'DOCTOR', N'19d8b799-b3e4-47e4-8df4-3f2d4dccfa98')
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'4b4c3487-5747-4272-bf0c-562bd283a249', N'User', N'USER', N'e6fb6f21-da3d-42a2-b95e-322b94bc2241')
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'aaba84db-6c8c-4eb9-b4b6-049b81c4ae30', N'Student', N'STUDENT', N'27f532c7-32e8-469f-9a88-6e801f444a82')
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'bd2023f9-8a50-45e8-a5fa-d55c7d243946', N'Admin', N'ADMIN', N'80b2546c-4997-452d-a5b8-48730f2ce6dc')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'5c0c0861-ddcb-442b-bf28-4a778f1ec449', N'4b4c3487-5747-4272-bf0c-562bd283a249')
GO
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [address]) VALUES (N'5c0c0861-ddcb-442b-bf28-4a778f1ec449', N'Hala', N'Anas', N'98088', N'98088', N'98088@must.edu.eg', N'98088@MUST.EDU.EG', 0, N'AQAAAAEAACcQAAAAEHZ+KS9Y1y+n1LhgwWo8/V14Z5bTCNEvVW6r4EZ+84XaBUy2ZVRTuf18GKRH8i8p+w==', N'FNPZUEZTUUQQIHYEWHSDPKYAJRYTOQFA', N'a309bc2e-5d2c-4804-aa28-3d9c42a1dbae', NULL, 0, 0, NULL, 1, 0, N'Egypt')
GO
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [address]) VALUES (N'string', N'string', N'string', N'string', N'string', N'string', N'string', 1, N'string', N'string', N'string', N'string', 1, 1, CAST(N'2024-05-07T15:43:52.2630000+00:00' AS DateTimeOffset), 1, 0, N'string')
GO
SET IDENTITY_INSERT [dbo].[HospitalCategories] ON 
GO
INSERT [dbo].[HospitalCategories] ([Id], [Name]) VALUES (1, N'string')
GO
INSERT [dbo].[HospitalCategories] ([Id], [Name]) VALUES (2, N'string')
GO
INSERT [dbo].[HospitalCategories] ([Id], [Name]) VALUES (3, N'string')
GO
SET IDENTITY_INSERT [dbo].[HospitalCategories] OFF
GO
SET IDENTITY_INSERT [dbo].[HospitalCategoryDoctors] ON 
GO
INSERT [dbo].[HospitalCategoryDoctors] ([Id], [Name], [HospitalCategoryId]) VALUES (1, N'string', 2)
GO
SET IDENTITY_INSERT [dbo].[HospitalCategoryDoctors] OFF
GO
SET IDENTITY_INSERT [dbo].[HospitalRequests] ON 
GO
INSERT [dbo].[HospitalRequests] ([HospitalRequestID], [medicalImage], [nationalityImage], [nationality], [appointment], [userID], [HospitalCategoryDoctorId], [HospitalCategoryId], [doctorId]) VALUES (1, N'string', N'string', N'string', CAST(N'2024-05-07T15:43:52.2630000' AS DateTime2), N'string', 0, 1, 1)
GO
SET IDENTITY_INSERT [dbo].[HospitalRequests] OFF
GO
SET IDENTITY_INSERT [dbo].[RefreshToken] ON 
GO
INSERT [dbo].[RefreshToken] ([ApplicationUserId], [Id], [Token], [ExpiresOn], [CreatedOn], [RevokedOn]) VALUES (N'5c0c0861-ddcb-442b-bf28-4a778f1ec449', 2, N'rxvbn03vt71XPXebsyCRj3Eo50W00HmDJwIYufcZSiE=', CAST(N'2024-05-17T16:20:17.4087269' AS DateTime2), CAST(N'2024-05-07T16:20:17.4087575' AS DateTime2), NULL)
GO
INSERT [dbo].[RefreshToken] ([ApplicationUserId], [Id], [Token], [ExpiresOn], [CreatedOn], [RevokedOn]) VALUES (N'string', 1, N'string', CAST(N'2024-05-07T15:43:52.2630000' AS DateTime2), CAST(N'2024-05-07T15:43:52.2630000' AS DateTime2), CAST(N'2024-05-07T15:43:52.2630000' AS DateTime2))
GO
SET IDENTITY_INSERT [dbo].[RefreshToken] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetRoleClaims_RoleId]    Script Date: 24/05/2024 7:16:01 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetRoleClaims_RoleId] ON [dbo].[AspNetRoleClaims]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [RoleNameIndex]    Script Date: 24/05/2024 7:16:01 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[NormalizedName] ASC
)
WHERE ([NormalizedName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserClaims_UserId]    Script Date: 24/05/2024 7:16:01 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserClaims_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserLogins_UserId]    Script Date: 24/05/2024 7:16:01 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserLogins_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserRoles_RoleId]    Script Date: 24/05/2024 7:16:01 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserRoles_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [EmailIndex]    Script Date: 24/05/2024 7:16:01 PM ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UserNameIndex]    Script Date: 24/05/2024 7:16:01 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedUserName] ASC
)
WHERE ([NormalizedUserName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_AttendEvents_eventID]    Script Date: 24/05/2024 7:16:01 PM ******/
CREATE NONCLUSTERED INDEX [IX_AttendEvents_eventID] ON [dbo].[AttendEvents]
(
	[eventID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AttendEvents_UserId]    Script Date: 24/05/2024 7:16:01 PM ******/
CREATE NONCLUSTERED INDEX [IX_AttendEvents_UserId] ON [dbo].[AttendEvents]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_EventRequests_userID]    Script Date: 24/05/2024 7:16:01 PM ******/
CREATE NONCLUSTERED INDEX [IX_EventRequests_userID] ON [dbo].[EventRequests]
(
	[userID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_EventSeats_EventID]    Script Date: 24/05/2024 7:16:01 PM ******/
CREATE NONCLUSTERED INDEX [IX_EventSeats_EventID] ON [dbo].[EventSeats]
(
	[EventID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_EventSpeakers_eventID]    Script Date: 24/05/2024 7:16:01 PM ******/
CREATE NONCLUSTERED INDEX [IX_EventSpeakers_eventID] ON [dbo].[EventSpeakers]
(
	[eventID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_HospitalCategoryDoctors_HospitalCategoryId]    Script Date: 24/05/2024 7:16:01 PM ******/
CREATE NONCLUSTERED INDEX [IX_HospitalCategoryDoctors_HospitalCategoryId] ON [dbo].[HospitalCategoryDoctors]
(
	[HospitalCategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_HospitalRequests_doctorId]    Script Date: 24/05/2024 7:16:01 PM ******/
CREATE NONCLUSTERED INDEX [IX_HospitalRequests_doctorId] ON [dbo].[HospitalRequests]
(
	[doctorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_HospitalRequests_HospitalCategoryId]    Script Date: 24/05/2024 7:16:01 PM ******/
CREATE NONCLUSTERED INDEX [IX_HospitalRequests_HospitalCategoryId] ON [dbo].[HospitalRequests]
(
	[HospitalCategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_HospitalRequests_userID]    Script Date: 24/05/2024 7:16:01 PM ******/
CREATE NONCLUSTERED INDEX [IX_HospitalRequests_userID] ON [dbo].[HospitalRequests]
(
	[userID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_SpotHistories_garageID]    Script Date: 24/05/2024 7:16:01 PM ******/
CREATE NONCLUSTERED INDEX [IX_SpotHistories_garageID] ON [dbo].[SpotHistories]
(
	[garageID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_SpotHistories_userID]    Script Date: 24/05/2024 7:16:01 PM ******/
CREATE NONCLUSTERED INDEX [IX_SpotHistories_userID] ON [dbo].[SpotHistories]
(
	[userID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Spots_garageID]    Script Date: 24/05/2024 7:16:01 PM ******/
CREATE NONCLUSTERED INDEX [IX_Spots_garageID] ON [dbo].[Spots]
(
	[garageID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_StudentCertificateRequests_userID]    Script Date: 24/05/2024 7:16:01 PM ******/
CREATE NONCLUSTERED INDEX [IX_StudentCertificateRequests_userID] ON [dbo].[StudentCertificateRequests]
(
	[userID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AspNetUsers] ADD  DEFAULT (N'') FOR [address]
GO
ALTER TABLE [dbo].[HospitalRequests] ADD  DEFAULT ((0)) FOR [HospitalCategoryDoctorId]
GO
ALTER TABLE [dbo].[HospitalRequests] ADD  DEFAULT ((0)) FOR [HospitalCategoryId]
GO
ALTER TABLE [dbo].[StudentCertificateRequests] ADD  DEFAULT ((0.0000000000000000e+000)) FOR [Cost]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AttendEvents]  WITH CHECK ADD  CONSTRAINT [FK_AttendEvents_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AttendEvents] CHECK CONSTRAINT [FK_AttendEvents_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AttendEvents]  WITH CHECK ADD  CONSTRAINT [FK_AttendEvents_Events_eventID] FOREIGN KEY([eventID])
REFERENCES [dbo].[Events] ([eventID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AttendEvents] CHECK CONSTRAINT [FK_AttendEvents_Events_eventID]
GO
ALTER TABLE [dbo].[EventRequests]  WITH CHECK ADD  CONSTRAINT [FK_EventRequests_AspNetUsers_userID] FOREIGN KEY([userID])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[EventRequests] CHECK CONSTRAINT [FK_EventRequests_AspNetUsers_userID]
GO
ALTER TABLE [dbo].[EventSeats]  WITH CHECK ADD  CONSTRAINT [FK_EventSeats_Events_EventID] FOREIGN KEY([EventID])
REFERENCES [dbo].[Events] ([eventID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[EventSeats] CHECK CONSTRAINT [FK_EventSeats_Events_EventID]
GO
ALTER TABLE [dbo].[EventSpeakers]  WITH CHECK ADD  CONSTRAINT [FK_EventSpeakers_Events_eventID] FOREIGN KEY([eventID])
REFERENCES [dbo].[Events] ([eventID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[EventSpeakers] CHECK CONSTRAINT [FK_EventSpeakers_Events_eventID]
GO
ALTER TABLE [dbo].[HospitalCategoryDoctors]  WITH CHECK ADD  CONSTRAINT [FK_HospitalCategoryDoctors_HospitalCategories_HospitalCategoryId] FOREIGN KEY([HospitalCategoryId])
REFERENCES [dbo].[HospitalCategories] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HospitalCategoryDoctors] CHECK CONSTRAINT [FK_HospitalCategoryDoctors_HospitalCategories_HospitalCategoryId]
GO
ALTER TABLE [dbo].[HospitalRequests]  WITH CHECK ADD  CONSTRAINT [FK_HospitalRequests_AspNetUsers_userID] FOREIGN KEY([userID])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[HospitalRequests] CHECK CONSTRAINT [FK_HospitalRequests_AspNetUsers_userID]
GO
ALTER TABLE [dbo].[HospitalRequests]  WITH CHECK ADD  CONSTRAINT [FK_HospitalRequests_HospitalCategories_HospitalCategoryId] FOREIGN KEY([HospitalCategoryId])
REFERENCES [dbo].[HospitalCategories] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HospitalRequests] CHECK CONSTRAINT [FK_HospitalRequests_HospitalCategories_HospitalCategoryId]
GO
ALTER TABLE [dbo].[HospitalRequests]  WITH CHECK ADD  CONSTRAINT [FK_HospitalRequests_HospitalCategoryDoctors_doctorId] FOREIGN KEY([doctorId])
REFERENCES [dbo].[HospitalCategoryDoctors] ([Id])
GO
ALTER TABLE [dbo].[HospitalRequests] CHECK CONSTRAINT [FK_HospitalRequests_HospitalCategoryDoctors_doctorId]
GO
ALTER TABLE [dbo].[RefreshToken]  WITH CHECK ADD  CONSTRAINT [FK_RefreshToken_AspNetUsers_ApplicationUserId] FOREIGN KEY([ApplicationUserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[RefreshToken] CHECK CONSTRAINT [FK_RefreshToken_AspNetUsers_ApplicationUserId]
GO
ALTER TABLE [dbo].[SpotHistories]  WITH CHECK ADD  CONSTRAINT [FK_SpotHistories_AspNetUsers_userID] FOREIGN KEY([userID])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SpotHistories] CHECK CONSTRAINT [FK_SpotHistories_AspNetUsers_userID]
GO
ALTER TABLE [dbo].[SpotHistories]  WITH CHECK ADD  CONSTRAINT [FK_SpotHistories_Garages_garageID] FOREIGN KEY([garageID])
REFERENCES [dbo].[Garages] ([garageID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SpotHistories] CHECK CONSTRAINT [FK_SpotHistories_Garages_garageID]
GO
ALTER TABLE [dbo].[Spots]  WITH CHECK ADD  CONSTRAINT [FK_Spots_Garages_garageID] FOREIGN KEY([garageID])
REFERENCES [dbo].[Garages] ([garageID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Spots] CHECK CONSTRAINT [FK_Spots_Garages_garageID]
GO
ALTER TABLE [dbo].[StudentCertificateRequests]  WITH CHECK ADD  CONSTRAINT [FK_StudentCertificateRequests_AspNetUsers_userID] FOREIGN KEY([userID])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[StudentCertificateRequests] CHECK CONSTRAINT [FK_StudentCertificateRequests_AspNetUsers_userID]
GO
USE [master]
GO
ALTER DATABASE [db_aa85e7_finalproject] SET  READ_WRITE 
GO
