create procedure spBatterySoHMeasures_Insert(
	inout p_id int, 
	p_battery_id int, 
	p_performing_employee_id int, 
	p_measure_date date, 
	p_soh int
)
as $$ 
begin 
	insert into BatterySoHMeasures (battery_id, performing_employee_id, measure_date, soh)
	values (p_battery_id, p_performing_employee_id, p_measure_date, p_soh)
	returning id into p_id;
end; 
$$ language plpgsql; 