CREATE PROCEDURE spStructures_Delete
	@Id INT 
AS
BEGIN
	SET NOCOUNT ON;
	DELETE FROM Structures WHERE id = @Id; 
END