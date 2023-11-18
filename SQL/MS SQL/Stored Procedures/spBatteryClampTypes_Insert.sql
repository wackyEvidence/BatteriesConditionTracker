CREATE PROCEDURE spBatteryClampTypes_Insert
	@Name NVARCHAR(50), 
	@Id INT = 0 output 
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO BatteryClampTypes VALUES (@Name); 
	SELECT @Id = SCOPE_IDENTITY(); 
END