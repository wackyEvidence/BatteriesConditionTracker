create table BatterySubsystems
(
	id int primary key identity, 
	name nvarchar(50) not null, 
	unique(name)
)	

create table BatteryReplacementStatuses
(
	id int primary key identity, 
	name nvarchar(50) not null, 
	unique(name)
)

create table BatteryExploitationStatuses
(
	id int primary key identity, 
	name nvarchar(50) not null 
	unique(name)
)

create table BatteryClampTypes
(
	id int primary key identity, 
	name nvarchar(50) not null 
	unique(name)
)

create table BatteryTechnologies
(
	id int primary key identity, 
	name nvarchar(50) not null,
	unique(name)
)

create table StructureTypes 
(
	id int primary key identity, 
	name nvarchar(50) not null, 
	unique(name)
)

create table Structures 
(
	id int primary key identity, 
	name nvarchar(100) not null, 
	type_id int foreign key references StructureTypes(id)
)

create table Positions 
(
	id int primary key identity, 
	name nvarchar(50) not null, 
	unique(name)
)
drop table Users 
create table Users
(
	id int primary key identity, 
	name nvarchar(100) not null, 
	surname nvarchar(100) not null, 
	patronymic nvarchar(100), 
	phone_number nvarchar(16), 
	email nvarchar(200) not null, 
	position_id int foreign key references Positions(id) on delete set null,
	password text not null, 
	is_admin bit not null, 
	unique(email, phone_number)
)

create table BatteryModels
(
	id int primary key identity,
	name nvarchar(100) not null, 
	brand nvarchar(50) not null, 
	capacity float not null check(capacity > 0), 
	voltage float not null check(voltage > 0), 
	length float not null check (length > 0), 
	height float not null check (height > 0), 
	width float not null check (width > 0), 
	technology_id int foreign key references BatteryTechnologies(id) on delete set null, 
	clamp_type_id int foreign key references BatteryClampTypes(id) on delete set null,
	cost money not null check (cost > 0),
	buffer_mode_service_time float not null check (buffer_mode_service_time > 0), 
	soh_threshold int not null check (soh_threshold > 0)
)
drop table ConcreteBatteries 
create table ConcreteBatteries 
(
	id int primary key identity, 
	model_id int foreign key references BatteryModels(id) on delete cascade, 
	exploitation_start date default getdate(), 
	exploitation_end date,
	structure_id int foreign key references Structures(id) on delete set null,
	subsystem_id int foreign key references BatterySubsystems(id) on delete set null,
	responsible_employee_id int foreign key references Users(id) on delete set null,
	exploitation_status_id int foreign key references BatteryExploitationStatuses(id) on delete set null,
	replacement_status_id int foreign key references BatteryReplacementStatuses(id) on delete set null,
	additional_notes text, 
	last_capacity_measure_date date	null
)

drop table BatterySoHMeasures
create table BatterySoHMeasures
(
	id int primary key identity, 
	battery_id int foreign key references ConcreteBatteries(id) on delete cascade not null , 
	performing_employee_id int foreign key references Users(id) on delete set null, 
	measure_date date not null default getdate(),
	soh float not null check(soh > 0)
)

drop table BatteryModelPhotos 
create table BatteryModelPhotos 
(
	id int primary key identity, 
	model_id int foreign key references BatteryModels(id) on delete cascade not null, 
	file_path text not null 
)

drop table ConcreteBatteryPhotos 
create table ConcreteBatteryPhotos 
(
	id int primary key identity, 
	battery_id int foreign key references ConcreteBatteries(id) on delete cascade not null, 
	file_path text not null 
)