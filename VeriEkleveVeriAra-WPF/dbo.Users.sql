CREATE TABLE [dbo].[Users] (
    [Id]        INT           IDENTITY (1, 1) NOT NULL,
    [FirstName] VARCHAR (50)  NOT NULL,
    [LastName]  VARCHAR (50)  NOT NULL,
    [Email]     VARCHAR (140) NOT NULL,
    [Password]  VARCHAR (50)  NOT NULL,
    [GSM]       BIGINT           NOT NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([Id] ASC)
);

