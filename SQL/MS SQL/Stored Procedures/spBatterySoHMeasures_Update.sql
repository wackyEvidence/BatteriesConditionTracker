CREATE PROCEDURE spBatterySoHMeasures_Update
	@Id INT,
	@BatteryId INT, 
	@PerformingEmployeeId INT, 
	@MeasureDate DATE, 
	@SoH FLOAT
AS 
BEGIN 
	SET NOCOUNT ON; 
	UPDATE dbo.BatterySoHMeasures SET battery_id = @BatteryId, performing_employee_id = @PerformingEmployeeId,
	measure_date = @MeasureDate, soh = @SoH WHERE id = @Id 
END