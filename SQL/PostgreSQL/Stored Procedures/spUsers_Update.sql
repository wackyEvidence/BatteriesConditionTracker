create or replace procedure spUsers_Update(
	p_id integer, 
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
	update Users set 
	name = p_name, surname = p_surname, patronymic = p_patronymic, phone_number = p_phone_number, email = p_email,
	position_id = p_position_id, password = p_password, is_admin = p_is_admin 
	where id = p_id; 
end; 
$$ language plpgsql; 