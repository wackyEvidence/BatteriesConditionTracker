create procedure spBatteryModels_Insert(
	inout p_id integer, 
	p_brand varchar(50), 
	p_capacity real, 
	p_voltage real, 
	p_length real,
	p_height real, 
	p_width real, 
	p_technology_id int, 
	p_clamp_type_id int, 
	p_cost money,
	p_buffer_mode_service_time real, 
	p_soh_threshold int, 
	p_name varchar(100)
)
as $$ 
begin 
	insert into BatteryModels 
	(brand, capacity, voltage, length, height, width, technology_id, clamp_type_id, cost, buffer_mode_service_time, soh_threshold, name) 
	values 
	(p_brand, p_capacity, p_voltage, p_length, p_height, p_width, p_technology_id, p_clamp_type_id, p_cost,p_buffer_mode_service_time, p_soh_threshold, p_name)
	returning id into p_id;
end; 
$$ language plpgsql; 