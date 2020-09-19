﻿CREATE TABLE [dbo].[Sale]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [CashierId] NCHAR(10) NOT NULL, 
    [SaleDate] DATETIME2 NOT NULL, 
    [SubTotal] MONEY NOT NULL, 
    [Tax] MONEY NOT NULL, 
    [Total] MONEY NOT NULL
)
