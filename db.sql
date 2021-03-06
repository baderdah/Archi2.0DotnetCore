USE [master]
GO
/****** Object:  Database [aspnet-DotNetCoreCsharpProject-71736F34-B5BA-4922-9A86-2E49009D9C96]    Script Date: 5/23/2020 9:46:42 PM ******/
CREATE DATABASE [aspnet-DotNetCoreCsharpProject-71736F34-B5BA-4922-9A86-2E49009D9C96]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'aspnet-DotNetCoreCsharpProject-71736F34-B5BA-4922-9A86-2E49009D9C96', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\aspnet-DotNetCoreCsharpProject-71736F34-B5BA-4922-9A86-2E49009D9C96.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'aspnet-DotNetCoreCsharpProject-71736F34-B5BA-4922-9A86-2E49009D9C96_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\aspnet-DotNetCoreCsharpProject-71736F34-B5BA-4922-9A86-2E49009D9C96_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [aspnet-DotNetCoreCsharpProject-71736F34-B5BA-4922-9A86-2E49009D9C96] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [aspnet-DotNetCoreCsharpProject-71736F34-B5BA-4922-9A86-2E49009D9C96].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [aspnet-DotNetCoreCsharpProject-71736F34-B5BA-4922-9A86-2E49009D9C96] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [aspnet-DotNetCoreCsharpProject-71736F34-B5BA-4922-9A86-2E49009D9C96] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [aspnet-DotNetCoreCsharpProject-71736F34-B5BA-4922-9A86-2E49009D9C96] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [aspnet-DotNetCoreCsharpProject-71736F34-B5BA-4922-9A86-2E49009D9C96] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [aspnet-DotNetCoreCsharpProject-71736F34-B5BA-4922-9A86-2E49009D9C96] SET ARITHABORT OFF 
GO
ALTER DATABASE [aspnet-DotNetCoreCsharpProject-71736F34-B5BA-4922-9A86-2E49009D9C96] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [aspnet-DotNetCoreCsharpProject-71736F34-B5BA-4922-9A86-2E49009D9C96] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [aspnet-DotNetCoreCsharpProject-71736F34-B5BA-4922-9A86-2E49009D9C96] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [aspnet-DotNetCoreCsharpProject-71736F34-B5BA-4922-9A86-2E49009D9C96] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [aspnet-DotNetCoreCsharpProject-71736F34-B5BA-4922-9A86-2E49009D9C96] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [aspnet-DotNetCoreCsharpProject-71736F34-B5BA-4922-9A86-2E49009D9C96] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [aspnet-DotNetCoreCsharpProject-71736F34-B5BA-4922-9A86-2E49009D9C96] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [aspnet-DotNetCoreCsharpProject-71736F34-B5BA-4922-9A86-2E49009D9C96] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [aspnet-DotNetCoreCsharpProject-71736F34-B5BA-4922-9A86-2E49009D9C96] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [aspnet-DotNetCoreCsharpProject-71736F34-B5BA-4922-9A86-2E49009D9C96] SET  ENABLE_BROKER 
GO
ALTER DATABASE [aspnet-DotNetCoreCsharpProject-71736F34-B5BA-4922-9A86-2E49009D9C96] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [aspnet-DotNetCoreCsharpProject-71736F34-B5BA-4922-9A86-2E49009D9C96] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [aspnet-DotNetCoreCsharpProject-71736F34-B5BA-4922-9A86-2E49009D9C96] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [aspnet-DotNetCoreCsharpProject-71736F34-B5BA-4922-9A86-2E49009D9C96] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [aspnet-DotNetCoreCsharpProject-71736F34-B5BA-4922-9A86-2E49009D9C96] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [aspnet-DotNetCoreCsharpProject-71736F34-B5BA-4922-9A86-2E49009D9C96] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [aspnet-DotNetCoreCsharpProject-71736F34-B5BA-4922-9A86-2E49009D9C96] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [aspnet-DotNetCoreCsharpProject-71736F34-B5BA-4922-9A86-2E49009D9C96] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [aspnet-DotNetCoreCsharpProject-71736F34-B5BA-4922-9A86-2E49009D9C96] SET  MULTI_USER 
GO
ALTER DATABASE [aspnet-DotNetCoreCsharpProject-71736F34-B5BA-4922-9A86-2E49009D9C96] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [aspnet-DotNetCoreCsharpProject-71736F34-B5BA-4922-9A86-2E49009D9C96] SET DB_CHAINING OFF 
GO
ALTER DATABASE [aspnet-DotNetCoreCsharpProject-71736F34-B5BA-4922-9A86-2E49009D9C96] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [aspnet-DotNetCoreCsharpProject-71736F34-B5BA-4922-9A86-2E49009D9C96] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [aspnet-DotNetCoreCsharpProject-71736F34-B5BA-4922-9A86-2E49009D9C96] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [aspnet-DotNetCoreCsharpProject-71736F34-B5BA-4922-9A86-2E49009D9C96] SET QUERY_STORE = OFF
GO
USE [aspnet-DotNetCoreCsharpProject-71736F34-B5BA-4922-9A86-2E49009D9C96]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 5/23/2020 9:46:42 PM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 5/23/2020 9:46:42 PM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 5/23/2020 9:46:42 PM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 5/23/2020 9:46:42 PM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 5/23/2020 9:46:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](128) NOT NULL,
	[ProviderKey] [nvarchar](128) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 5/23/2020 9:46:42 PM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 5/23/2020 9:46:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
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
	[FirstName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 5/23/2020 9:46:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](128) NOT NULL,
	[Name] [nvarchar](128) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Filieres]    Script Date: 5/23/2020 9:46:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Filieres](
	[Id_filiere] [int] IDENTITY(1,1) NOT NULL,
	[Nom_filiere] [nvarchar](128) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_filiere] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Groupes]    Script Date: 5/23/2020 9:46:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Groupes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Idprof] [int] NULL,
	[IdSociete] [int] NULL,
	[Note] [float] NULL,
	[Sujet] [nvarchar](50) NOT NULL,
	[DesciptionSujet] [nvarchar](1000) NULL,
	[DesciptionFile] [nvarchar](100) NULL,
	[DateSoutenance] [datetime] NULL,
	[DateDepotRapport1] [datetime] NULL,
	[DateDepotRapport2] [datetime] NULL,
	[DateDepotRapport3] [datetime] NULL,
	[DateDepotRapport4] [datetime] NULL,
	[RapportAvt1] [nvarchar](200) NULL,
	[RapportAvt2] [nvarchar](200) NULL,
	[RapportAvt3] [nvarchar](200) NULL,
	[RapportAvt4] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Levels]    Script Date: 5/23/2020 9:46:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Levels](
	[Id_niveau] [int] IDENTITY(1,1) NOT NULL,
	[Nom_niveau] [nvarchar](128) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_niveau] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PlanningDates]    Script Date: 5/23/2020 9:46:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PlanningDates](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PlanningSoutenanceFile] [nvarchar](100) NULL,
	[DateLimitRapportAvt1] [datetime] NULL,
	[DateLimitRapportAvt2] [datetime] NULL,
	[DateLimitRapportAvt3] [datetime] NULL,
	[DateLimitRapportAvt4] [datetime] NULL,
	[DateLimitRapportFinal] [datetime] NULL,
	[DateOuvertureEnrGrp] [datetime] NULL,
	[DateFinEnrGrp] [datetime] NULL,
	[DateAttributionEnc] [datetime] NULL,
	[DateLimitInsSujet] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Professors]    Script Date: 5/23/2020 9:46:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Professors](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Id_user] [nvarchar](450) NOT NULL,
	[Id_fil] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reports]    Script Date: 5/23/2020 9:46:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reports](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdType] [int] NOT NULL,
	[IdGroup] [int] NOT NULL,
	[DateDepot] [datetime] NOT NULL,
	[PathReport] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Societes]    Script Date: 5/23/2020 9:46:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Societes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nom] [nvarchar](50) NOT NULL,
	[Tele] [nvarchar](1000) NULL,
	[Ville] [nvarchar](50) NOT NULL,
	[NomEncadrant] [nvarchar](50) NULL,
	[MailEncadrant] [nvarchar](50) NULL,
	[TeleEncadrant] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 5/23/2020 9:46:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Id_user] [nvarchar](450) NOT NULL,
	[GroupId] [int] NULL,
	[Cne] [nvarchar](20) NOT NULL,
	[Id_fil] [int] NOT NULL,
	[Id_niv] [int] NOT NULL,
	[Cin] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Type_Reports]    Script Date: 5/23/2020 9:46:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Type_Reports](
	[Id_type] [int] IDENTITY(1,1) NOT NULL,
	[Type] [nvarchar](128) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_type] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetRoleClaims_RoleId]    Script Date: 5/23/2020 9:46:42 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetRoleClaims_RoleId] ON [dbo].[AspNetRoleClaims]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [RoleNameIndex]    Script Date: 5/23/2020 9:46:42 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[NormalizedName] ASC
)
WHERE ([NormalizedName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserClaims_UserId]    Script Date: 5/23/2020 9:46:42 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserClaims_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserLogins_UserId]    Script Date: 5/23/2020 9:46:42 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserLogins_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserRoles_RoleId]    Script Date: 5/23/2020 9:46:42 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserRoles_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [EmailIndex]    Script Date: 5/23/2020 9:46:42 PM ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UserNameIndex]    Script Date: 5/23/2020 9:46:42 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedUserName] ASC
)
WHERE ([NormalizedUserName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
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
ALTER TABLE [dbo].[Groupes]  WITH CHECK ADD FOREIGN KEY([Idprof])
REFERENCES [dbo].[Professors] ([Id])
GO
ALTER TABLE [dbo].[Groupes]  WITH CHECK ADD FOREIGN KEY([IdSociete])
REFERENCES [dbo].[Societes] ([Id])
GO
ALTER TABLE [dbo].[Professors]  WITH CHECK ADD FOREIGN KEY([Id_fil])
REFERENCES [dbo].[Filieres] ([Id_filiere])
GO
ALTER TABLE [dbo].[Professors]  WITH CHECK ADD FOREIGN KEY([Id_user])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[Reports]  WITH CHECK ADD FOREIGN KEY([IdGroup])
REFERENCES [dbo].[Groupes] ([Id])
GO
ALTER TABLE [dbo].[Reports]  WITH CHECK ADD FOREIGN KEY([IdType])
REFERENCES [dbo].[Type_Reports] ([Id_type])
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD FOREIGN KEY([GroupId])
REFERENCES [dbo].[Groupes] ([Id])
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD FOREIGN KEY([Id_fil])
REFERENCES [dbo].[Filieres] ([Id_filiere])
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD FOREIGN KEY([Id_niv])
REFERENCES [dbo].[Levels] ([Id_niveau])
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD FOREIGN KEY([Id_user])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
USE [master]
GO
ALTER DATABASE [aspnet-DotNetCoreCsharpProject-71736F34-B5BA-4922-9A86-2E49009D9C96] SET  READ_WRITE 
GO
