create or replace function BatteryClampTypes_GetAll()
	returns table (id int, name varchar(50))
as $$
begin 
	return query 
	select * from BatteryClampTypes;
end;
$$ language plpgsql;