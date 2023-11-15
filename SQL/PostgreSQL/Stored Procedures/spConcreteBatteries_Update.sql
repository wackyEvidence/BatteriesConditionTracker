create procedure spConcreteBatteries_Update(
	p_id integer, 
	p_model_id int, 
	p_exploitation_start date, 
	p_exploitation_end date, 
	p_structure_id int,
	p_subsystem_id int, 
	p_responsible_employee_id int, 
	p_exploitation_status_id int, 
	p_replacement_status_id int, 
	p_additional_notes text,
	p_last_capacity_measure_date date
)
as $$ 
begin 
	update ConcreteBatteries
	set 
	model_id = p_model_id, exploitation_start = p_exploitation_start, exploitation_end = p_exploitation_end, 
	structure_id = p_structure_id, subsystem_id = p_subsystem_id, responsible_employee_id = p_responsible_employee_id, 
	replacement_status_id = p_replacement_status_id, additional_notes = p_additional_notes, 
	last_capacity_measure_date = p_last_capacity_measure_date
	where id = p_id;
end; 
$$ language plpgsql; 