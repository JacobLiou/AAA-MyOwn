CREATE TABLE person(
	id INT PRIMARY KEY,
	LastName VARCHAR(128),
	FirstName VARCHAR(128),
	Age INT,
	Address VARCHAR(255)
	);
	
	INSERT INTO person(id, LastName, FirstName, Age, Address, UpdateTime) VALUES(3, "mei", "Okay", 12, "bad", "2021-09-14 09:01");
	
	TRUNCATE TABLE person;
	
	DROP TABLE person;
	
	DELETE FROM person;
	
	SELECT * FROM person WHERE LastName LIKE "%m%";
	
	


	
	SELECT id , Age, UpdateTime FROM person WHERE id > 1 AND Age > 10 ORDER BY UpdateTime DESC;
	
	SELECT LastName FROM person;
		
	SELECT DISTINCT LastName FROM person;
	
	UPDATE person SET LastName = "New", FirstName = "Haha" WHERE id = 4
	
	DELETE FROM person WHERE id = 3

CREATE TABLE Persons
(
Id_P int,
LastName varchar(255),
FirstName varchar(255),
Address varchar(255),
City varchar(255)
);	

INSERT INTO Persons VALUES (1, 'Gates', 'Bill', 'Xuanwumen 10', 'Beijing');
INSERT INTO Persons VALUES (2, 'Adams', 'John', 'Oxford Street', 'London');
INSERT INTO Persons VALUES (3, 'Bush', 'George', 'Fifth Avenue', 'New York');
INSERT INTO Persons VALUES (4, 'Carter', 'Thomas', 'Changan Street', 'Beijing');
INSERT INTO Persons VALUES (5, 'Carter', 'William', 'Xuanwumen 10', 'Beijing');
select * from persons;

	
CREATE TABLE Persons_b
(
	Id_P int,
	LastName varchar(255),
	FirstName varchar(255),
	Address varchar(255),
	City varchar(255)
);
INSERT INTO Persons_b VALUES (1, 'Bill', 'Gates', 'Xuanwumen 10', 'Londo');
INSERT INTO Persons_b VALUES (2, 'John', 'Adams', 'Oxford Street', 'nBeijing');
INSERT INTO Persons_b VALUES (3, 'George', 'Bush', 'Fifth Avenue', 'Beijing');
INSERT INTO Persons_b VALUES (4, 'Thomas', 'Carter', 'Changan Street', 'New York');
INSERT INTO Persons_b VALUES (5, 'William', 'Carter', 'Xuanwumen 10', 'Beijing');
select * from persons_b;


create table orders (id_o INTEGER ,orderno INTEGER,id_p INTEGER);
insert into orders values(1,11111,1);
insert into orders values(2,22222,2);
insert into orders values(3,33333,3);
insert into orders values(4,44444,4);
insert into orders values(6,66666,6);
select * from orders;


//学习高级Select  UNION JOIN 
SELECT * FROM persons p, orders o WHERE p.id_p = o.id_p; 
	
SELECT p.LastName, o.OrderNo FROM persons p INNER JOIN orders o ON p.id_p = o.id_p;

///UNION 操作符用于合并两个或多个 SELECT 语句的结果集。
SELECT * FROM persons p UNION SELECT * FROM orders o;

//union适合分表的情况
SELECT * FROM persons p UNION SELECT * FROM persons_b pb;

CREATE VIEW persons_beijing AS SELECT * FROM persons WHERE address = "beijing";
SELECT * FROM persons_beijing;
INSERT INTO Persons VALUES (8, 'Carter', 'William', 'Beijing', 'Beijing');
SELECT * FROM persons_beijing;

//修改视图
CREATE OR REPLACE VIEW persons_beijing AS select * from persons where lastname='Gates';
SELECT * FROM persons_beijing;

SELECT AVG(age) FROM person;
select avg(orderno) from orders;

SELECT COUNT(*) FROM person;

SELECT * FROM person WHERE age = (SELECT MAX(age) FROM person);



SELECT SUM(orderNo) FROM orders;

SELECT SUM(id) FROM person;