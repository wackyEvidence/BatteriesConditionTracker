create procedure spBatteryModelPhotos_Delete(entry_id integer)
as $$ 
begin 
	delete from BatteryModelPhotos where id = entry_id;
end; 
$$ language plpgsql; 