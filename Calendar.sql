create database Calendar;
go

use Calendar;

create table [User] (
	Id int primary key,
	[Name] nvarchar(255) not null
);

create table Appointment (
	Id int primary key,
	UserId int not null,
	MeetingDate date not null,
	StartHour time not null,
	EndHour time not null,
	AppointmentName nvarchar(255) not null,
	[Type] INT NOT NULL, -- 1 = Group, 2 = Single
	foreign key (UserId) references [User](Id)
);

create table Reminder (
	Id int primary key,
	AppointmentId int not null,
	UserId int not null,
	ReminderTime datetime not null,
	foreign key (AppointmentId) references Appointment(Id),
	foreign key (UserId) references [User](Id)
);