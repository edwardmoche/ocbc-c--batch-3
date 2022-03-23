create database db_bank

use db_bank

create table customer(
customerNumber int primary key,
customerName varchar (50),
contactLastName varchar (50),
contactFirstName varchar (50),
phone int,
addressLine1 varchar (200),
addressLine2 varchar (200),
city varchar (50),
state varchar (50),
postalCode int,
country varchar (50),
salesRepEmployeeNumber int,
creditLimit varchar (50)
)
select * from customer

create table products(
productCode int primary key,
productName varchar (50),
productLine varchar (50),
productScale varchar (50),
productVendor varchar (50),
productDescription varchar (200),
quantitiyInStock int,
buyPrice int,
MSRP int
)

select * from products

create table productlines(
productLine varchar (50) primary key,
textDescription varchar (50),
htmlDescription varchar (50),
image varchar (20)
)

create table orders(
orderNumber int primary key,
orderDate date,
requiredDate date,
shippedDate date,
status varchar (20),
comments varchar (200),
customerNumber int
)

create table orderdetails(
orderNumber int primary key,
productCode varchar (50),
quantityOrdered int,
priceEach int,
orderLineNumber int identity (1,1)
)

alter table orderdetails
alter column productCode int;
alter table orderdetails
add foreign key (productCode) references products(productCode);

create table payments(
customerNumber int foreign key references customer(customerNumber),
checkNumber int primary key identity (1,1),
paymentDate date,
amount int
)

create table employee(
employeeNumber int primary key identity (1,1),
lastName varchar (20),
firstName varchar (20),
extension varchar (20),
email varchar (50),
officeCode varchar (20),
reportsTo varchar (20),
jobTitle varchar (20)
)

create table office(
officeCode varchar (20),
city varchar (20),
phone int,
addressLine1 varchar (50),
addressLine2 varchar (50),
state varchar (20),
country varchar (20),
postalCode int,
territory varchar (20)
)

alter table customer
alter column phone varchar (50);

insert into customer (customerNumber, customerName, contactLastName, contactFirstName, phone, addressLine1, addressLine2,
 city, state, postalCode, country, salesRepEmployeeNumber, creditLimit)values
('0001','Dani Cahyadi','Cahyadi','Dani','082115337120','maju', 'mundur', 'jakarta','DKI Jakarta', '12135', 'Indonesia', '4312', '2000000'),
('0002','Rudi Bernard','Bernard','Rudi','082512367620','pegangsaan', 'timur', 'jakarta','DKI Jakarta', '12335', 'Indonesia', '4322', '4000000'),
('0003','Rani Rismawati','Rismawati','Rani','082115677520','jalan', 'lari', 'jakarta','DKI Jakarta', '15135', 'Indonesia', '4362', '6000000')
;

alter table products
alter column buyPrice varchar (50);
alter table products
alter column MSRP varchar (50);

insert into products (productCode,productName,productLine,productScale,productVendor,productDescription,quantitiyInStock,buyPrice,MSRP)values
('0001','Nissan Juke','Juke','200x100','Nissan','Mobil nissan SUV', '7', '2000000000','1900000000'),
('0002','Toyota Avanza','Avanza','100x50','Toyota','Mobil keluarga', '20', '1120000000','1100000000'),
('0003','Nissan Livina','Livna','400x150','Nissan','Minibuss keluarga', '4', '3500000000','3000000000')
;

insert into Productlines (productLine,textDescription,htmlDescription,image)values
('Juke','SUV','nissan.com','juke.jpg'),
('Avanza','Family car','toyota.com','avanza.jpg'),
('Livina','Minivan','nissan.com','livina.jpg')
;

insert into Orders (orderNumber,orderDate,requiredDate,shippedDate,status,comments,customerNumber)values
('0001','2017','2019','2018','sudah diterima','Kendaraan sudah diterima customer','0003'),
('0002','2018','2019','2018','sudah diterima','Kendaraan sudah diterima customer','0001'),
('0003','2017','2020','2017','diperjalanan','Kendaraan anda sedang dalam perjalanan','0002')
;

alter table orderdetails
alter column priceEach varchar (50);
insert into orderdetails (orderNumber,productCode,quantityOrdered,priceEach)values
('0001','0001','1','2000000000'),
('0002','0002','3','1120000000'),
('0003','0003','1','3500000000')
;
select * from orderdetails

alter table payments
alter column amount varchar (50);
insert into payments (customerNumber,paymentDate,amount)values
('0001','2018','1120000000'),
('0002','2017','3500000000'),
('0003','2017','2000000000')
;

insert into employee (lastName,firstName,extension,email,officeCode,reportsTo,jobTitle)values
('Jaelani','Armand','S,Ti.','armja@gmail.com','0002','Marketing','Sales'),
('Kent','Farhan','S,Ps.','fant@gmail.com','0001','Head HR','HR'),
('Izazi','Rudy','S,Kom.','armja@gmail.com','0003','User','IT')
;


alter table office
alter column phone varchar (50);
insert into office (officeCode,city,phone,addressLine1,addressLine2,state,country,postalCode,territory)values
('0001','Jakarta','02163221542','Jalan','Raya','Jakarta','Indonesia','12412','Jakarta'),
('0002','Depok','02163221542','Raya','Raya','Jawa','Indonesia','16413','Jawa Barat'),
('0003','Jakarta','02163221542','Jalan','Jalan','Jakarta','Indonesia','12412','Jakarta')
;