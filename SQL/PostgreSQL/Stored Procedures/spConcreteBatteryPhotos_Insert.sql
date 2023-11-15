create procedure spConcreteBatteryPhotos_Insert(
	inout p_id integer, 
	p_battery_id int, 
	p_file_path text
)
as $$ 
begin 
	insert into ConcreteBatteryPhotos (battery_id, file_path) values (p_battery_id, p_file_path) 
	returning id into p_id; 
end; 
$$ language plpgsql; 