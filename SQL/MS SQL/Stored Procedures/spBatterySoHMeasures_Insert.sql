CREATE PROCEDURE spBatterySoHMeasures_Insert
	@BatteryId INT, 
	@PerformingEmployee INT, 
	@MeasureDate DATE, 
	@SoH FLOAT, 
	@Id INT = 0 OUTPUT
AS 
BEGIN 
	SET NOCOUNT ON; 
	INSERT INTO dbo.BatterySoHMeasures VALUES (@BatteryId, @PerformingEmployee, @MeasureDate, @SoH); 
	SELECT @Id = SCOPE_IDENTITY(); 
END