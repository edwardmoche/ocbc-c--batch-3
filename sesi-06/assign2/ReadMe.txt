assignment 2 : Buat sebuah Database Bank dan tentunya dokumentasi kan setiap query yang anda 
buat didalamnya dengan masukkan setiap record.

create database db_bank

use db_bank

1. Customers => stores data customer
create table customer(
customerNumber int primary key,
customerName varchar (50),
contactLastName varchar (50),
contactFirstName varchar (50),
phone varchar (50),
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

2. Products => stores daftar/list model product ( dalam hal ini bisa mobil/motor dll )
create table products(
productCode int primary key,
productName varchar (50),
productLine varchar (50),
productScale varchar (50),
productVendor varchar (50),
productDescription varchar (200),
quantitiyInStock int,
buyPrice varchar (50),
MSRP varchar (50)
)

select * from products

3. Productlines => stores daftar/list kategori product
create table productlines(
productLine varchar (50) primary key,
textDescription varchar (50),
htmlDescription varchar (50),
image varchar (20)
)

4. Orders => store Order Sales oleh customer
create table orders(
orderNumber int primary key,
orderDate date,
requiredDate date,
shippedDate date,
status varchar (20),
comments varchar (200),
customerNumber int
)

5. OrderDetails => store Item Order sales dalam setiap order sales
create table orderdetails(
orderNumber int primary key,
productCode varchar (50),
quantityOrdered int,
priceEach varchahr (50),
orderLineNumber int identity (1,1)
)

alter table orderdetails
alter column productCode int;
alter table orderdetails
add foreign key (productCode) references products(productCode);

6. Payments => store Pembayaran oleh customer sesuai dengan akun pembayaran
create table payments(
customerNumber int foreign key references customer(customerNumber),
checkNumber int primary key identity (1,1),
paymentDate date,
amount varchar (50)
)

7. Employee => store informasi karyawan dalam sebuah organisasi struktur
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

8. Offices => store data sales office
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