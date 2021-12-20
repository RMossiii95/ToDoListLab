-- create database ToDo;

-- create table Employee(
-- 	Id int Primary Key auto_increment not null,
--     `Name` nvarchar(30),
--     HoursAvailable float,
--     Title nvarchar(40)
-- );

-- create table Todo(
-- 	Id int Primary Key auto_increment not null,
-- 	`Name` nvarchar(30),
--     HoursNeeded float,
--     IsCompleted bool
-- );

-- create table Assignments(
-- 	Id int Primary Key auto_increment not null,
--     EmployeeId int,
--     ToDoId int,
--     foreign key (EmployeeId) references Employee(Id),
--     foreign key (ToDoId) references ToDo(Id)
-- );
-- insert into todo values(0, 'Mow Lawn', false, 1.5);

-- insert into employee
-- values(0, 'Sleezy Pete', 20, 'President of Acquisition'),
-- (0, 'Hank Hill', 10, 'Propane Salesman');

-- select * from assignments;