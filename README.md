# RecordStore
you have to replace email username and password in privatedataclass with an outlook/ hotmail account

sqls for local databases:

CREATE TABLE [dbo].[Bank] (
    [UserId]                 UNIQUEIDENTIFIER NOT NULL,
    [NewWalletAmount]        FLOAT (53)       NOT NULL,
    [TransactionNumber]      UNIQUEIDENTIFIER NOT NULL,
    [TransactionDescription] VARCHAR (MAX)    NOT NULL,
    [TransactionAmount]      FLOAT (53)       NOT NULL,
    [TransactionDate]        DATETIME         NOT NULL,
    [TransactionLocation]    VARCHAR (50)     NOT NULL,
    PRIMARY KEY CLUSTERED ([TransactionNumber] ASC)
);
CREATE TABLE [dbo].[UserData] (
    [UserId]         UNIQUEIDENTIFIER NOT NULL,
    [Username]       VARCHAR (50)     NOT NULL,
    [Password]       NCHAR (10)       NOT NULL,
    [Age]            INT              NOT NULL,
    [Location]       VARCHAR (50)     NOT NULL,
    [AccountBalance] FLOAT (53)       NOT NULL,
    PRIMARY KEY CLUSTERED ([UserId] ASC)
);
CREATE TABLE [dbo].[UserMovies] (
    [UserId]        UNIQUEIDENTIFIER NOT NULL,
    [MovieTitle]    VARCHAR (50)     NOT NULL,
    [PurchasePrice] FLOAT (53)       NOT NULL,
    [MovieDesc]     VARCHAR (MAX)    NOT NULL,
    [ReleaseDate]   DATETIME         NOT NULL,
    [PurchaseDate]  DATETIME         NOT NULL,
    [ImdbID]        VARCHAR (50)     NOT NULL,
    [MoviesDbID]    VARCHAR (50)     NOT NULL,
    [Genre]         VARCHAR (50)     NULL,
    PRIMARY KEY CLUSTERED ([MovieTitle] ASC)
);
CREATE TABLE [dbo].[PromoCodes] (
    [PromoId]          INT           NOT NULL,
    [PromoName]        VARCHAR (50)  NOT NULL,
    [PromoDesc]        VARCHAR (MAX) NULL,
    [PromoValue]       FLOAT (53)    NULL,
    [PromoRequirement] INT           NULL,
    PRIMARY KEY CLUSTERED ([PromoId] ASC)
);
CREATE TABLE [dbo].[UserPromos] (
    [PromoId]    INT              NOT NULL,
    [UserId]     UNIQUEIDENTIFIER NOT NULL,
    [PromoName]  VARCHAR (50)     NOT NULL,
    [PromoValue] FLOAT (53)       NOT NULL,
    CONSTRAINT [PK_Books_Authors] PRIMARY KEY CLUSTERED ([PromoId] ASC, [UserId] ASC)
);
