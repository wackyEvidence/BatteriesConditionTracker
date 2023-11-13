create procedure spPositions_Delete(position_id integer)
as $$ 
begin 
	delete from Positions where id = position_id; 
end; 
$$ language plpgsql; 