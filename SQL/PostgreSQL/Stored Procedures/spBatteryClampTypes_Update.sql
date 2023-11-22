create procedure spBatteryClampTypes_Update(p_id integer, p_name varchar(50))
as $$ 
begin 
	update BatteryClampTypes set name = p_name 
	where id = p_id; 
end; 
$$ language plpgsql; 