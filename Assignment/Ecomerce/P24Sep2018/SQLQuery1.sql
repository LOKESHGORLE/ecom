create table ProductBrands( ID int primary key identity(1,1),
							Name nvarchar(20)
							)
create table ProductDetails (
							ID int identity(1,1),
							Name nvarchar(30),
							Brand int foreign key references ProductBrands(ID),
							Price float,
							ImageURL nvarchar(60),
							Descript nvarchar(300)
							)
insert into ProductBrands values('Nokia');
insert into ProductBrands values('Apple');
insert into ProductBrands values('Moto');
insert into ProductBrands values('Samsung');

alter table ProductBrands alter column Name nvarchar(30) not null


insert into ProductDetails values('Nokia Phone',1,1500,'Content/legendmob.jpg','agaegeggghethrthqbtqrtgbuirqwuy');
insert into ProductDetails values('Apple Phone',2,75000,'Content/iphone.jpg','agaegeggghethrthqbtqrtgbuirqwuy');
insert into ProductDetails values('Smart Watch',3,15000,'Content/watch.jpg','agaegeggghethrthqbtqrtgbuirqwuy');
insert into ProductDetails values('sam Tab',4,50000,'Content/tab.jpg','agaegeggghethrthqbtqrtgbuirqwuy');

 update ProductDetails set ImageURL='Content/watch.jpg' where ID=12;
 
 update ProductDetails set ImageURL='Content/iphone.jpg' where ID=13;
Content/watch.jpg
Content/iphone.jpg
select * from  ProductBrands;

select * from ProductDetails;
update ProductDetails set ImageURL=SUBSTRING(ImageURL,2,DATALENGTH(ImageURL));

select * from AspNetUserRoles;
select * from [dbo].[AspNetRoles]

select * from ProductDetails where id in ();



create or alter procedure PROC_InsertProduct (@pName nvarchar(30),
													@pPrice float,
													@pImageURL nvarchar(40),
													@pDescript nvarchar(50),
													@pStatus nvarchar(20) out) 
													 												
as
begin
insert into ProductDetails values (@pName,1,@pPrice,@pImageURL,@pDescript) 
set @pDescript='success';
end		

create or alter procedure Proc_UpdateProduct (@pName nvarchar(30),
													@pPrice float,
													@pImageURL nvarchar(40),
													@pDescript nvarchar(50),
													@pId int)
as
begin
Update ProductDetails set Name=@pName,
							Price=@pPrice,
							ImageURL=@pImageURL,
							Descript=@pDescript  where ID=@pId
end 
create or alter procedure Proc_DeleteProduct (@pId int)
as
begin
delete from ProductDetails where ID=@pId;
end

											