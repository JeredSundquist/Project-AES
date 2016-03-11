-- Creating table 'JobHistories'
CREATE TABLE [dbo].[JobHistory] (
    [JobHistoryId] int IDENTITY(1,1) NOT NULL,
    [Employer] varchar(max)  NULL,
    [EmpAddress] varchar(max)  NULL,
    [JobTitle] varchar(max)  NULL,
    [ReasonLeaving] varchar(max)  NULL,
    [DateStarted] datetime  NULL,
    [DateEnded] datetime  NULL,
    [Phone] int  NULL,
    [Superviser] int  NULL,
    [StartingSalary] decimal(19,4)  NULL,
    [Responsibilities] varchar(max)  NULL,
    [EndingSalary] decimal(19,4)  NULL
);
GO
-- Creating primary key on [jobHistory_id] in table 'JobHistories'
ALTER TABLE [dbo].[JobHistory]
ADD CONSTRAINT [PK_JobHistory]
    PRIMARY KEY CLUSTERED ([JobHistoryId] ASC);