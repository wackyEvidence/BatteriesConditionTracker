create table BatterySubsystems --created 
(
	id serial primary key, 
	name varchar(50) not null,
	unique(name)
)

create table BatteryReplacementStatuses --created
(
	id serial primary key, 
	name varchar(50) not null, 
	unique(name)
)

create table BatteryExploitationStatuses --created 
(
	id serial primary key, 
	name varchar(50) not null, 
	unique(name)
)

create table BatteryClampTypes --created
(
	id serial primary key, 
	name varchar(50) not null, 
	unique(name)
)

create table BatteryTechnologies --created
(
	id serial primary key, 
	name varchar(50) not null, 
	unique(name)
)

create table StructureTypes --created
(
	id serial primary key, 
	name varchar(50) not null, 
	unique(name)
)

create table Structures --created 
(
	id serial primary key, 
	name varchar(100) not null, 
	type_id int,
	foreign key (type_id) references StructureTypes(id) on delete set null,
	unique(name)
)

create table Positions --created
(
	id serial primary key, 
	name varchar(50) not null, 
	unique(name)
)

create table Users --created 
(
	id serial primary key, 
	name varchar(100) not null, 
	surname varchar(100) not null, 
	patronymic varchar(100), 
	phone_number varchar(16), 
	email varchar(200), 
	position_id int,
	supervisor_id int null,
	login varchar(100) not null, 
	password text not null, 
	is_admin boolean not null, 
	foreign key (position_id) references Positions(id) on delete set null, 
	foreign key (supervisor_id) references Users(id),
	unique(login, email, phone_number)
)
drop table BatteryModels
create table BatteryModels
(
	id serial primary key, 
	brand varchar(50) not null, 
	capacity real not null check(capacity > 0), 
	voltage real not null check(voltage > 0), 
	length integer not null check (length > 0), 
	height integer not null check (height > 0), 
	width integer not null check (width > 0), 
	technology_id int, 
	clamp_type_id int,
	cost money not null check (cost::numeric::int > 0),
	buffer_mode_service_time real not null check (buffer_mode_service_time > 0), 
	soh_threshold int not null check (soh_threshold > 0), 
	foreign key (technology_id) references BatteryTechnologies(id) on delete set null,
	foreign key (clamp_type_id) references BatteryClampTypes(id) on delete set null
)
drop table ConcreteBatteries
create table ConcreteBatteries 
(
	id serial primary key, 
	model_id int, 
	exploitation_start date default current_date, 
	exploitation_end date,
	structure_id int, 
	subsystem_id int,
	responsible_employee_id int, 
	exploitation_status_id int, 
	replacement_status_id int, 
	additional_notes text, 
	last_capacity_measure_date date	null, 
	foreign key (model_id) references BatteryModels(id) on delete cascade,
	foreign key (structure_id) references Structures(id) on delete set null, 
	foreign key (subsystem_id) references BatterySubsystems(id) on delete set null, 
	foreign key (responsible_employee_id) references Users(id) on delete set null,
	foreign key (exploitation_status_id) references BatteryExploitationStatuses(id) on delete set null,
	foreign key (replacement_status_id) references BatteryReplacementStatuses(id) on delete set null
)

drop table BatterySoHMeasures
create table BatterySoHMeasures
(
	id serial primary key, 
	battery_id int not null, 
	performing_employee_id int, 
	measure_date date not null default current_date,
	soh float not null check(soh > 0), 
	foreign key (battery_id) references ConcreteBatteries(id) on delete cascade,
	foreign key (performing_employee_id) references Users(id) on delete set null
)

create table BatteryModelPhotos
(
	id serial primary key, 
	model_id int not null, 
	file_path text not null, 
	foreign key (model_id) references BatteryModels(id) on delete cascade
)

create table ConcreteBatteryPhotos 
(
	id serial primary key, 
	battery_id int not null, 
	file_path text not null, 
	foreign key (battery_id) references ConcreteBatteries(id) on delete cascade
)





