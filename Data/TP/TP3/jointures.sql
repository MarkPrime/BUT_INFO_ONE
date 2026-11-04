
BASE VOLS
Exarcice 1: trajets (ville de départ et darrivée), numéro davion et capacité. (AR, SQL 1, SQL2)
Select v.depart, v.arrivee, a.navion, a.capacite 
from iin_vols v inner join iin_avions a on v.navion = a.navion ;

Exarcice 2: Nom des pilotes (principaux) de lavion 8 (une solution avec jointure et une solution sans). (AR, SQL 1, SQL2)
Select p.nom 
from iin_pilotes p inner join iin_vols v on p.npilote = v.pilote where navion = 8 ;

Exarcice 3:Noms de tous les pilotes, et trajets quils sont amenés à faire (ville de départ et ville darrivée) en tant que pilote principal, sans redondance et classés par ordre alphabétique du nom du pilote, de la ville de départ puis de la ville darrivée. (AR (NB : sans le tri qui nexiste pas en AR), SQL 1, SQL2)
Select distinct p.nom, v.depart, v.arrivee 
from iin_pilotes p inner join iin_vols v on p.npilote = v.pilote order by p.nom, v.depart, v.arrivee ;  

Exarcice 4:Nom des pilotes et copilotes qui font ensemble un vol entre Paris et Nice (sans redondance) (de deux façons). (AR, SQL 1, SQL2)
Select distinct p1.nom, p2.nom 
from iin_pilotes p1 inner join iin_vols v on p1.npilote = v.pilote inner join iin_pilotes p2 on p2.npilote = v.copilote where upper(v.depart) = 'PARIS' and upper(v.arrivee) = 'NICE' ;

BASE EMPLOYES
Exercice 5: Noms, jobs et noms de département des employés travaillant à DALLAS. (AR, SQL 1, SQL2)
Select e.ename, e.job, d.dname 
from emp e inner join dept d on e.deptno = d.deptno where upper(d.loc) = 'DALLAS' ;

Exercice 6: Noms des départements et de leurs employés, classés dans lordre alphabétique des noms de départements et des noms demployés. (AR, SQL 1, SQL2)
Select d.dname, e.ename 
from emp e inner join dept d on e.deptno = d.deptno order by d.dname, e.ename ;

Exercice 7: Noms, salaires et noms de département des employés et de leurs managers, classés par noms de département des employés.
Select e1.ename, e1.sal, d1.dname, e2.ename, e2.sal, d2.dname 
from emp e1, dept d1, emp e2, dept d2 where e1.deptno = d1.deptno 
and e1.mgr = e2.empno 
and e2.deptno = d2.deptno 
order by e1.ename, d1.dname; 

Select e1.ename, e1.sal, d1.dname, e2.ename, e2.sal, d2.dname 
from emp e1 inner join dept d1 on e1.deptno = d1.deptno 
inner join emp e2 on e1.mgr = e2.empno 
inner join dept d2 on e2.deptno = d2.deptno 
order by e1.ename, d1.dname; 

Exercice 8 :Noms des employés ne travaillant pas dans le même département que leur manager.
Select e.ename 
from emp e inner join emp m on e.mgr = m.empno inner join dept dm on m.deptno = dm.deptno inner join dept de on e.deptno = de.deptno 
where dm.deptno != de.deptno;





