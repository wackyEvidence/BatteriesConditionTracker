create procedure spPositions_Update(position_id integer, position_name varchar(50))
as $$ 
begin 
	update Positions set name = position_name 
	where id = position_id; 
end; 
$$ language plpgsql; 