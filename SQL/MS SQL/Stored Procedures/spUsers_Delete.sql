CREATE PROCEDURE spUsers_Delete
	@Id INT
AS
BEGIN
	SET NOCOUNT ON;
	DELETE FROM Users 
	WHERE id = @Id; 
END