a. Buat Database baru dengan nama staff

create database db_staff

b. Buat Table data_staff dengan desain spt dibawah ini :
nik		| int
nama		| varchar(50)
alamat  	| varchar(200)
handphone	| varchar(15)

use db_staff
create table tb_staff(
nik int primary key,
nama varchar (50),
alamat varchar (200),
handphone varchar (15)
)

c. Masukkan data ke dalam table data_staff sesuai dengan table diatas 

insert into tb_staff (nik, nama, alamat, handphone) values
('0001','Dadang','Bekasi','082213134156'),
('0002','Ahmad','Pitara','082115124156');

d. Masukkan lebih dari 1 data ke dalam table data masih dalam table diatas.

insert into tb_staff (nik, nama, alamat, handphone) values
('0003','Yanto','Medan','082112135156'),
('0004','Beni','Jakarta','082141124156'),
('0006','Rani','Ponorogo','082514135156'),
('0007','Sinta','Pekanbaru','082164135156'),
('0008','Cahyadi','Bandung','082114175156'),
('0009','Bagito','Jakarta','082114131156')
;

e. Tambahkan kolom baru pada table data_staff yaitu joindate sekaligus masukan 1 data kedalam table 
data_staff

alter table tb_staff add joindate date;
insert into tb_staff (nik, nama, alamat, handphone, joindate) values
('0010','Sutejo','Malang','082114631456','2018');

F. Tampilkan 2 data SQL kalian sekarang 

select top 2 * from tb_staff

G. Tampilkan 3 data SQL kalian sekarang 

select top 3 * from tb_staff

H. Buat Table baru staffoutsource dengan isi yang sama seperti data_staff


create table tb_staffoutsource(
nik int primary key,
nama varchar (50),
alamat varchar (200),
handphone varchar (15),
joindate date
)

I. Masukkan 10 data baru ke table staffoutsource

insert into tb_staffoutsource (nik, nama, alamat, handphone, joindate) values
('0001','Dadang','Bekasi','082213134156','2017'),
('0003','Yanto','Medan','082112135156','2018'),
('0004','Beni','Jakarta','082141124156','2018'),
('0007','Sinta','Pekanbaru','082164135156','2019'),
('0009','Bagito','Jakarta','082114131156','2019'),
('0011','Rahman','Batam','082114131156','2020'),
('0012','Andik','Maluku','082114131156','2021'),
('0013','Maria','Ternate','082114131156','2021'),
('0014','Santoso','Bali','082114131156','2021'),
('0015','Supardi','Sumedang','082114131156','2021')
;

J. Tampilkan data pada 2 Table yang sudah kalian buat dengan joindate yang sama

select * from tb_staff 
join tb_staffoutsource 
on tb_staff.nama=tb_staffoutsource.nama
;

K. Tampilkan seluruh data sebelah kanan yang sama pada table staff_outsource

select * from tb_staff
right join tb_staffoutsource
on tb_staff.joindate = tb_staffoutsource.joindate;

L. Tampilkan seluruh data staff sebelah kiri yang punya nilai tidak sama akan bernilai null

select * from tb_staff
left join tb_staffoutsource
on tb_staff.joindate = tb_staffoutsource.joindate;

M. Tampilkan seluruh data antara 2 tabel baik itu tidak punya kesamaan dan bernilai null.

select * from tb_staff a
full join tb_staffoutsource b
on a.joindate = b.joindate;