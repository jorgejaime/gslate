USE master;
GO
IF DB_ID (N'Project') IS NOT NULL
	DROP DATABASE Project;
GO
CREATE DATABASE Project;
GO
USE [Project]
GO
CREATE TABLE [User] (

	Id INT  NOT NULL IDENTITY(1,1),
	FirstName VARCHAR(50) NOT NULL,
	LastName VARCHAR(50) NOT NULL,
	CONSTRAINT PK_User PRIMARY KEY (Id)
)
GO
CREATE TABLE [Project] (

	Id INT  NOT NULL IDENTITY(1,1),
	StartDate DATETIME NOT NULL,
	EndDate DATETIME NOT NULL,
	Credits INT NOT NULL,
	CONSTRAINT PK_Project PRIMARY KEY (Id)
)
GO
CREATE TABLE [UserProject] (

	UserId INT  NOT NULL,
	ProjectId INT  NOT NULL,
	IsActive BIT NOT NULL,
	AssignedDate DATETIME NOT NULL,
	CONSTRAINT PK_UserProject PRIMARY KEY (UserId,ProjectId)
)
GO
ALTER TABLE [dbo].[UserProject]  WITH CHECK ADD  CONSTRAINT [FK_UserProject_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([Id])
GO
ALTER TABLE [dbo].[UserProject]  WITH CHECK ADD  CONSTRAINT [FK_UserProject_Project] FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Project] ([Id])
GO

USE [Project]
GO
SET IDENTITY_INSERT [dbo].[User] ON 
GO
INSERT [dbo].[User] ([Id], [FirstName], [LastName]) VALUES (1, N'Juan', N'Perez')
GO
INSERT [dbo].[User] ([Id], [FirstName], [LastName]) VALUES (2, N'Napoleon', N'Suarez')
GO
INSERT [dbo].[User] ([Id], [FirstName], [LastName]) VALUES (3, N'Carla', N'Saenz')
GO
SET IDENTITY_INSERT [dbo].[User] OFF
GO
SET IDENTITY_INSERT [dbo].[Project] ON 
GO
INSERT [dbo].[Project] ([Id], [StartDate], [EndDate], [Credits]) VALUES (1, CAST(N'2019-01-01T00:00:00.000' AS DateTime), CAST(N'2019-05-23T00:00:00.000' AS DateTime), 1)
GO
INSERT [dbo].[Project] ([Id], [StartDate], [EndDate], [Credits]) VALUES (2, CAST(N'2019-02-01T00:00:00.000' AS DateTime), CAST(N'2019-09-03T00:00:00.000' AS DateTime), 2)
GO
INSERT [dbo].[Project] ([Id], [StartDate], [EndDate], [Credits]) VALUES (3, CAST(N'2019-04-19T00:00:00.000' AS DateTime), CAST(N'2019-12-03T00:00:00.000' AS DateTime), 3)
GO
INSERT [dbo].[Project] ([Id], [StartDate], [EndDate], [Credits]) VALUES (4, CAST(N'2019-02-01T00:00:00.000' AS DateTime), CAST(N'2019-09-03T00:00:00.000' AS DateTime), 4)
GO
INSERT [dbo].[Project] ([Id], [StartDate], [EndDate], [Credits]) VALUES (5, CAST(N'2019-02-01T00:00:00.000' AS DateTime), CAST(N'2019-09-03T00:00:00.000' AS DateTime), 5)
GO
INSERT [dbo].[Project] ([Id], [StartDate], [EndDate], [Credits]) VALUES (6, CAST(N'2019-01-01T00:00:00.000' AS DateTime), CAST(N'2019-05-23T00:00:00.000' AS DateTime), 11)
GO
INSERT [dbo].[Project] ([Id], [StartDate], [EndDate], [Credits]) VALUES (7, CAST(N'2019-02-01T00:00:00.000' AS DateTime), CAST(N'2019-09-03T00:00:00.000' AS DateTime), 22)
GO
INSERT [dbo].[Project] ([Id], [StartDate], [EndDate], [Credits]) VALUES (8, CAST(N'2019-04-19T00:00:00.000' AS DateTime), CAST(N'2019-12-03T00:00:00.000' AS DateTime), 33)
GO
INSERT [dbo].[Project] ([Id], [StartDate], [EndDate], [Credits]) VALUES (9, CAST(N'2019-02-01T00:00:00.000' AS DateTime), CAST(N'2019-09-03T00:00:00.000' AS DateTime), 44)
GO
INSERT [dbo].[Project] ([Id], [StartDate], [EndDate], [Credits]) VALUES (10, CAST(N'2019-02-01T00:00:00.000' AS DateTime), CAST(N'2019-09-03T00:00:00.000' AS DateTime), 55)
GO
INSERT [dbo].[Project] ([Id], [StartDate], [EndDate], [Credits]) VALUES (11, CAST(N'2019-01-01T00:00:00.000' AS DateTime), CAST(N'2019-05-23T00:00:00.000' AS DateTime), 100)
GO
INSERT [dbo].[Project] ([Id], [StartDate], [EndDate], [Credits]) VALUES (12, CAST(N'2019-02-01T00:00:00.000' AS DateTime), CAST(N'2019-09-03T00:00:00.000' AS DateTime), 200)
GO
INSERT [dbo].[Project] ([Id], [StartDate], [EndDate], [Credits]) VALUES (13, CAST(N'2019-04-19T00:00:00.000' AS DateTime), CAST(N'2019-12-03T00:00:00.000' AS DateTime), 300)
GO
INSERT [dbo].[Project] ([Id], [StartDate], [EndDate], [Credits]) VALUES (14, CAST(N'2019-02-01T00:00:00.000' AS DateTime), CAST(N'2019-09-03T00:00:00.000' AS DateTime), 400)
GO
INSERT [dbo].[Project] ([Id], [StartDate], [EndDate], [Credits]) VALUES (15, CAST(N'2019-02-01T00:00:00.000' AS DateTime), CAST(N'2019-09-03T00:00:00.000' AS DateTime), 500)
GO
SET IDENTITY_INSERT [dbo].[Project] OFF
GO
INSERT [dbo].[UserProject] ([UserId], [ProjectId], [IsActive], [AssignedDate]) VALUES (1, 1, 1, CAST(N'2019-01-02T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[UserProject] ([UserId], [ProjectId], [IsActive], [AssignedDate]) VALUES (1, 2, 1, CAST(N'2018-12-03T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[UserProject] ([UserId], [ProjectId], [IsActive], [AssignedDate]) VALUES (1, 3, 0, CAST(N'2019-02-03T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[UserProject] ([UserId], [ProjectId], [IsActive], [AssignedDate]) VALUES (1, 4, 0, CAST(N'2019-02-03T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[UserProject] ([UserId], [ProjectId], [IsActive], [AssignedDate]) VALUES (1, 5, 1, CAST(N'2019-02-03T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[UserProject] ([UserId], [ProjectId], [IsActive], [AssignedDate]) VALUES (2, 6, 1, CAST(N'2019-05-03T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[UserProject] ([UserId], [ProjectId], [IsActive], [AssignedDate]) VALUES (2, 7, 1, CAST(N'2019-01-25T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[UserProject] ([UserId], [ProjectId], [IsActive], [AssignedDate]) VALUES (2, 8, 1, CAST(N'2019-02-01T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[UserProject] ([UserId], [ProjectId], [IsActive], [AssignedDate]) VALUES (2, 9, 0, CAST(N'2019-09-01T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[UserProject] ([UserId], [ProjectId], [IsActive], [AssignedDate]) VALUES (2, 10, 1, CAST(N'2019-09-01T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[UserProject] ([UserId], [ProjectId], [IsActive], [AssignedDate]) VALUES (3, 11, 0, CAST(N'2019-02-03T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[UserProject] ([UserId], [ProjectId], [IsActive], [AssignedDate]) VALUES (3, 12, 1, CAST(N'2019-03-02T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[UserProject] ([UserId], [ProjectId], [IsActive], [AssignedDate]) VALUES (3, 13, 1, CAST(N'2019-07-09T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[UserProject] ([UserId], [ProjectId], [IsActive], [AssignedDate]) VALUES (3, 14, 0, CAST(N'2019-06-20T00:00:00.000' AS DateTime))
GO
