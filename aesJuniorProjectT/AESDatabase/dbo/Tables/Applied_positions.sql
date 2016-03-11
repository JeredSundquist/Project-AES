-- Creating table 'Applied_positions'
CREATE TABLE [dbo].[Applied_positions] (
    [user_id] int  NOT NULL,
    [positions_id] int  NOT NULL
);
GO
-- Creating primary key on [user_id], [positions_id] in table 'Applied_positions'
ALTER TABLE [dbo].[Applied_positions]
ADD CONSTRAINT [PK_Applied_positions]
    PRIMARY KEY CLUSTERED ([user_id], [positions_id] ASC);