CREATE TABLE tblBatterySubsystem -- создана 
(
	id INT PRIMARY KEY IDENTITY, 
	name NVARCHAR(50) NOT NULL 
)

CREATE TABLE tblBatteryReplacementStatus -- создана
(
	id INT PRIMARY KEY IDENTITY, 
	name NVARCHAR(50) NOT NULL 
)

CREATE TABLE tblBatteryExploitationStatus -- создана 
(
	id INT PRIMARY KEY IDENTITY, 
	name NVARCHAR(50) NOT NULL 
)

CREATE TABLE tblBatteryClampType -- создана
(
	id INT PRIMARY KEY IDENTITY, 
	name NVARCHAR(50) NOT NULL 
)

CREATE TABLE tblBatteryTechnology -- создана
(
	id INT PRIMARY KEY IDENTITY, 
	name NVARCHAR(50) NOT NULL 
)

CREATE TABLE tblStructure -- создана
(
	id INT PRIMARY KEY IDENTITY, 
	name NVARCHAR(100) NOT NULL, 
	type INT FOREIGN KEY REFERENCES tblStructureType(id) 
)

CREATE TABLE tblStructureType -- cоздана 
(
	id INT PRIMARY KEY IDENTITY, 
	name NVARCHAR(50) NOT NULL
)

CREATE TABLE tblPosition -- создана
(
	id INT PRIMARY KEY IDENTITY, 
	name NVARCHAR(50) NOT NULL, 
)

CREATE TABLE tblUser -- создана 
(
	id INT PRIMARY KEY IDENTITY, 
	name NVARCHAR(100) NOT NULL, 
	surname NVARCHAR(100) NOT NULL, 
	patronymic NVARCHAR(100), 
	phone_number NVARCHAR(16), 
	email NVARCHAR(200) NOT NULL, 
	position_id INT FOREIGN KEY REFERENCES tblPosition(id) ON DELETE SET NULL,
	supervisor_id INT FOREIGN KEY REFERENCES tblUser(id), 
	login NVARCHAR(100) NOT NULL, 
	password NVARCHAR(500) NOT NULL, 
	is_admin BIT NOT NULL 
)

ALTER TABLE tblConcreteBattery
ADD last_capacity_measure_date DATE

CREATE TABLE tblConcreteBattery
(
	id INT PRIMARY KEY IDENTITY, 
	model_id INT FOREIGN KEY REFERENCES tblBatteryModel(id) ON DELETE SET NULL, 
	exploitation_start DATE, 
	exploitation_end DATE,
	structure INT FOREIGN KEY REFERENCES tblStructure(id) ON DELETE SET NULL, 
	subsystem INT FOREIGN KEY REFERENCES tblBatterySubsystem(id) ON DELETE SET NULL, 
	manufacture_date DATE, 
	responsible_employee INT FOREIGN KEY REFERENCES tblUser(id) ON DELETE SET NULL, 
	exploitation_status INT FOREIGN KEY REFERENCES tblBatteryExploitationStatus(id) ON DELETE SET NULL, 
	replacement_status INT FOREIGN KEY REFERENCES tblBatteryReplacementStatus(id) ON DELETE SET NULL, 
	additional_notes TEXT
)

CREATE TABLE tblBatteryModel
(
	id INT PRIMARY KEY IDENTITY, 
	brand NVARCHAR(50) NOT NULL, 
	capacity FLOAT NOT NULL, 
	voltage FLOAT NOT NULL, 
	length FLOAT NOT NULL, 
	height FLOAT NOT NULL, 
	width FLOAT NOT NULL, 
	technology_id INT FOREIGN KEY REFERENCES tblBatteryTechnology(id) ON DELETE SET NULL, 
	clamp_type INT FOREIGN KEY REFERENCES tblBatteryClampType(id) ON DELETE SET NULL, 
	buffer_mode_service_time INT NOT NULL, 
	cycle_mode_service_time INT, 
	cost MONEY NOT NULL, 
)

CREATE TABLE tblBatteryCapacityMeasure
(
	id INT PRIMARY KEY IDENTITY, 
	battery_id INT FOREIGN KEY REFERENCES tblConcreteBattery(id) NULL, 
	performing_employee INT FOREIGN KEY REFERENCES tblUser(id) NOT NULL, 
	measured_capacity FLOAT NOT NULL
)

CREATE TABLE tblBatteryModelPhotos
(
	id INT PRIMARY KEY IDENTITY, 
	model_id INT FOREIGN KEY REFERENCES tblBatteryModel(id) NOT NULL, 
	file_path TEXT NOT NULL 
)

CREATE TABLE tblConcreteBatteryPhotos
(
	id INT PRIMARY KEY IDENTITY, 
	battery_id INT FOREIGN KEY REFERENCES tblConcreteBattery(id) NOT NULL, 
	file_path TEXT NOT NULL 
)