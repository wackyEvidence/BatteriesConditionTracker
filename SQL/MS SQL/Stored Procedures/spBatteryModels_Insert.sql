CREATE PROCEDURE spBatteryModels_Insert
	@Name NVARCHAR(50), 
	@Brand NVARCHAR(50), 
	@Capacity FLOAT, 
	@Voltage FLOAT, 
	@Length FLOAT, 
	@Height FLOAT, 
	@Width FLOAT, 
	@TechnologyId INT, 
	@ClampTypeId INT, 
	@Cost MONEY, 
	@BufferModeServiceTime FLOAT, 
	@SoHThreshold INT, 
	@Id INT = 0 OUTPUT
AS
BEGIN 
	SET NOCOUNT ON;
	INSERT INTO BatteryModels 
	VALUES (@Name, @Brand, @Capacity, @Voltage, @Length, @Height, @Width, @TechnologyId, @ClampTypeId, @Cost, @BufferModeServiceTime, @SoHThreshold);
	SELECT @Id = SCOPE_IDENTITY();
END