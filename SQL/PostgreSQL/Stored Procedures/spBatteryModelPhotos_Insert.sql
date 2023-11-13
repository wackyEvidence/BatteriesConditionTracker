create procedure spBatteryModelPhotos_Insert(inout entry_id integer, battery_model_id int, photo_file_name text)
as $$ 
begin 
	insert into BatteryModelPhotos (model_id, file_name) values (battery_model_id, photo_file_name)
	returning id into entry_id;
end; 
$$ language plpgsql; 