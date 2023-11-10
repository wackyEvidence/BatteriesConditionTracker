CREATE PROCEDURE dbo.spPosition_Insert
	@PositionName NVARCHAR(50), 
	@id INT = 0 OUTPUT
	
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO dbo.tblPosition VALUES (@PositionName);	
	SELECT @id = SCOPE_IDENTITY();
END
GO
