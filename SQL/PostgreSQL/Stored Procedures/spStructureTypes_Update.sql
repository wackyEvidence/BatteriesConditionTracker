create procedure spStructureTypes_Update(
	p_id integer, 
	p_name varchar(50)
)
as $$ 
begin 
	update StructureTypes set name = p_name where id = p_id; 
end; 
$$ language plpgsql; 