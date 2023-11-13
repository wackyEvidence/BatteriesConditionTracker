create procedure spBatteryClampTypes_Insert
	@Name nvarchar(50), 
	@Id int = 0 output 
as 
begin 
	set nocount on;
	insert into BatteryClampTypes values (@Name); 
	select @Id = SCOPE_IDENTITY(); 
end