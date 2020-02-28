
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/27/2020 15:40:53
-- Generated from EDMX file: D:\ASP .NET CORE MVC\MovieWebAPP\Models\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [MovieDb];
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

-- Creating table 'Movies'
CREATE TABLE [dbo].[Movies] (
    [Movie_id] int IDENTITY(1,1) NOT NULL,
    [Movie_Name] nvarchar(max)  NOT NULL,
    [Release_Date] datetime  NOT NULL
);
GO

-- Creating table 'Multiplexes'
CREATE TABLE [dbo].[Multiplexes] (
    [Multiplex_id] int IDENTITY(1,1) NOT NULL,
    [Multiplex_Name] nvarchar(max)  NOT NULL,
    [Location] nvarchar(max)  NOT NULL,
    [Movie_id] int  NOT NULL,
    [MovieMovie_id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Movie_id] in table 'Movies'
ALTER TABLE [dbo].[Movies]
ADD CONSTRAINT [PK_Movies]
    PRIMARY KEY CLUSTERED ([Movie_id] ASC);
GO

-- Creating primary key on [Multiplex_id] in table 'Multiplexes'
ALTER TABLE [dbo].[Multiplexes]
ADD CONSTRAINT [PK_Multiplexes]
    PRIMARY KEY CLUSTERED ([Multiplex_id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [MovieMovie_id] in table 'Multiplexes'
ALTER TABLE [dbo].[Multiplexes]
ADD CONSTRAINT [FK_MovieMultiplex]
    FOREIGN KEY ([MovieMovie_id])
    REFERENCES [dbo].[Movies]
        ([Movie_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MovieMultiplex'
CREATE INDEX [IX_FK_MovieMultiplex]
ON [dbo].[Multiplexes]
    ([MovieMovie_id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------