create procedure spBatteryModelPhotos_Insert(inout p_id int, p_model_id int, p_file_name text)
as $$ 
begin 
	insert into BatteryModelPhotos (model_id, file_name) values (p_model_id, p_file_name)
	returning id into p_id;
end; 
$$ language plpgsql; 