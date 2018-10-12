CREATE FUNCTION [dbo].[IsOpenAtDateTime]
(
	@DateTime DateTime
)
RETURNS BIT 
AS 
BEGIN

	RETURN
	IIF(EXISTS 
		(
			SELECT
				1
			FROM
				Day
			WHERE 
				@DateTime BETWEEN
					DATETIMEFROMPARTS(YEAR(Date),
									  MONTH(Date),
									  DAY(Date),
									  OpensAtHour,
									  OpensAtMinute,
									  0,
									  0)
						AND
					DATETIMEFROMPARTS(YEAR(Date),
									  MONTH(Date),
									  DAY(Date),
									  ClosesAtHour,
									  ClosesAtMinute,
									  0,
									  0)
		),
	1,
	0)

END