create procedure spBatterySubsystems_Delete(
	p_id int
)
as $$ 
begin 
	delete from BatterySubsystems where id = p_id; 
end; 
$$ language plpgsql; 