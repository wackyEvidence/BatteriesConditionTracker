CREATE PROCEDURE spBatteryModels_Update
	@Id INT,
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
	@SoHThreshold INT
AS
BEGIN 
	SET NOCOUNT ON;
	UPDATE BatteryModels 
	SET
	name = @Name, brand = @Brand, capacity = @Capacity, voltage = @Voltage, length = @Length, 
	height = @Height, width = @Width, technology_id = @TechnologyId, clamp_type_id = @ClampTypeId, 
	cost = @Cost, buffer_mode_service_time = @BufferModeServiceTime, soh_threshold = @SoHThreshold
	WHERE id = @Id;
END