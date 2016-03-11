-- Creating table 'Educations'
CREATE TABLE [dbo].[Education] (
    [EducationId] int IDENTITY(1,1) NOT NULL,
    [SchoolName] varchar(max)  NULL,
    [SchoolAddress] varchar(max)  NULL,
    [TimeAttended] datetime  NULL,
    [TimeLeft] datetime  NULL,
    [Graduated] bit  NULL,
    [DegreeMajor] varchar(max)  NULL
);
GO
-- Creating primary key on [education_id] in table 'Educations'
ALTER TABLE [dbo].[Education]
ADD CONSTRAINT [PK_Education]
    PRIMARY KEY CLUSTERED ([EducationId] ASC);