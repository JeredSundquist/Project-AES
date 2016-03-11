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
-- Creating primary key on [education_id] in table 'Educations'
ALTER TABLE [dbo].[Educations]
ADD CONSTRAINT [PK_Educations]
    PRIMARY KEY CLUSTERED ([education_id] ASC);