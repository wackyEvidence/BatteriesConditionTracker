create procedure spLastReplacementStatusesUpdate_Update()
as $$
begin
	update LastReplacementStatusesUpdate set last_update_date = current_date; 
end; 
$$ language plpgsql; 