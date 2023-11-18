create procedure spPositions_Insert(p_name varchar(50), inout p_id integer)
as $$ 
begin 
	insert into Positions (name) values (p_name)
	returning id into p_id; 
end; 
$$ language plpgsql; 