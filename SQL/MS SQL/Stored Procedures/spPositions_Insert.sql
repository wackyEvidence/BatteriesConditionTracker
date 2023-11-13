CREATE PROCEDURE dbo.spPositions_Insert
	@PositionName NVARCHAR(50), 
	@id INT = 0 OUTPUT
	
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO dbo.Positions VALUES (@PositionName);	
	SELECT @id = SCOPE_IDENTITY();
END
GO
