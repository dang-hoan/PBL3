USE [PBL3]
CREATE TABLE POSITION(
	PositionID char(10) primary key not null,
	Position nvarchar(50) not null
)

CREATE TABLE PEOPLE(
	Username char(20) primary key not null,
	Name nvarchar(50) not null,
	Gender bit,
	BirthDay datetime,
	Address nvarchar(100),
	IDCard char(12) not null,
	Email varchar(50),
	Phone char(11) not null,
	PositionID char(10) foreign key (PositionID) references POSITION
)

CREATE TABLE LOGIN(
	IDlogin char(10) primary key not null,
	Username char(20) not null foreign key (Username) references PEOPLE,
	PassWord varchar(12) not null
)

CREATE TABLE SCHEDULE(
	ScheduleID char(10) primary key not null,
	Departure nvarchar(50) not null,
	Destination nvarchar(50) not null,
	DepartureTime datetime not null,
    ArrivalTime datetime not null
)

CREATE TABLE STATION(
	StationID char(10) primary key not null,
	StationName nvarchar(50) not null,
	Address nvarchar(100) not null,
	State nvarchar(50)
)

CREATE TABLE TRAIN(
	TrainID char(10) primary key not null,
	TrainName nvarchar(50) not null,
	NumberOfCarriages int not null,
	DriverUN char(20) foreign key (DriverUN) references PEOPLE,
	ScheduleID char(10) foreign key (ScheduleID) references SCHEDULE
)

CREATE TABLE TICKET(
	TicketID char(10) primary key not null,
	TrainID char(10) not null foreign key (TrainID) references TRAIN,	
	SeatNo varchar(10) not null,
	TicketPrice money not null,
	Booked bit,	
	CustomerUN char(20) foreign key (CustomerUN) references PEOPLE
)

CREATE TABLE TICKET_MANAGER(
	TicketManagerID char(10) primary key not null,
	TrainID char(10) not null foreign key (TrainID) references TRAIN,	
	TotalTickets int not null,
	BookedTickets int not null,
)




