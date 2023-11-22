create procedure spBatteryModels_Update(
	p_id integer, 
	p_brand varchar(50), 
	p_capacity double precision, 
	p_voltage double precision, 
	p_length int,
	p_height int, 
	p_width int, 
	p_technology_id int, 
	p_clamp_type_id int, 
	p_cost numeric,
	p_buffer_mode_service_time double precision, 
	p_soh_threshold int, 
	p_name varchar(50)
)
as $$ 
begin 
	update BatteryModels 
	set 
	brand = p_brand, capacity = p_capacity, voltage = p_voltage, length = p_length, height = p_height, width = p_width, 
	technology_id = p_technology_id, clamp_type_id = p_clamp_type_id, cost = p_cost, 
	buffer_mode_service_time = p_buffer_mode_service_time, soh_threshold = p_soh_threshold, name = p_name
	where id = p_id;
end; 
$$ language plpgsql