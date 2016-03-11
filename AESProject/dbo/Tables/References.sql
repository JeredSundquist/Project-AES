-- Creating table 'References'
CREATE TABLE [dbo].[Reference] (
    [ReferenceId] int IDENTITY(1,1) NOT NULL,
    [ReferenceName] varchar(max)  NULL,
    [ReferencePhone] int  NULL,
    [ReferenceCompany] varchar(max)  NULL,
    [ReferenceTitle] varchar(max)  NULL
);
GO
-- Creating primary key on [reference_id] in table 'References'
ALTER TABLE [dbo].[Reference]
ADD CONSTRAINT [PK_Reference]
    PRIMARY KEY CLUSTERED ([ReferenceId] ASC);