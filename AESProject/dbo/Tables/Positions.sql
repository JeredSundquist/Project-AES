
-- Creating table 'Positions'
CREATE TABLE [dbo].[Position] (
    [PositionId] int IDENTITY(1,1) NOT NULL,
    [PositionName] varchar(max)  NOT NULL,
    [PositionDesc] varchar(max)  NOT NULL,
    [StoreId] int  NOT NULL,
    [TestId] int  NOT NULL, 
    CONSTRAINT [FK_Position_ToTable_Store] FOREIGN KEY ([StoreId]) REFERENCES [Store]([StoreId]), 
    CONSTRAINT [FK_Position_ToTable_Test] FOREIGN KEY ([TestId]) REFERENCES [Test]([TestId])
);
GO
-- Creating primary key on [positions_id] in table 'Positions'
ALTER TABLE [dbo].[Position]
ADD CONSTRAINT [PK_Position]
    PRIMARY KEY CLUSTERED ([PositionId] ASC);