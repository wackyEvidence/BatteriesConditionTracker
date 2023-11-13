create procedure spBatteryModels_Delete(
	p_id integer
)
as $$ 
begin 
	delete from BatteryModels where id = p_id;
end; 
$$ language plpgsql; 