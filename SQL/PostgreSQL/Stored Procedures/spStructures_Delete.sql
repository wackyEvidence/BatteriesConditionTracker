create procedure spStructures_Delete(
	inout p_id integer, 
	p_name varchar(50), 
	p_type_id int
)
as $$ 
begin 
	delete from Structures
	where id = p_id; 
end; 
$$ language plpgsql; 