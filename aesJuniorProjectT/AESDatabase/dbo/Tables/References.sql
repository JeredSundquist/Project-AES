-- Creating table 'References'
CREATE TABLE [dbo].[References] (
    [reference_id] int IDENTITY(1,1) NOT NULL,
    [reference_name] varchar(max)  NULL,
    [reference_phone] int  NULL,
    [reference_company] varchar(max)  NULL,
    [reference_title] varchar(max)  NULL
);
GO
-- Creating primary key on [reference_id] in table 'References'
ALTER TABLE [dbo].[References]
ADD CONSTRAINT [PK_References]
    PRIMARY KEY CLUSTERED ([reference_id] ASC);