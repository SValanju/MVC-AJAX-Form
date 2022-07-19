use DcodeTech;

create table UserDetails(
ID int identity primary key,
UserName varchar(50) not null,
UserMobile varchar(10) not null,
UserEmail varchar(50) not null,
FormName varchar(10) not null
)

select * from UserDetails;
