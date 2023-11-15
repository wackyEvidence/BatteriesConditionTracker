create procedure spStructureTypes_Delete(
	p_id integer
)
as $$ 
begin 
	delete from StructureTypes where id = p_id; 
end; 
$$ language plpgsql; 