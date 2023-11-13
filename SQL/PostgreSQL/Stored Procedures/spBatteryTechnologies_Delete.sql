create procedure spBatteryTechnologies_Delete(
	p_id int
)
as $$ 
begin 
	delete from BatteryTechnologies where id = p_id; 
end; 
$$ language plpgsql; 