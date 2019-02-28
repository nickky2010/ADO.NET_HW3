
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/28/2019 16:01:03
-- Generated from EDMX file: A:\Учеба\ADO.NET\HomeWork\ADO.NET_HW3(Entity_Framework)\Model_First\CatsModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [CatsAndOwners];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'OwnersSet'
CREATE TABLE [dbo].[OwnersSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Surname] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'CatsSet'
CREATE TABLE [dbo].[CatsSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Age] int  NOT NULL,
    [Owner_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'OwnersSet'
ALTER TABLE [dbo].[OwnersSet]
ADD CONSTRAINT [PK_OwnersSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CatsSet'
ALTER TABLE [dbo].[CatsSet]
ADD CONSTRAINT [PK_CatsSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Owner_Id] in table 'CatsSet'
ALTER TABLE [dbo].[CatsSet]
ADD CONSTRAINT [FK_OwnersCats]
    FOREIGN KEY ([Owner_Id])
    REFERENCES [dbo].[OwnersSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_OwnersCats'
CREATE INDEX [IX_FK_OwnersCats]
ON [dbo].[CatsSet]
    ([Owner_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------