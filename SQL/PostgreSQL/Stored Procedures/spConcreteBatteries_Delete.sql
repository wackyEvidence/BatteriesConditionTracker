create procedure spConcreteBatteries_Delete(
	p_id integer
)
as $$ 
begin 
	delete from ConcreteBatteries where id = p_id; 
end; 
$$ language plpgsql; 