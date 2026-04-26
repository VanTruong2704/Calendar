create database Calendar;
go

use Calendar;

create table [User] (
	Id int identity(0, 1) primary key,
	[Name] nvarchar(255) not null,
	Email nvarchar(255) not null UNIQUE
);
go

create table Appointment (
	Id int identity(0, 1) primary key,
	UserId int not null,
	StartTime datetime not null,
	EndTime datetime not null,
	AppointmentName nvarchar(255) not null,
	[Location] NVARCHAR(255) not null,
	[Type] BIT NOT NULL, -- 1 = Single, 0 = Group
	foreign key (UserId) references [User](Id)
);
go
create table Reminder (
	Id int identity(0, 1) primary key,
	AppointmentId int not null,
	UserId int not null,
	ReminderTime datetime not null,
	foreign key (AppointmentId) references Appointment(Id),
	foreign key (UserId) references [User](Id)
);

drop table Reminder;
drop table Appointment;
drop table [User]

select * from [User]

select * from Appointment

select * from Reminder