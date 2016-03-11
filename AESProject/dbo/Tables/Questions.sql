-- Creating table 'Questions'
CREATE TABLE [dbo].[Question] (
    [QuestionId] int IDENTITY(1,1) NOT NULL,
    [Question] varchar(max)  NULL,
    [QuestionText] nchar(10)  NULL,
    [AnswerId] int  NULL, 
    CONSTRAINT [FK_Question_ToTable_Answer] FOREIGN KEY ([AnswerId]) REFERENCES [Answer]([AnswerId])
);
GO
-- Creating primary key on [question_id] in table 'Questions'
ALTER TABLE [dbo].[Question]
ADD CONSTRAINT [PK_Question]
    PRIMARY KEY CLUSTERED ([QuestionId] ASC);