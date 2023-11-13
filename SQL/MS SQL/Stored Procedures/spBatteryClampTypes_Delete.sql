CREATE PROCEDURE spBatteryClampTypes_Delete
	@Id INT

AS 
BEGIN 
	SET NOCOUNT ON; 
	DELETE FROM dbo.BatteryClampTypes WHERE id = @Id; 
END;