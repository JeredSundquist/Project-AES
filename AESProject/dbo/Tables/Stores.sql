-- Creating table 'Stores'
CREATE TABLE [dbo].[Store] (
    [StoreId] int IDENTITY(1,1) NOT NULL,
    [StoreLocation] varchar(max)  NULL,
    [StoreName] varchar(max)  NULL
);
GO
-- Creating primary key on [store_id] in table 'Stores'
ALTER TABLE [dbo].[Store]
ADD CONSTRAINT [PK_Store]
    PRIMARY KEY CLUSTERED ([StoreId] ASC);