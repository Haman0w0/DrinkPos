
CREATE TABLE [dbo].[Drink] (
    [DrinkID]   INT          IDENTITY (1, 1) NOT NULL,
    [DrinkName] VARCHAR (20) NOT NULL,
    PRIMARY KEY CLUSTERED ([DrinkID] ASC),
    UNIQUE NONCLUSTERED ([DrinkName] ASC)
);

CREATE TABLE [dbo].[Size] (
    [SizeID]   INT          IDENTITY (1, 1) NOT NULL,
    [SizeName] VARCHAR (10) NOT NULL,
    PRIMARY KEY CLUSTERED ([SizeID] ASC),
    UNIQUE NONCLUSTERED ([SizeName] ASC)
);

CREATE TABLE [dbo].[Employee] (
    [EmployeeID]   VARCHAR (20)  NOT NULL,
    [EmployeeName] NVARCHAR (30) NOT NULL,
    [EmployeePwd]  VARCHAR (20)  NOT NULL,
    PRIMARY KEY CLUSTERED ([EmployeeID] ASC)
);

CREATE TABLE [dbo].[DrinkSize] (
    [DrinkID] INT NOT NULL,
    [SizeID]  INT NOT NULL,
    [Price]   INT NOT NULL,
    PRIMARY KEY CLUSTERED ([DrinkID] ASC, [SizeID] ASC),
    CONSTRAINT [FK_ToDrink] FOREIGN KEY ([DrinkID]) REFERENCES [dbo].[Drink] ([DrinkID]),
    CONSTRAINT [FK_ToSize] FOREIGN KEY ([SizeID]) REFERENCES [dbo].[Size] ([SizeID]),
    CONSTRAINT [CK_Price] CHECK ([Price]>(0))
);

CREATE TABLE [dbo].[Transaction] (
    [TransactionID]   INT          IDENTITY (1, 1) NOT NULL,
    [TransactionDate] DATE         NOT NULL,
    [EmployeeID]      VARCHAR (20) NOT NULL,
    PRIMARY KEY CLUSTERED ([TransactionID] ASC),
    CONSTRAINT [FK_ToEmployee] FOREIGN KEY ([EmployeeID]) REFERENCES [dbo].[Employee] ([EmployeeID])
);

CREATE TABLE [dbo].[TransactionSize] (
    [TransactionSizeID] INT IDENTITY (1, 1) NOT NULL,
    [TransactionID]     INT NOT NULL,
    [DrinkID]           INT NOT NULL,
    [SizeID]            INT NOT NULL,
    [Amount]            INT NOT NULL,
    PRIMARY KEY CLUSTERED ([TransactionSizeID] ASC),
    CONSTRAINT [FK_ToTransaction] FOREIGN KEY ([TransactionID]) REFERENCES [dbo].[Transaction] ([TransactionID]),
    CONSTRAINT [FK_TroDrinkSize] FOREIGN KEY ([DrinkID], [SizeID]) REFERENCES [dbo].[DrinkSize] ([DrinkID], [SizeID]),
    CONSTRAINT [Ck_Amount] CHECK ([Amount]>(0))
);
