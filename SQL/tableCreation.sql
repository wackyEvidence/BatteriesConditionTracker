CREATE TABLE tblStructureType
(
	id INT PRIMARY KEY IDENTITY, 
	name NVARCHAR(50) NOT NULL
)

CREATE TABLE tblBatterySubsystem
(
	id INT PRIMARY KEY IDENTITY, 
	name NVARCHAR(50) NOT NULL 
)

CREATE TABLE tblBatteryReplacementStatus
(
	id INT PRIMARY KEY IDENTITY, 
	name NVARCHAR(50) NOT NULL 
)

CREATE TABLE tblBatteryExploitationStatus
(
	id INT PRIMARY KEY IDENTITY, 
	name NVARCHAR(50) NOT NULL 
)

CREATE TABLE tblBatteryClampType
(
	id INT PRIMARY KEY IDENTITY, 
	name NVARCHAR(50) NOT NULL 
)

CREATE TABLE tblBatteryTechnology
(
	id INT PRIMARY KEY IDENTITY, 
	name NVARCHAR(50) NOT NULL 
)

CREATE TABLE tblStructure
(
	id INT PRIMARY KEY IDENTITY, 
	name NVARCHAR(100) NOT NULL, 
	type INT FOREIGN KEY REFERENCES tblStructureType(id) 
)

CREATE TABLE tblPosition
(
	id INT PRIMARY KEY IDENTITY, 
	name NVARCHAR(50) NOT NULL, 
)

CREATE TABLE tblUser
(
	-- хранить уровень доступа? в доп табл access level
	id INT PRIMARY KEY IDENTITY, 
	name NVARCHAR(50) NOT NULL, 
	surname NVARCHAR(50) NOT NULL, 
	patronymic NVARCHAR(50) NOT NULL, 
	phone_number NVARCHAR(16) NOT NULL, 
	email NVARCHAR(50) NOT NULL, 
	position INT FOREIGN KEY REFERENCES tblPosition(id) ON DELETE SET NULL,
	supervisor INT FOREIGN KEY REFERENCES tblUser(id) ON DELETE SET NULL, 
	login NVARCHAR(50) NOT NULL, 
	password NVARCHAR(50) NOT NULL, 
	is_admin BIT NOT NULL 
)

CREATE TABLE tblBattery
(
	id INT PRIMARY KEY IDENTITY, 
	brand NVARCHAR(50) NOT NULL, 
	capacity DOUBLE NOT NULL, 
	voltage DOUBLE NOT NULL, 
	polarity INT FOREIGN KEY REFERENCES tblBatteryPolarity(id) ON DELETE SET NULL,
	height DOUBLE NOT NULL, 
	length DOUBLE NOT NULL, 
	width DOUBLE NOT NULL, 
	technology INT FOREIGN KEY REFERENCES tblBatteryTechnology(id) ON DELETE SET NULL, 
	clamp_type INT FOREIGN KEY REFERENCES tblBatteryClampType(id) ON DELETE SET NULL, 
	exploitation_start DATETIME, 
	exploitation_end DATETIME, 
	structure INT FOREIGN KEY REFERENCES tblStructures(id) ON DELETE SET NULL, 
	cost DECIMAL NOT NULL, 
	planned_replacement_date DATETIME NOT NULL, 
	manufacture_date DATETIME, 
	installation_location TEXT,  
	responsible_employee INT FOREIGN KEY REFERENCES tblUser(id) ON DELETE SET NULL, 
	status INT FOREIGN KEY REFERENCES tblBatteryStatus(id) ON DELETE SET NULL, 
	system INT FOREIGN KEY REFERENCES tblBatterySystem(id) ON DELETE SET NULL, 
	replacement_status INT FOREIGN KEY REFERENCES tblBatteryReplacementStatus(id) ON DELETE SET NULL
)

CREATE TABLE tblBatteryCapacityMeasure
(
	id INT PRIMARY KEY IDENTITY, 
	battery_id INT FOREIGN KEY REFERENCES tblBattery(id), 
	performing_employee INT FOREIGN KEY REFERENCES tblUser(id), 

)