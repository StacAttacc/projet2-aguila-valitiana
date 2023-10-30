
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 10/30/2023 11:58:16
-- Generated from EDMX file: B:\VeilleTechnologique2023\Project2\projet2-aguila-valitiana\Backend\Project2Backend\Project2DatabaseStuff\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [InformationStorage];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[UpdateEntries]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UpdateEntries];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'UpdateEntries'
CREATE TABLE [dbo].[UpdateEntries] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(max)  NOT NULL,
    [Date] datetime  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Data] varbinary(max)  NULL
);
GO

-- Creating table 'TextUpdates'
CREATE TABLE [dbo].[TextUpdates] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(max)  NOT NULL,
    [Date] datetime  NOT NULL,
    [Description] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'BinaryUpdates'
CREATE TABLE [dbo].[BinaryUpdates] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(max)  NOT NULL,
    [Date] datetime  NOT NULL,
    [File] varbinary(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'UpdateEntries'
ALTER TABLE [dbo].[UpdateEntries]
ADD CONSTRAINT [PK_UpdateEntries]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TextUpdates'
ALTER TABLE [dbo].[TextUpdates]
ADD CONSTRAINT [PK_TextUpdates]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'BinaryUpdates'
ALTER TABLE [dbo].[BinaryUpdates]
ADD CONSTRAINT [PK_BinaryUpdates]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------