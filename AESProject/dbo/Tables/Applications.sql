-- Creating table 'Applications'
CREATE TABLE [dbo].[Application] (
    [ApplicationId] int IDENTITY(1,1) NOT NULL,
    [Name] varchar(max)  NULL,
    [SSN] int  NULL,
    [Address] varchar(max)  NULL,
    [PhoneNumber] int  NULL,
    [PositionsApplied] varchar(max)  NULL,
    [SalaryExpectation] decimal(19,4)  NULL,
    [FullTime] bit  NULL,
    [MondayAvailable] int  NULL,
    [TuesdayAvailable] int  NULL,
    [WednesdayAvailable] int  NULL,
    [ThursdayAvailable] int  NULL,
    [FridayAvailable] int  NULL,
    [SaturdayAvailable] int  NULL,
    [SundayAvailable] int  NULL,
    [MostRecentId] int  NULL,
    [MiddleRecentId] int  NULL,
    [LeastRecentId] int  NULL,
    [RecentEducationId] int  NULL,
    [MiddleEducationId] int  NULL,
    [LeastEducationId] int  NULL,
    [ReferenceId] int  NULL,
    [ApplicationDate] datetime  NULL
);
GO
-- Creating primary key on [application_id] in table 'Applications'
ALTER TABLE [dbo].[Application]
ADD CONSTRAINT [PK_Application]
    PRIMARY KEY CLUSTERED ([ApplicationId] ASC);