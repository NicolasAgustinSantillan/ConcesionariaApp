CREATE TABLE [dbo].[car] (
    [Id]          INT             IDENTITY (1, 1) NOT NULL,
    [Code]        VARCHAR (10)    NULL,
    [Type]        VARCHAR (50)    NULL,
    [Brand]       VARCHAR (50)    NULL,
    [Model]       VARCHAR (50)    NULL,
    [Year]        INT             NULL,
    [Description] VARCHAR (255)   NULL,
    [Patent]      VARCHAR (50)    NULL,
    [Kilometers]  INT             DEFAULT ((0)) NULL,
    [Price]       DECIMAL (10, 2) DEFAULT ((0.00)) NULL,
    [Active]      BIT             DEFAULT ((1)) NULL,
    [IncomeDate]  DATETIME        DEFAULT (getdate()) NULL,
    [Photo]       VARBINARY (MAX) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

