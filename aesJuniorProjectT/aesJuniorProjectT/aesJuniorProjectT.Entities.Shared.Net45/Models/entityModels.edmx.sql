
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
    DROP TABLE [dbo].[Answers];
GO
IF OBJECT_ID(N'[dbo].[Applications]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Applications];
GO
IF OBJECT_ID(N'[dbo].[Education]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Education];
GO
IF OBJECT_ID(N'[dbo].[JobHistory]', 'U') IS NOT NULL
    DROP TABLE [dbo].[JobHistory];
GO
IF OBJECT_ID(N'[dbo].[Positions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Positions];
GO
IF OBJECT_ID(N'[dbo].[Questions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Questions];
GO
IF OBJECT_ID(N'[dbo].[References]', 'U') IS NOT NULL
    DROP TABLE [dbo].[References];
GO
IF OBJECT_ID(N'[dbo].[Stores]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Stores];
GO
IF OBJECT_ID(N'[dbo].[Tests]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Tests];
GO
IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO
IF OBJECT_ID(N'[aesModelStoreContainer].[Applied_positions]', 'U') IS NOT NULL
    DROP TABLE [aesModelStoreContainer].[Applied_positions];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Answers'
CREATE TABLE [dbo].[Answers] (
    [answer_id] int  NOT NULL,
    [correct_answer] varchar(max)  NOT NULL
);
GO

-- Creating table 'Applications'
CREATE TABLE [dbo].[Applications] (
    [application_id] int IDENTITY(1,1) NOT NULL,
    [name] varchar(max)  NULL,
    [ssn] int  NULL,
    [address] varchar(max)  NULL,
    [phoneNumber] int  NULL,
    [positions_applied] varchar(max)  NULL,
    [salaryExpectation] decimal(19,4)  NULL,
    [fullTime] bit  NULL,
    [mondayAvailable] int  NULL,
    [tuesdayAvailable] int  NULL,
    [wednesdayAvailable] int  NULL,
    [thursdayAvailable] int  NULL,
    [fridayAvailable] int  NULL,
    [saturdayAvailable] int  NULL,
    [sundayAvailable] int  NULL,
    [mostRecent_id] int  NULL,
    [middleRecent_id] int  NULL,
    [leastRecent_id] int  NULL,
    [recentEducation_id] int  NULL,
    [middleEducation_id] int  NULL,
    [leastEducation_id] int  NULL,
    [reference_id] int  NULL,
    [application_date] datetime  NULL
);
GO

-- Creating table 'Educations'
CREATE TABLE [dbo].[Educations] (
    [education_id] int IDENTITY(1,1) NOT NULL,
    [schoolName] varchar(max)  NULL,
    [schoolAddress] varchar(max)  NULL,
    [timeAttended] datetime  NULL,
    [timeLeft] datetime  NULL,
    [graduated] bit  NULL,
    [degreeMajor] varchar(max)  NULL
);
GO

-- Creating table 'JobHistories'
CREATE TABLE [dbo].[JobHistories] (
    [jobHistory_id] int IDENTITY(1,1) NOT NULL,
    [employer] varchar(max)  NULL,
    [empAddress] varchar(max)  NULL,
    [jobTitle] varchar(max)  NULL,
    [reasonLeaving] varchar(max)  NULL,
    [dateStarted] datetime  NULL,
    [dateEnded] datetime  NULL,
    [phone] int  NULL,
    [superviser] int  NULL,
    [startingSalary] decimal(19,4)  NULL,
    [responsibilities] varchar(max)  NULL,
    [endingSalary] decimal(19,4)  NULL
);
GO

-- Creating table 'Positions'
CREATE TABLE [dbo].[Positions] (
    [positions_id] int IDENTITY(1,1) NOT NULL,
    [positions_name] varchar(max)  NOT NULL,
    [positions_desc] varchar(max)  NOT NULL,
    [store_id] int  NOT NULL,
    [test_id] int  NOT NULL
);
GO

-- Creating table 'Questions'
CREATE TABLE [dbo].[Questions] (
    [question_id] int IDENTITY(1,1) NOT NULL,
    [question1] varchar(max)  NULL,
    [question_text] nchar(10)  NULL,
    [answer_id] int  NULL
);
GO

-- Creating table 'References'
CREATE TABLE [dbo].[References] (
    [reference_id] int IDENTITY(1,1) NOT NULL,
    [reference_name] varchar(max)  NULL,
    [reference_phone] int  NULL,
    [reference_company] varchar(max)  NULL,
    [reference_title] varchar(max)  NULL
);
GO

-- Creating table 'Stores'
CREATE TABLE [dbo].[Stores] (
    [store_id] int IDENTITY(1,1) NOT NULL,
    [store_location] varchar(max)  NULL,
    [store_name] varchar(max)  NULL
);
GO

-- Creating table 'Tests'
CREATE TABLE [dbo].[Tests] (
    [test_id] int IDENTITY(1,1) NOT NULL,
    [question_list] varchar(max)  NULL,
    [passingScore] int  NULL
);
GO

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [user_id] int IDENTITY(1,1) NOT NULL,
    [user_name] varchar(max)  NULL,
    [password] varchar(max)  NULL,
    [email] varchar(max)  NULL,
    [address] varchar(max)  NULL
);
GO

-- Creating table 'Applied_positions'
CREATE TABLE [dbo].[Applied_positions] (
    [user_id] int  NOT NULL,
    [positions_id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [answer_id] in table 'Answers'
ALTER TABLE [dbo].[Answers]
ADD CONSTRAINT [PK_Answers]
    PRIMARY KEY CLUSTERED ([answer_id] ASC);
GO

-- Creating primary key on [application_id] in table 'Applications'
ALTER TABLE [dbo].[Applications]
ADD CONSTRAINT [PK_Applications]
    PRIMARY KEY CLUSTERED ([application_id] ASC);
GO

-- Creating primary key on [education_id] in table 'Educations'
ALTER TABLE [dbo].[Educations]
ADD CONSTRAINT [PK_Educations]
    PRIMARY KEY CLUSTERED ([education_id] ASC);
GO

-- Creating primary key on [jobHistory_id] in table 'JobHistories'
ALTER TABLE [dbo].[JobHistories]
ADD CONSTRAINT [PK_JobHistories]
    PRIMARY KEY CLUSTERED ([jobHistory_id] ASC);
GO

-- Creating primary key on [positions_id] in table 'Positions'
ALTER TABLE [dbo].[Positions]
ADD CONSTRAINT [PK_Positions]
    PRIMARY KEY CLUSTERED ([positions_id] ASC);
GO

-- Creating primary key on [question_id] in table 'Questions'
ALTER TABLE [dbo].[Questions]
ADD CONSTRAINT [PK_Questions]
    PRIMARY KEY CLUSTERED ([question_id] ASC);
GO

-- Creating primary key on [reference_id] in table 'References'
ALTER TABLE [dbo].[References]
ADD CONSTRAINT [PK_References]
    PRIMARY KEY CLUSTERED ([reference_id] ASC);
GO

-- Creating primary key on [store_id] in table 'Stores'
ALTER TABLE [dbo].[Stores]
ADD CONSTRAINT [PK_Stores]
    PRIMARY KEY CLUSTERED ([store_id] ASC);
GO

-- Creating primary key on [test_id] in table 'Tests'
ALTER TABLE [dbo].[Tests]
ADD CONSTRAINT [PK_Tests]
    PRIMARY KEY CLUSTERED ([test_id] ASC);
GO

-- Creating primary key on [user_id] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([user_id] ASC);
GO

-- Creating primary key on [user_id], [positions_id] in table 'Applied_positions'
ALTER TABLE [dbo].[Applied_positions]
ADD CONSTRAINT [PK_Applied_positions]
    PRIMARY KEY CLUSTERED ([user_id], [positions_id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------