-- Creating table 'Users'
CREATE TABLE [dbo].[User] (
    [UserId] int IDENTITY(1,1) NOT NULL,
    [UserName] varchar(max)  NULL,
    [Password] varchar(max)  NULL,
    [Email] varchar(max)  NULL,
    [Address] varchar(max)  NULL
);
GO
-- Creating primary key on [user_id] in table 'Users'
ALTER TABLE [dbo].[User]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([UserId] ASC);