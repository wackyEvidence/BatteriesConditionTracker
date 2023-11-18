create procedure spBatteryClampTypes_Insert(inout p_id integer, p_name varchar(50))
as $$ 
begin 
	insert into BatteryClampTypes (name) values (p_name)
	returning id into p_id;
end; 
$$ language plpgsql; 