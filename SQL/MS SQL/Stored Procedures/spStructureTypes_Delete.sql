CREATE PROCEDURE dbo.spStructureTypes_Delete
	@Id INT
	
AS
BEGIN
	SET NOCOUNT ON;
	DELETE FROM StructureTypes WHERE id = @Id;
END