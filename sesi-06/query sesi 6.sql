a
create database db_staff

b
use db_staff
create table tb_staff(
nik int primary key,
nama varchar (50),
alamat varchar (200),
handphone varchar (15)
)

c
insert into tb_staff (nik, nama, alamat, handphone) values
('0001','Dadang','Bekasi','082213134156'),
('0002','Ahmad','Pitara','082115124156');

d
insert into tb_staff (nik, nama, alamat, handphone) values
('0003','Yanto','Medan','082112135156'),
('0004','Beni','Jakarta','082141124156'),
('0006','Rani','Ponorogo','082514135156'),
('0007','Sinta','Pekanbaru','082164135156'),
('0008','Cahyadi','Bandung','082114175156'),
('0009','Bagito','Jakarta','082114131156')
;

e
alter table tb_staff add joindate date;
insert into tb_staff (nik, nama, alamat, handphone, joindate) values
('0010','Sutejo','Malang','082114631456','2018');

UPDATE tb_staff SET joindate = '2017' WHERE nik = '0001'
UPDATE tb_staff SET joindate = '2017' WHERE nik = '0002'
UPDATE tb_staff SET joindate = '2018' WHERE nik = '0003'
UPDATE tb_staff SET joindate = '2018' WHERE nik = '0004'
UPDATE tb_staff SET joindate = '2018' WHERE nik = '0005'
UPDATE tb_staff SET joindate = '2018' WHERE nik = '0006'
UPDATE tb_staff SET joindate = '2019' WHERE nik = '0007'
UPDATE tb_staff SET joindate = '2019' WHERE nik = '0008'
UPDATE tb_staff SET joindate = '2020' WHERE nik = '0009'
UPDATE tb_staff SET joindate = '2020' WHERE nik = '0010'

select * from tb_staff

f
select top 2 * from tb_staff

g
select top 3 * from tb_staff

h
create table tb_staffoutsource(
nik int primary key,
nama varchar (50),
alamat varchar (200),
handphone varchar (15),
joindate date
)
alter table tb_staffoutsource add joindate date;

i
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

select * from tb_staffoutsource

j
select * from tb_staff 
join tb_staffoutsource 
on tb_staff.nama=tb_staffoutsource.nama
;

k
select * from tb_staff
right join tb_staffoutsource
on tb_staff.joindate = tb_staffoutsource.joindate;

l
select * from tb_staff
left join tb_staffoutsource
on tb_staff.joindate = tb_staffoutsource.joindate;

m
select * from tb_staff a
full join tb_staffoutsource b
on a.joindate = b.joindate;
