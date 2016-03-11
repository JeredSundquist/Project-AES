-- Creating table 'Questions'
CREATE TABLE [dbo].[Questions] (
    [question_id] int IDENTITY(1,1) NOT NULL,
    [question1] varchar(max)  NULL,
    [question_text] nchar(10)  NULL,
    [answer_id] int  NULL
);
GO
-- Creating primary key on [question_id] in table 'Questions'
ALTER TABLE [dbo].[Questions]
ADD CONSTRAINT [PK_Questions]
    PRIMARY KEY CLUSTERED ([question_id] ASC);