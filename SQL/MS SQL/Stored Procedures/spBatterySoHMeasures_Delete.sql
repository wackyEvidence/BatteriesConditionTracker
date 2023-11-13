CREATE PROCEDURE spBatterySoHMeasures_Delete
	@Id INT
AS 
BEGIN 
	SET NOCOUNT ON; 
	DELETE FROM dbo.BatterySoHMeasures WHERE id = @Id;
END