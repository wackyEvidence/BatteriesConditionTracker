create procedure spStructures_Update(
	p_id integer, 
	p_name varchar(50), 
	p_type_id int
)
as $$ 
begin 
	update Structures set name = p_name, type_id = p_type_id 
	where id = p_id; 
end; 
$$ language plpgsql; 