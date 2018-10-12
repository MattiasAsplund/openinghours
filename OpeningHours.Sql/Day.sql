CREATE TABLE [dbo].[Day]
(
	[DayId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Date] DATE NOT NULL, 
    [OpensAtHour] INT NOT NULL, 
    [OpensAtMinute] INT NOT NULL, 
    [ClosesAtHour] INT NOT NULL, 
    [ClosesAtMinute] INT NOT NULL
)
