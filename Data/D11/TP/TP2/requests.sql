exercice 1
select depart, lower(substr(depart, 1, 3)) as "Depart"  from iin_vols;

exercice 2
select depart, upper(substr(depart, 1, 3)) as "Depart" from iin_vols;

exercice 3 : Afficher les codes de vols pour les vols dont le lieu de départ commence par 'L', triés par lieu de départ ascendant et numéro de vol descendant.
select upper(substr(depart, 1, 3)) || substr(nvol, 1, 3) as "Codes de vols" 
from iin_vols 
where upper(depart) LIKE 'L%' 
order by depart asc, nvol desc;

exercice 4 : Afficher les trajets sous la forme "Vols de <lieu de départ> à <lieu d'arrivée>".
select distinct 'Vols de ' || depart || ' a ' || arrivee as "Trajets" 
from iin_vols;

exercice 5 : Afficher les numéros de vols et les lieux de départ pour les vols dont le type davion est Airbus triés par lieu de départ ascendant et numéro de vol ascendant.
select nvol, depart 
from iin_vols 
where navion in (select navion from iin_avions where initcap(type) = 'Airbus') 
order by depart asc, nvol asc;

exercice 6 : Afficher les numéros de vols pour les vols dont le lieu de départ est le même que celui du vol numéro 108.
select nvol 
from iin_vols 
where depart in (select depart from iin_vols where nvol = 108);

exercice 7
select ename as "Nom", round(sal * 0.853479, 0) as "Salaire", 
nvl(round(comm * 0.853479, 0), 0) as "Commision", 
round(sal * 0.853479 + nvl(comm, 0) * 0.853479, 2) as "Revenu mensuel", 
round(((sal) * 12)* 0.853479, 0) as "Revenu annuel" 
from emp;



