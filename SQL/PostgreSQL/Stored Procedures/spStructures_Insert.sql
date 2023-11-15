create procedure spStructures_Insert(
	inout p_id integer, 
	p_name varchar(50), 
	p_type_id int
)
as $$ 
begin 
	insert into Structures (name, type_id) values (p_name, p_type_id) 
	returning id into p_id; 
end; 
$$ language plpgsql; 