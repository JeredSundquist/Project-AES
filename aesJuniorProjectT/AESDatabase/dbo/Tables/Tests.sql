-- Creating table 'Tests'
CREATE TABLE [dbo].[Tests] (
    [test_id] int IDENTITY(1,1) NOT NULL,
    [question_list] varchar(max)  NULL,
    [passingScore] int  NULL
);
GO
-- Creating primary key on [test_id] in table 'Tests'
ALTER TABLE [dbo].[Tests]
ADD CONSTRAINT [PK_Tests]
    PRIMARY KEY CLUSTERED ([test_id] ASC);