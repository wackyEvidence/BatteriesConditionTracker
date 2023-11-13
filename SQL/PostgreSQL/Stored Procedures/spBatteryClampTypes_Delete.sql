create procedure spBatteryClampTypes_Delete(clamp_type_id integer)
as $$ 
begin 
	delete from BatteryClampTypes where id = clamp_type_id; 
end; 
$$ language plpgsql; 