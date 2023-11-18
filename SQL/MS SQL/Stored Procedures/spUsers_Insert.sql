CREATE PROCEDURE spUsers_Insert
	@Name NVARCHAR(100), 
	@Surname NVARCHAR(100),
	@Patronymic NVARCHAR(100), 
	@PhoneNumber NVARCHAR(16),
	@Email NVARCHAR(200), 
	@PositionId INT, 
	@SupervisorId INT, 
	@Password TEXT, 
	@IsAdmin BIT,
	@Id INT = 0 OUTPUT
	
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO Users 
	VALUES (@Name, @Surname, @Patronymic, @PhoneNumber, @Email, @PositionId, @SupervisorId, @Password, @IsAdmin);	
	SELECT @Id = SCOPE_IDENTITY();
END