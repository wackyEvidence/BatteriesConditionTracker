create or replace function BatteryTechnologies_GetAll()
	returns table (id int, name varchar(50))
as $$
begin 
	return query 
	select * from BatteryTechnologies;
end;
$$ language plpgsql;