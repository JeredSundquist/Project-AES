-- Creating table 'Applied_positions'
CREATE TABLE [dbo].[AppliedPosition] (
    [UserId] int  NOT NULL,
    [PositionId] int  NOT NULL, 
    CONSTRAINT [FK_AppliedPosition_ToTable_Position] FOREIGN KEY ([PositionId]) REFERENCES [Position]([PositionId])
);
GO
-- Creating primary key on [user_id], [positions_id] in table 'Applied_positions'
ALTER TABLE [dbo].[AppliedPosition]
ADD CONSTRAINT [PK_AppliedPosition]
    PRIMARY KEY CLUSTERED ([UserId], [PositionId] ASC);