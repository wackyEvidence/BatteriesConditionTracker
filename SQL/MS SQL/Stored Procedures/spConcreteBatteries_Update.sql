CREATE PROCEDURE spConcreteBatteries_Update
	@Id INT,
	@ModelId INT, 
	@ExploitationStart DATE, 
	@ExploitationEnd DATE, 
	@StructureId INT, 
	@SubsystemId INT, 
	@ResponsibleEmployeeId INT, 
	@ExploitationStatusId INT, 
	@ReplacementStatusId INT, 
	@AdditionalNotes TEXT
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE ConcreteBatteries 
	SET 
	model_id = @ModelId, exploitation_start = @ExploitationStart, exploitation_end = @ExploitationEnd, 
	structure_id = @StructureId, subsystem_id = @SubsystemId, responsible_employee_id = @ResponsibleEmployeeId, 
	exploitation_status_id = @ExploitationStatusId, replacement_status_id =  @ReplacementStatusId, 
	additional_notes = @AdditionalNotes
	WHERE id = @Id; 
END