/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

DELETE FROM Day

INSERT INTO Day (Date, OpensAtHour, OpensAtMinute, ClosesAtHour, ClosesAtMinute)
	VALUES ('2018-10-01', 9, 30, 17, 0)

INSERT INTO Day (Date, OpensAtHour, OpensAtMinute, ClosesAtHour, ClosesAtMinute)
	VALUES ('2018-10-02', 8, 0, 19, 0)
