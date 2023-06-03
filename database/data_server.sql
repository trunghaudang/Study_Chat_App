set dateformat dmy
create database data_server
use data_server

create table users
(
	userid int,
	username varchar(10),
	email varchar(20),
	birth smalldatetime,
	password_user varchar(2000),
	primary key (userid)
)

create table room
(
	room_id int,
	room_name varchar(20),
	room_join tinyint,
	room_day smalldatetime,
	userid int,
	primary key (room_id)
)

alter table room add constraint userid foreign key (userid) references users(userid)

INSERT INTO users VALUES('113','quan','quanlatoi@gmail.com','12/03/2003', 'b10a8db164e0754105b7a99be72e3fe5')
select * from users
ALTER TABLE users ALTER COLUMN password_user VARCHAR(100);
