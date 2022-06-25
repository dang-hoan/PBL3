USE [PBL3]
CREATE TABLE POSITION(
	PositionID int NOT NULL identity(1,1) primary key,
	Position nvarchar(50) NOT NULL
)

CREATE TABLE PEOPLE(
	Username varchar(20) NOT NULL primary key,
	Name nvarchar(50) NOT NULL,
	Gender bit,
	BirthDay datetime,
	Address nvarchar(100),
	IDCard char(12) NOT NULL,
	Email varchar(50),
	Phone char(11) NOT NULL,
	PositionID int foreign key (PositionID) references POSITION
)

CREATE TABLE LOGIN(
	LoginID int NOT NULL identity(1,1) primary key,
	Username varchar(20) NOT NULL foreign key (Username) references PEOPLE,
	PassWord varchar(15) NOT NULL,
	State bit,
)

CREATE TABLE NOTICE(
	NoticeID int NOT NULL identity(1,1) primary key,
	Title nvarchar(MAX),
	Content nvarchar(MAX)
)

CREATE TABLE SCHEDULE(
	ScheduleID int NOT NULL identity(1,1) primary key,
	DepartureTime datetime NOT NULL,
    ArrivalTime datetime NOT NULL
)

CREATE TABLE STATION(
	StationID int NOT NULL identity(1,1) primary key,
	StationName nvarchar(50) NOT NULL,
	Address nvarchar(100) NOT NULL,
	State nvarchar(50)
)

CREATE TABLE SCHEDULE_STATION_DETAIL(
	KeyID int NOT NULL identity(1,1) primary key,
	ScheduleID int foreign key (ScheduleID) references SCHEDULE,
	StationID int foreign key (StationID) references STATION
)

CREATE TABLE TRAIN(
	TrainID int NOT NULL identity(1,1) primary key,
	TrainName nvarchar(50) NOT NULL,
	NumberOfCarriages int NOT NULL,
	BasicPrice money,
	State bit,
	DriverUN varchar(20) foreign key (DriverUN) references PEOPLE
)

CREATE TABLE TRIP(
	TripID int NOT NULL identity(1,1) primary key,
	ScheduleID int foreign key (ScheduleID) references SCHEDULE,
	TrainID int foreign key (TrainID) references TRAIN
)

CREATE TABLE TICKET(
	TicketID int NOT NULL identity(1,1) primary key,	
	SeatNo varchar(10) NOT NULL,
	TicketPrice money NOT NULL,
	Booked bit,	
	TrainID int NOT NULL foreign key (TrainID) references TRAIN,
	CustomerUN varchar(20) foreign key (CustomerUN) references PEOPLE
)

CREATE TABLE SECURITY(
	SecurityID int NOT NULL identity(1,1) primary key,
	Question nvarchar(50) NOT NULL,
	Answer nvarchar(50) NOT NULL,	
	OwnUN varchar(20) foreign key (OwnUN) references PEOPLE
)
