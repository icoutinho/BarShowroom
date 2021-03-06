USE [master]
GO
/****** Object:  Database [BarShowroomDb]    Script Date: 08/02/2015 16:48:14 ******/
CREATE DATABASE [BarShowroomDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'aspnet-BarShowroom-20150201130800.mdf', FILENAME = N'C:\_pgms\BarShowroom_\BarShowroom\BarShowroom\App_Data\aspnet-BarShowroom-20150201130800.mdf' , SIZE = 3136KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'aspnet-BarShowroom-20150201130800_log.ldf', FILENAME = N'C:\_pgms\BarShowroom_\BarShowroom\BarShowroom\App_Data\aspnet-BarShowroom-20150201130800_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [BarShowroomDb] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BarShowroomDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BarShowroomDb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BarShowroomDb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BarShowroomDb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BarShowroomDb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BarShowroomDb] SET ARITHABORT OFF 
GO
ALTER DATABASE [BarShowroomDb] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [BarShowroomDb] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [BarShowroomDb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BarShowroomDb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BarShowroomDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BarShowroomDb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BarShowroomDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BarShowroomDb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BarShowroomDb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BarShowroomDb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BarShowroomDb] SET  ENABLE_BROKER 
GO
ALTER DATABASE [BarShowroomDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BarShowroomDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BarShowroomDb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BarShowroomDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BarShowroomDb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BarShowroomDb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BarShowroomDb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BarShowroomDb] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BarShowroomDb] SET  MULTI_USER 
GO
ALTER DATABASE [BarShowroomDb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BarShowroomDb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BarShowroomDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BarShowroomDb] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [BarShowroomDb]
GO
/****** Object:  Table [dbo].[Bars]    Script Date: 08/02/2015 16:48:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bars](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](64) NOT NULL,
	[Address] [nvarchar](256) NULL,
	[Cnpj] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_dbo.Bars] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[BeerBars]    Script Date: 08/02/2015 16:48:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BeerBars](
	[Beer_Id] [int] NOT NULL,
	[Bar_Id] [int] NOT NULL,
 CONSTRAINT [PK_dbo.BeerBars] PRIMARY KEY CLUSTERED 
(
	[Beer_Id] ASC,
	[Bar_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Beers]    Script Date: 08/02/2015 16:48:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Beers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](64) NOT NULL,
	[Price] [float] NOT NULL,
	[Brewery_Id] [int] NULL,
 CONSTRAINT [PK_dbo.Beers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Breweries]    Script Date: 08/02/2015 16:48:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Breweries](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](64) NOT NULL,
 CONSTRAINT [PK_dbo.Breweries] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UserProfile]    Script Date: 08/02/2015 16:48:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserProfile](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](56) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[webpages_Membership]    Script Date: 08/02/2015 16:48:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[webpages_Membership](
	[UserId] [int] NOT NULL,
	[CreateDate] [datetime] NULL,
	[ConfirmationToken] [nvarchar](128) NULL,
	[IsConfirmed] [bit] NULL,
	[LastPasswordFailureDate] [datetime] NULL,
	[PasswordFailuresSinceLastSuccess] [int] NOT NULL,
	[Password] [nvarchar](128) NOT NULL,
	[PasswordChangedDate] [datetime] NULL,
	[PasswordSalt] [nvarchar](128) NOT NULL,
	[PasswordVerificationToken] [nvarchar](128) NULL,
	[PasswordVerificationTokenExpirationDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[webpages_OAuthMembership]    Script Date: 08/02/2015 16:48:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[webpages_OAuthMembership](
	[Provider] [nvarchar](30) NOT NULL,
	[ProviderUserId] [nvarchar](100) NOT NULL,
	[UserId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Provider] ASC,
	[ProviderUserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[webpages_Roles]    Script Date: 08/02/2015 16:48:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[webpages_Roles](
	[RoleId] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](256) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[RoleName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[webpages_UsersInRoles]    Script Date: 08/02/2015 16:48:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[webpages_UsersInRoles](
	[UserId] [int] NOT NULL,
	[RoleId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Index [IX_Bar_Id]    Script Date: 08/02/2015 16:48:14 ******/
CREATE NONCLUSTERED INDEX [IX_Bar_Id] ON [dbo].[BeerBars]
(
	[Bar_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Beer_Id]    Script Date: 08/02/2015 16:48:15 ******/
CREATE NONCLUSTERED INDEX [IX_Beer_Id] ON [dbo].[BeerBars]
(
	[Beer_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Brewery_Id]    Script Date: 08/02/2015 16:48:15 ******/
CREATE NONCLUSTERED INDEX [IX_Brewery_Id] ON [dbo].[Beers]
(
	[Brewery_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[webpages_Membership] ADD  DEFAULT ((0)) FOR [IsConfirmed]
GO
ALTER TABLE [dbo].[webpages_Membership] ADD  DEFAULT ((0)) FOR [PasswordFailuresSinceLastSuccess]
GO
ALTER TABLE [dbo].[BeerBars]  WITH CHECK ADD  CONSTRAINT [FK_dbo.BeerBars_dbo.Bars_Bar_Id] FOREIGN KEY([Bar_Id])
REFERENCES [dbo].[Bars] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[BeerBars] CHECK CONSTRAINT [FK_dbo.BeerBars_dbo.Bars_Bar_Id]
GO
ALTER TABLE [dbo].[BeerBars]  WITH CHECK ADD  CONSTRAINT [FK_dbo.BeerBars_dbo.Beers_Beer_Id] FOREIGN KEY([Beer_Id])
REFERENCES [dbo].[Beers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[BeerBars] CHECK CONSTRAINT [FK_dbo.BeerBars_dbo.Beers_Beer_Id]
GO
ALTER TABLE [dbo].[Beers]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Beers_dbo.Breweries_Brewery_Id] FOREIGN KEY([Brewery_Id])
REFERENCES [dbo].[Breweries] ([Id])
GO
ALTER TABLE [dbo].[Beers] CHECK CONSTRAINT [FK_dbo.Beers_dbo.Breweries_Brewery_Id]
GO
ALTER TABLE [dbo].[webpages_UsersInRoles]  WITH CHECK ADD  CONSTRAINT [fk_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[webpages_Roles] ([RoleId])
GO
ALTER TABLE [dbo].[webpages_UsersInRoles] CHECK CONSTRAINT [fk_RoleId]
GO
ALTER TABLE [dbo].[webpages_UsersInRoles]  WITH CHECK ADD  CONSTRAINT [fk_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[UserProfile] ([UserId])
GO
ALTER TABLE [dbo].[webpages_UsersInRoles] CHECK CONSTRAINT [fk_UserId]
GO
USE [master]
GO
ALTER DATABASE [BarShowroomDb] SET  READ_WRITE 
GO
