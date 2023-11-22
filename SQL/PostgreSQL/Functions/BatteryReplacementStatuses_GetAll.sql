create function BatteryReplacementStatutes_GetAll()
	returns table(Id int, Name varchar(50)) 
as $$
begin 
	return query
	select * from BatteryReplacementStatuses; 
end;
$$ language plpgsql;
