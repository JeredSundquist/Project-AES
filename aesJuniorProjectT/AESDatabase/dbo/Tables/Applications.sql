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
-- Creating primary key on [application_id] in table 'Applications'
ALTER TABLE [dbo].[Applications]
ADD CONSTRAINT [PK_Applications]
    PRIMARY KEY CLUSTERED ([application_id] ASC);