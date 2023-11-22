create procedure spPositions_Update(p_id integer, p_name varchar(50))
as $$ 
begin 
	update Positions set name = p_name 
	where id = p_id; 
end; 
$$ language plpgsql; 