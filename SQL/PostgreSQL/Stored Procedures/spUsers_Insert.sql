create or replace procedure spUsers_Insert(
	inout p_id integer, 
	p_name varchar(100), 
	p_surname varchar(100), 
	p_patronymic varchar(100), 
	p_phone_number varchar(16),
	p_email varchar(200), 
	p_position_id int, 
	p_password text, 
	p_is_admin boolean
)
as $$ 
begin 
	insert into Users (name, surname, patronymic, phone_number, email, position_id, password, is_admin) 
	values (p_name, p_surname, p_patronymic, p_phone_number, p_email, p_position_id, p_password, p_is_admin) 
	returning id into p_id; 
end; 
$$ language plpgsql; 