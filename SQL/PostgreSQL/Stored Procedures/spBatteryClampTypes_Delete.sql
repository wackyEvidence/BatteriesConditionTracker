create or replace procedure spBatteryClampTypes_Delete(p_id integer)
as $$ 
begin 
	delete from BatteryClampTypes where id = p_id; 
end; 
$$ language plpgsql;