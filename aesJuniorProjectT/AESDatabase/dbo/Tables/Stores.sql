-- Creating table 'Stores'
CREATE TABLE [dbo].[Stores] (
    [store_id] int IDENTITY(1,1) NOT NULL,
    [store_location] varchar(max)  NULL,
    [store_name] varchar(max)  NULL
);
GO
-- Creating primary key on [store_id] in table 'Stores'
ALTER TABLE [dbo].[Stores]
ADD CONSTRAINT [PK_Stores]
    PRIMARY KEY CLUSTERED ([store_id] ASC);