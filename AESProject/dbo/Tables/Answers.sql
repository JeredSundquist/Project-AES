-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Answers'
CREATE TABLE [dbo].[Answer] (
    [AnswerId] int  NOT NULL,
    [CorrectAnswer] varchar(max)  NOT NULL
);
GO
-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [answer_id] in table 'Answers'
ALTER TABLE [dbo].[Answer]
ADD CONSTRAINT [PK_Answer]
    PRIMARY KEY CLUSTERED ([AnswerId] ASC);