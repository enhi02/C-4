create database passmon
use passmon

create table Product(
ID  int identity primary key,
Name varchar(250) not null,
Price money not null,
Quantity int not null ,
Status bit not null
);

select * from Product