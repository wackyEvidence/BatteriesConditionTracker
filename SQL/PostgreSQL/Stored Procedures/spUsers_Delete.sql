create procedure spUsers_Delete(
	p_id integer
)
as $$ 
begin 
	delete from Users where id = p_id; 
end; 
$$ language plpgsql; 