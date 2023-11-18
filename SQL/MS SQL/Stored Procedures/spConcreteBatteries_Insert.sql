CREATE PROCEDURE spConcreteBatteries_Insert 
	@ModelId INT, 
	@ExploitationStart DATE, 
	@ExploitationEnd DATE, 
	@StructureId INT, 
	@SubsystemId INT, 
	@ResponsibleEmployeeId INT, 
	@ExploitationStatusId INT, 
	@ReplacementStatusId INT, 
	@AdditionalNotes TEXT,
	@Id INT = 0 OUTPUT 
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO ConcreteBatteries 
	VALUES (@ModelId, @ExploitationStart, @ExploitationEnd, @StructureId, @SubsystemId, 
	@ResponsibleEmployeeId, @ExploitationStatusId, @ReplacementStatusId, @AdditionalNotes, NULL); 
	SELECT @Id = SCOPE_IDENTITY(); 
END