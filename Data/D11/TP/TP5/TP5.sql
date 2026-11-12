CREATE TABLE village (
    vilno number(2) NOT NULL, 
    nom varchar2(20) NOT NULL, 
    nbhutte number(3) NOT NULL, 
    chef number(3) NOT NULL ,

    CONSTRAINT VIL_PK PRIMARY KEY (vilno) 
);

CREATE TABLE gaulois (
    gauno number(3) NOT NULL, 
    nom varchar2(15) NOT NULL, 
    sexe varchar2(1), 
    metier varchar2(15), 
    vilno number(2) NOT NULL, 

    CONSTRAINT GAU_PK PRIMARY KEY (gauno), 
    CONSTRAINT CSEXE CHECK (upper(sexe) in ('F','M', NULL)), 
    CONSTRAINT VIL_EK FOREIGN KEY (vilno) REFERENCES village (vilno)
);

ALTER TABLE gaulois DROP CONSTRAINT VIL_EK;

INSERT INTO gaulois VALUES (114,'pascalix','M','forgeron',14);

INSERT INTO gaulois VALUES (SELECT * FROM agnes_braud.gaulois);
INSERT INTO village VALUES (SELECT * FROM agnes_braud.village);
ALTER TABLE village MODIFY chef number(3) null;

create table camps (
	campno number(2) NOT NULL, 
	nom varchar2(20) NOT NULL, 
	nbtente number(3), 
	nblegio number(4), 
	constraint pk_mescamps primary key (campno)
);

create table batailles (
	batno number(3) NOT NULL, 
	nom varchar2(20), 
	vilno number(2) NOT NULL, 
	campno number(2) NOT NULL, 
	datebat date, 
	duree number(3), 

	constraint pk_mesbatailles primary key (batno), 
	constraint fk_mesbatailles_vilno foreign key (vilno) references mesvillages, 
	constraint fk_mesbatailles_campno foreign key (campno) references mescamps
);

insert into mescamps values (5, 'Nanciorum', 70, 400);
insert into mesbatailles values (12, 'Vosgia', 14, 5, to_date('02/09/0090', 'dd/mm/yyyy'), 20);
insert into mescamps select * from agnes_braud.camp;
insert into mesbatailles select * from agnes_braud.bataille;