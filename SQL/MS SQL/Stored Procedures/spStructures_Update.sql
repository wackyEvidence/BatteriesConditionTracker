CREATE PROCEDURE spStructures_Update
	@Name NVARCHAR(50),
	@TypeId INT,
	@Id INT
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE Structures SET name = @Name, type_id = @TypeId
	WHERE id = @Id
END