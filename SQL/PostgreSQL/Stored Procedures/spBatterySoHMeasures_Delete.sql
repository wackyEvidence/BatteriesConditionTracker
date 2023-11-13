create procedure spBatterySoHMeasures_Delete(
	p_id int
)
as $$ 
begin 
	delete from BatterySoHMeasures where id = p_id;
end; 
$$ language plpgsql; 