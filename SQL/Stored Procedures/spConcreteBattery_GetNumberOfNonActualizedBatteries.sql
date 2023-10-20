CREATE PROCEDURE dbo.spConcreteBattery_GetNumberOfNonActualizedBatteries
	@MonthCount INT 

AS 
BEGIN 
	SET NOCOUNT ON; 
	SELECT COUNT(id) FROM tblConcreteBattery 
	WHERE last_capacity_measure_date = NULL 
	OR DATEDIFF(month, last_capacity_measure_date, GETDATE()) >= @MonthCount
END 