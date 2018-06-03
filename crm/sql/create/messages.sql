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
CREATE TABLE HumanResources.Messages
	(
	authorid nvarchar(MAX) NOT NULL,
	message nvarchar(MAX) NOT NULL,
	date datetime NOT NULL,
	messageid uniqueidentifier NOT NULL,
	replyto binary(50) NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE HumanResources.Messages ADD CONSTRAINT
	PK_crmmessages PRIMARY KEY CLUSTERED 
	(
	messageid
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE HumanResources.Messages ADD CONSTRAINT
	FK_crmmessages_crmmessages FOREIGN KEY
	(
	messageid
	) REFERENCES HumanResources.Messages
	(
	messageid
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE HumanResources.Messages SET (LOCK_ESCALATION = TABLE)
GO
COMMIT

BEGIN TRANSACTION
GO
CREATE TABLE Sales.CustomerHelp
	(
	customerid nvarchar(MAX) NOT NULL,
	supportid nvarchar(MAX) NOT NULL,
	message nvarchar(MAX) NOT NULL,
	date datetime NOT NULL,
	messageid uniqueidentifier NOT NULL,
	replyto binary(50) NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE Sales.CustomerHelp ADD CONSTRAINT
	PK_CustomerHelp PRIMARY KEY CLUSTERED 
	(
	messageid
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE Sales.CustomerHelp ADD CONSTRAINT
	FK_CustomerHelp_CustomerHelp FOREIGN KEY
	(
	messageid
	) REFERENCES Sales.CustomerHelp
	(
	messageid
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE Sales.CustomerHelp SET (LOCK_ESCALATION = TABLE)
GO
COMMIT


BEGIN TRANSACTION
GO
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

