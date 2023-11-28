create procedure spConcreteBatteries_UpdateReplacementStatuses()
as $$
begin 
	update ConcreteBatteries 
	set replacement_status_id = 1
	where DATE_PART('day', current_date::timestamp - exploitation_start::timestamp) > 
	(select buffer_mode_service_time * 365 from BatteryModels where id = ConcreteBatteries.model_id)
	and exploitation_status_id = 1;
end; 
$$ language plpgsql;