create procedure spBatteryClampTypes_Insert(inout clamp_type_id integer, clamp_type_name varchar(50))
as $$ 
begin 
	insert into BatteryClampTypes (name) values (clamp_type_name)
	returning id into clamp_type_id;
end; 
$$ language plpgsql; 