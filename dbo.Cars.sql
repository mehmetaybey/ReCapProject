CREATE TABLE [dbo].[Cars] (
    [CarId]       INT             NOT NULL,
    [ColorId]     INT             NOT NULL,
    [BrandId]     INT             NOT NULL,
    [ModelYear]   DATE NOT NULL,
    [DailyPrice]  DECIMAL (18)    NOT NULL,
    [Description] NVARCHAR (MAX)  NOT NULL
);

