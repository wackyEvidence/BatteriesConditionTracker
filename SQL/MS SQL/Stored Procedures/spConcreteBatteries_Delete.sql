CREATE PROCEDURE spConcreteBatteries_Delete
	@Id INT
AS
BEGIN
	SET NOCOUNT ON;
	DELETE FROM ConcreteBatteries WHERE id = @Id; 
END