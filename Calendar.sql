create database Calendar;

use Calendar;

create table [User] (
	Id int identity(0, 1) primary key,
	[Name] nvarchar(255) not null,
	Email nvarchar(255) not null UNIQUE
);

create table Appointment (
	Id int identity(0, 1) primary key,
	StartTime datetime not null,
	EndTime datetime not null,
	[Name] nvarchar(255) not null,
	[Location] NVARCHAR(255) not null,
	[Type] BIT NOT NULL, -- 1 = Single, 0 = Group
);

create table Participant (
	Id int identity(0, 1) primary key,
	UserId int not null references [User](Id),
	AppointmentId int not null references Appointment(Id)
)

create table Reminder (
	Id int identity(0, 1) primary key,
	AppointmentId int not null,
	UserId int not null,
	ReminderTime datetime not null,
	foreign key (AppointmentId) references Appointment(Id),
	foreign key (UserId) references [User](Id)
);
