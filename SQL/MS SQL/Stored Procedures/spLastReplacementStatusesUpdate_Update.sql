CREATE PROCEDURE spLastReplacementStatusesUpdate_Update
AS 
BEGIN
	UPDATE dbo.LastReplacementStatusesUpdate SET last_update_date = (GETDATE()); 
END; 