create procedure spConcreteBatteryPhotos_Delete(
	p_id integer
)
as $$ 
begin 
	delete from ConcreteBatteryPhotos where id = p_id; 
end; 
$$ language plpgsql; 