CREATE PROCEDURE spBatteryReplacementStatuses_GetAll
AS
BEGIN
	SELECT * FROM dbo.BatteryReplacementStatuses;
END;