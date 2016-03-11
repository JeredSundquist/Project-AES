-- Creating table 'Tests'
CREATE TABLE [dbo].[Test] (
    [TestId] int IDENTITY(1,1) NOT NULL,
    [QuestionList] varchar(max)  NULL,
    [PassingScore] int  NULL, 
);
GO
-- Creating primary key on [test_id] in table 'Tests'
ALTER TABLE [dbo].[Test]
ADD CONSTRAINT [PK_Tests]
    PRIMARY KEY CLUSTERED ([TestId] ASC);