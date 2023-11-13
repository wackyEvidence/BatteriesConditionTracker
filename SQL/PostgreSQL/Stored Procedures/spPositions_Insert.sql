create procedure spPositions_Insert(position_name varchar(50), inout position_id integer)
as $$ 
begin 
	insert into Positions (name) values (position_name)
	returning id into position_id; 
end; 
$$ language plpgsql; 