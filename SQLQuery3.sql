create database gym;
use gym;
create table NewStaff
(
SID int NOT NULL IDENTITY(1,1) primary key,
Fname varchar(150) Not null,
Lname varchar(150) Not null,
Gender varchar(20) Not null,
Dob varchar(100) Not null,
Mobile varchar (50) Not null,
Email varchar(150),
JoinDate varchar(100) Not null,
State varchar(100) Not null,
City varchar(100) Not null,
);
Fname,Lname,Gender,Dob,Mobile,Email,JoinDate,State,City