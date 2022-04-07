CREATE TABLE [dbo].[Students] (
    [ID]   INT            IDENTITY (1, 1) NOT NULL,
    [Name] NVARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_dbo.Students] PRIMARY KEY CLUSTERED ([ID] ASC)
);

