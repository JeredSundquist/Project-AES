-- Creating table 'Positions'
CREATE TABLE [dbo].[Positions] (
    [positions_id] int IDENTITY(1,1) NOT NULL,
    [positions_name] varchar(max)  NOT NULL,
    [positions_desc] varchar(max)  NOT NULL,
    [store_id] int  NOT NULL,
    [test_id] int  NOT NULL
);
GO
-- Creating primary key on [positions_id] in table 'Positions'
ALTER TABLE [dbo].[Positions]
ADD CONSTRAINT [PK_Positions]
    PRIMARY KEY CLUSTERED ([positions_id] ASC);