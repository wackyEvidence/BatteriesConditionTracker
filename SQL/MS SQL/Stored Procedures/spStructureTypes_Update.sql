CREATE PROCEDURE dbo.spStructureTypes_Update
	@Id INT,
	@Name NVARCHAR(50) 
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE StructureTypes SET name = @Name WHERE id = @Id;
END