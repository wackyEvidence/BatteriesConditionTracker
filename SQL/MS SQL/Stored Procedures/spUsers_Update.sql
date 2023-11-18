CREATE PROCEDURE spUsers_Update
	@Id INT,
	@Name NVARCHAR(100), 
	@Surname NVARCHAR(100),
	@Patronymic NVARCHAR(100), 
	@PhoneNumber NVARCHAR(16),
	@Email NVARCHAR(200), 
	@PositionId INT, 
	@SupervisorId INT, 
	@Password TEXT, 
	@IsAdmin BIT
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE Users 
	SET name = @Name, surname = @Surname, patronymic = @Patronymic, phone_number = @PhoneNumber, 
	email = @Email, position_id = @PositionId, supervisor_id = @SupervisorId, password = @Password, is_admin = @IsAdmin	
	WHERE id = @Id; 
END