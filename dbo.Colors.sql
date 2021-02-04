CREATE TABLE [dbo].[Cars] (
    [CarId]       INT             NOT NULL,
    [ColorId]     INT             NOT NULL,
    [BrandId]     INT             NOT NULL,
    [ModelYear]   NVARCHAR(50) NOT NULL,
    [DailyPrice]  DECIMAL (18)    NOT NULL,
    [Description] NVARCHAR (50)  NOT NULL
);

