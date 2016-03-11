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
-- Creating primary key on [jobHistory_id] in table 'JobHistories'
ALTER TABLE [dbo].[JobHistories]
ADD CONSTRAINT [PK_JobHistories]
    PRIMARY KEY CLUSTERED ([jobHistory_id] ASC);