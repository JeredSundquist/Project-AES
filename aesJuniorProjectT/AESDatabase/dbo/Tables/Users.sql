-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [user_id] int IDENTITY(1,1) NOT NULL,
    [user_name] varchar(max)  NULL,
    [password] varchar(max)  NULL,
    [email] varchar(max)  NULL,
    [address] varchar(max)  NULL
);
GO
-- Creating primary key on [user_id] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([user_id] ASC);