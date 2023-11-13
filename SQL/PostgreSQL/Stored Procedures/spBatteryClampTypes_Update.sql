create procedure spBatteryClampTypes_Update(clamp_type_id integer, clamp_type_name varchar(50))
as $$ 
begin 
	update BatteryClampTypes set name = clamp_type_name 
	where id = position_id; 
end; 
$$ language plpgsql; 