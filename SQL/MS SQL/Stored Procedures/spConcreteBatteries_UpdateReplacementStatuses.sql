ALTER PROCEDURE dbo.spConcreteBatteries_UpdateReplacementStatuses
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE ConcreteBatteries
	SET replacement_status_id = 1
	WHERE DATEDIFF(day, GETDATE(), exploitation_start) > 
	(SELECT buffer_mode_service_time * 365 FROM BatteryModels WHERE id = ConcreteBatteries.model_id)
	AND exploitation_status_id = 1;
END
GO
