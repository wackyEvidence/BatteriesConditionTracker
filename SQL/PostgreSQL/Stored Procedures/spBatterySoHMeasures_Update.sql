create procedure spBatterySoHMeasures_Update(
	p_id int, 
	p_battery_id int, 
	p_performing_employee_id int, 
	p_measure_date date, 
	p_soh int
)
as $$ 
begin 
	update BatterySoHMeasures
	set battery_id = p_battery_id, performing_employee_id = p_performing_employee_id, measure_date = p_measure_date, soh = p_soh
	where id = p_id; 
end; 
$$ language plpgsql; 