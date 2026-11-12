CREATE TABLE VINS (
    numvin number(5) NOT NULL, 
    nom varchar2(20) NOT NULL, 
    millesime number(4) NOT NULL, 
    degres number(2), 

    CONSTRAINT VINS_PK PRIMARY KEY(numvin), 
    CONSTRAINT CMILLESIME CHECK (millesime BETWEEN 1950 AND 2005)
);

CREATE TABLE VITICULTEURS (
    numviti number(5) NOT NULL, 
    nom varchar2(20) NOT NULL, 
    prenom varchar2(20), 
    region number(2) NOT NULL, 

    CONSTRAINT VITI_PK PRIMARY KEY(numviti)
);

CREATE TABLE PRODUCTION (
    numvin number(5) NOT NULL, 
    codeviti number(5) NOT NULL, 
    qte varchar2(20) NOT NULL, 

    CONSTRAINT PRODUCTION_PK PRIMARY KEY(numvin, codeviti),
    CONSTRAINT PRODUCTION_FKNUMVIN FOREIGN KEY(numvin) 
    REFERENCES VINS (numvin) ,
    CONSTRAINT PRODUCTION_FKCODEVITI FOREIGN KEY(codeviti) 
    REFERENCES VITICULTEURS (numviti) 
);