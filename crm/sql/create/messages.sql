/*
   Friday, June 1, 201817:57:28
   User: SA
   Server: 192.168.1.3
   Database: AdventureWorks2016
   Application: 
*/

/* To prevent any potential data loss issues, you should review this script in detail before running it outside the context of the database designer.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT

BEGIN TRANSACTION
GO
IF NOT EXISTS
   (  SELECT [name] 
      FROM sys.tables
      WHERE [name] = 'Messages' 
   )
CREATE TABLE HumanResources.Messages
	(
	authorid nvarchar(MAX) NOT NULL,
	message nvarchar(MAX) NOT NULL,
	date datetime NOT NULL,
	messageid int IDENTITY(1,1) PRIMARY KEY,
	replyto int NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE HumanResources.Messages SET (LOCK_ESCALATION = TABLE)
GO
COMMIT

BEGIN TRANSACTION
GO
IF NOT EXISTS
   (  SELECT [name] 
      FROM sys.tables
      WHERE [name] = 'CustomerHelp' 
   )
CREATE TABLE Sales.CustomerHelp
	(
	customerid nvarchar(MAX) NOT NULL,
	supportid nvarchar(MAX) NOT NULL,
	message nvarchar(MAX) NOT NULL,
	date datetime NOT NULL,
	messageid int IDENTITY(1,1) PRIMARY KEY,
	replyto int NULL,
	clientwritten char(1)
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE Sales.CustomerHelp SET (LOCK_ESCALATION = TABLE)
GO
COMMIT

BEGIN TRANSACTION
GO
IF NOT EXISTS
   (  SELECT [name] 
      FROM sys.tables
      WHERE [name] = 'CustomerGroups' 
   )
CREATE TABLE Sales.CustomerGroups
	(
	groupid nvarchar(MAX) NOT NULL,
	title nvarchar(MAX) NOT NULL,
	description nvarchar(MAX) NULL,
	viewtitle nvarchar(MAX) NOT NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE Sales.CustomerGroups SET (LOCK_ESCALATION = TABLE)
GO
COMMIT

BEGIN TRANSACTION
GO
IF NOT EXISTS
   (  SELECT [name] 
      FROM sys.tables
      WHERE [name] = 'Tasks' 
   )
CREATE TABLE HumanResources.Tasks
	(
	TaskID int IDENTITY(1,1) PRIMARY KEY,
	TaskName nvarchar(MAX) NOT NULL,
	TaskDescription nvarchar(MAX) NOT NULL,
	TaskStartDate datetime NOT NULL,
	TaskEndDate datetime NOT NULL,
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE HumanResources.Tasks SET (LOCK_ESCALATION = TABLE)
GO
COMMIT

BEGIN TRANSACTION
GO
IF NOT EXISTS
   (  SELECT [name] 
      FROM sys.tables
      WHERE [name] = 'EmployeeTasks' 
   )
CREATE TABLE HumanResources.EmployeeTasks
	(
	TaskID int,
	EmployeeID int,
	Progress int,
	UNIQUE (TaskID,EmployeeID)
	)  
GO
ALTER TABLE HumanResources.EmployeeTasks SET (LOCK_ESCALATION = TABLE)
GO
COMMIT