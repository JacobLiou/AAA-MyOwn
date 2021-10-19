create table dbo.command(
	id integer not null primary key,
	name varchar(120),
	serial integer,
	ismainconn bool,
	contents varchar(1024),
	resultmatch varchar(1024),
	callcount integer,
	classification integer,
	CONSTRAINT FK_command_classification FOREIGN KEY (classification)
    REFERENCES dbo.classification (id)
);