Create table CricketerDetails
(
CricketerId bigint primary key identity(1,1),
CricketerName nvarchar(50) not null,
TotalODI bigint not null, 
TotalScore bigint not null,
Fifties bigint not null,
Hundreds bigint not null,
LocationId bigint not null 
)


select * from CricketerDetails
DROP table CricketerDetails


--TO INSERT
go
Create PROCEDURE
InsertSP(
@CricketerName nvarchar(50), @TotalODI bigint,@TotalScore bigint ,@Fifties bigint,@Hundreds bigint,@LocationId bigint)
as
begin
Insert into CricketerDetails values(@CricketerName, @TotalODI, @TotalScore, @Fifties, @Hundreds,@LocationId)
end
exec InsertSP 'Rohit',262,10709,55,31,4
exec InsertSP 'Virat',268,12789,55,50,2
exec InsertSP 'Dhoni',280,9788,45,20,1


select * from CricketerDetails


--TO UPDATE
go
create procedure UpdateSP(
@CricketerId bigint ,@CricketerName nvarchar(50), @TotalODI bigint,@TotalScore bigint ,@Fifties bigint,@Hundreds bigint,@LocationId bigint)
as
begin
Update CricketerDetails set CricketerName=@CricketerName, TotalODI=@TotalODI, TotalScore=@TotalScore, Fifties=@Fifties,Hundreds=@Hundreds ,LocationId=@LocationId
where CricketerId=@CricketerId
end
exec UpdateSP 3,'dhoni',290,9876,30,21,4

select * from CricketerDetails

--TO READ
go
create procedure ReadSP
as
begin
select * from CricketerDetails
end
exec ReadSP


--TO READ BY NUMBER
go
create procedure ReadSPById(@CricketerId bigint)
as
begin
select * from CricketerDetails where CricketerId=@CricketerId
end
exec ReadSPById 2

--TO DELETE
go
create procedure DeleteSP(@CricketerId bigint)
as
begin
delete CricketerDetails  where CricketerId=@CricketerId
end
exec DeleteSP 3


Create Table Location
(
 LocationId bigint primary key identity(1,1),
 LocationName nvarchar(60) not null
)

select * from location
go 
create procedure
InsertLocation
(@LocationName nvarchar(60))
as
begin
insert into Location values (@LocationName)
end

exec InsertLocation 'Chennai'
exec InsertLocation 'Bangalore'
exec InsertLocation 'Kolkata'
exec InsertLocation 'Mumbai'
exec InsertLocation 'Hyderabad'

select * from Registration
truncate table registration
go 
create procedure
InsertRegister
(@Username nvarchar(max),@Password nvarchar(max))
as
begin
insert into Registration values (@Username,@Password)
end
exec InsertRegister 'madhan','1234'
