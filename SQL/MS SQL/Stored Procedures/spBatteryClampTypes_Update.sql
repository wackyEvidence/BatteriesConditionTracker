CREATE PROCEDURE spBatteryClampTypes_Update 
	@Id INT, 
	@Name NVARCHAR(50)
AS
BEGIN
	SET NOCOUNT ON; 
	UPDATE dbo.BatteryClampTypes SET NAME = @Name WHERE id = @Id; 
END; 