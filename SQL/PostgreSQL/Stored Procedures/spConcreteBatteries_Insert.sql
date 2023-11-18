create procedure spConcreteBatteries_Insert(
	inout p_id integer, 
	p_model_id int, 
	p_exploitation_start date, 
	p_exploitation_end date, 
	p_structure_id int,
	p_subsystem_id int, 
	p_responsible_employee_id int, 
	p_exploitation_status_id int, 
	p_replacement_status_id int, 
	p_additional_notes text
)
as $$ 
begin 
	insert into ConcreteBatteries
	(model_id, exploitation_start, exploitation_end, structure_id, subsystem_id,
	 responsible_employee_id, replacement_status_id, additional_notes) 
	values 
	(p_model_id, p_exploitation_start, p_exploitation_end, p_structure_id, p_subsystem_id,
	 p_responsible_employee_id, p_replacement_status_id, p_additional_notes)
	returning id into p_id;
end; 
$$ language plpgsql; 