
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/10/2016 18:47:16
-- Generated from EDMX file: C:\Users\Jered\Documents\GitHub\Project-AES\aesJuniorProjectT\aesJuniorProjectT\aesJuniorProjectT.Entities.Shared.Net45\Models\entityModels.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO

USE [aes];
GO

IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Answers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Answer];
GO

IF OBJECT_ID(N'[dbo].[Applications]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Application];
GO

IF OBJECT_ID(N'[dbo].[Education]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Education];
GO

IF OBJECT_ID(N'[dbo].[JobHistory]', 'U') IS NOT NULL
    DROP TABLE [dbo].[JobHistory];
GO

IF OBJECT_ID(N'[dbo].[Positions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Position];
GO

IF OBJECT_ID(N'[dbo].[Questions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Question];
GO

IF OBJECT_ID(N'[dbo].[References]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Reference];
GO

IF OBJECT_ID(N'[dbo].[Stores]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Store];
GO

IF OBJECT_ID(N'[dbo].[Tests]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Test];
GO

IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[User];
GO

IF OBJECT_ID(N'[aesModelStoreContainer].[Applied_positions]', 'U') IS NOT NULL
    DROP TABLE [aesModelStoreContainer].[Applied_positions];
GO


-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------

GO
