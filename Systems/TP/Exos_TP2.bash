TP2 - Arborescences, archives, et connexion distante
RÉPONSES


Exercice 1 : Mise en place d'une arborescence à partir d'une archive
--------------------------------------------------------------------

1. Téléchargez l'archive bbftp.tar.
Réponse : Depuis Moodle -> Ressources_TP2

2. Enregistrez-la dans le répertoire s11.
Réponse : Enregistrer dans ~/s11

3. Procédez à l'extraction de l'archive dans le dossier courant (s11).
Réponse : tar -xvf bbftp.tar

4. Vérifiez que l'arborescence est mise en place dans s11.
Réponse : ls -R  (ou tree BBFTP)


Exercice 2 : Notion de chemin d'accès (relatif, absolu)
-------------------------------------------------------

1. Vous êtes dans s11 et souhaitez aller à la FringeSection de Boston. Quelle commande ?
Réponse : cd BBFTP/Boston/FringeSection

2. Par quelle commande vérifier que vous êtes bien à Boston/FringeSection ?
Réponse : pwd

3. Listez le contenu de ce répertoire, avec les propriétés de ses objets et leur n° d'inode.
Réponse : ls -li

4. Quel est le chemin d'accès absolu du fichier jesse.pinkman ?
Réponse : /adhome/.../votreDossierHome/s11/BBFTP/Albuquerque/jesse.pinkman
(obtenu avec : realpath ~/s11/BBFTP/Albuquerque/jesse.pinkman)

5. Quel est le chemin d'accès relatif de jesse.pinkman par rapport à FringeSection ?
Réponse : ../../Albuquerque/jesse.pinkman

6. Combien d'années Walter Bishop a-t-il été interné ? Quelle commande permet d'obtenir cette information ?
Réponse : cat walter.bishop

7. Revenez dans votre répertoire d'accueil.
Réponse : cd ~  (ou cd)


Exercice 3 : Commandes de gestion des fichiers
----------------------------------------------

1. Allez dans s11/BBFTP et créez-y un dossier Phoenix.
Réponse : cd s11/BBFTP ; mkdir Phoenix

2. Déplacez-vous dans Phoenix et créez-y un lien symbolique, de même nom que l'original, vers laura.palmer (TwinPeaks). Comment vérifier que le lien fonctionne ?
Réponse :
cd Phoenix
ln -s ../Seattle/TwinPeaks/laura.palmer .
Vérification : cat laura.palmer  (ou ls -l laura.palmer)

3. Renommez ce lien en laure.palmier.
Réponse : mv laura.palmer laure.palmier

4. Déplacez-vous dans Seattle/TwinPeaks et transférez dale.cooper à Albuquerque.
Réponse :
cd ../Seattle/TwinPeaks
mv dale.cooper ../../Albuquerque

5. Renommez david.lynch en stephen.king et laura.palmer en marilyn.monroe.
Réponse : mv david.lynch stephen.king ; mv laura.palmer marilyn.monroe

Question annexe : le lien symbolique laure.palmier sous Phoenix fonctionne-t-il encore ?
Réponse : Non, le lien est cassé (sa cible laura.palmer nexiste plus).
Vérification : cat ../../Phoenix/laure.palmier

6. Remontez vers BBFTP et arrêtez-vous pendant 10 secondes.
Réponse : cd ../.. ; sleep 10

7. Copiez les fichiers de FringeSection dont le nom finit par .fbi à Albuquerque.
Réponse : cp Boston/FringeSection/*.fbi Albuquerque

8. Affichez en une seule commande les contenus des 2 fichiers synopsis et de mystery. Puis créez dans ~/s11 un fichier intrigues, résultat de cette concaténation.
Réponse :
cat Albuquerque/synopsis Boston/FringeSection/synopsis mystery
cat Albuquerque/synopsis Boston/FringeSection/synopsis mystery > ~/s11/intrigues

9. Quelle commande donne le nombre de mots et de lignes du fichier intrigues ?
wc -wl < ~/s11/intrigues

10. Combien de Ko « pèse » charlotte.tar ?
ls -lh charlotte.tar

11. Recherchez tous les fichiers dont le nom contient 'white' sous BBFTP. Redirigez le résultat vers un fichier blackandwhite (dans BBFTP).
find . -type f -name "*white*" > blackandwhite

12. Recherchez tous les répertoires dont le nom comporte 'in' sous BBFTP.
find . -type d -name '*in*'

13. Listez (avec ls) les fichiers sous FringeSection dont le nom :
Réponse : cd Boston/FringeSection
(a) comporte 'a' et 'i', dans cet ordre (non nécessairement consécutifs)
Réponse : ls -d *a*i*
(b) ne commence pas par 'o' ni 'a' ni 's'
Réponse : ls -d [!oas]*
(c) contient 2 'i' (au moins) et se termine par '.fbi'
Réponse : ls -d *i*i*.fbi
(d) comporte un '.' en 7e position et ne finit pas par 'i'
Réponse : ls -d ??????.*[!i]
Puis : cd -

14. Localisez les fichiers ordinaires sous BBFTP dont le nom contient 'p' et ne se termine pas par 'i' ni 's'.
find . -type f -name '*p*[!is]'

15. Supprimez le répertoire Phoenix et le lien laure.palmier qui sy trouve.
rm Phoenix/laure.palmier ; rmdir Phoenix

16. Supprimez les fichiers intrigues et blackandwhite.
rm ../intrigues blackandwhite

17. Réintégrez dale.cooper à TwinPeaks et supprimez les copies des agents du FBI à Albuquerque.
Réponse :
mv Albuquerque/dale.cooper Seattle/TwinPeaks
rm Albuquerque/*.fbi

18. Renommez stephen.king en david.lynch et marilyn.monroe en laura.palmer. Retournez dans votre répertoire daccueil.
Réponse :
mv Seattle/TwinPeaks/stephen.king Seattle/TwinPeaks/david.lynch
mv Seattle/TwinPeaks/marilyn.monroe Seattle/TwinPeaks/laura.palmer
cd ~


Exercice 4 : Gestion des archives et connexion distante
-------------------------------------------------------

A. Comprendre une archive TAR

1. Placez-vous dans le répertoire contenant charlotte.tar.
Réponse : cd ~/s11/BBFTP

2. Affichez la taille de cette archive.
Réponse : ls -lh charlotte.tar

3. Consultez son contenu sans l'extraire.
Réponse : tar -tvf charlotte.tar

4. Créez un répertoire verif_charlotte, puis extrayez l'archive dans ce répertoire.
Réponse :
mkdir verif_charlotte
tar -xvf charlotte.tar -C verif_charlotte

5. Vérifiez que les fichiers ont correctement été extraits.
Réponse : ls -R verif_charlotte

6. L'extraction a-t-elle supprimé le fichier charlotte.tar ?
Réponse : Non.

B. Comparer une archive TAR et une archive ZIP

7. Revenez dans votre répertoire d'accueil.
Réponse : cd ~

8. Créez une archive non compressée s11.tar contenant toute larborescence s11.
Réponse : tar -cvf s11.tar s11

9. Créez une archive compressée s11.zip contenant la même arborescence.
Réponse : zip -r s11.zip s11

10. Comparez la taille de s11.tar et de s11.zip.
Réponse : ls -lh s11.tar s11.zip
s11.zip est généralement plus petit (compressé).

11. Consultez le contenu des deux archives sans les extraire.
Réponse :
tar -tvf s11.tar
unzip -l s11.zip

12. Extrayez s11.tar dans verif_tar et s11.zip dans verif_zip.
Réponse :
mkdir verif_tar verif_zip
tar -xvf s11.tar -C verif_tar
unzip s11.zip -d verif_zip

13. Vérifiez les deux arborescences obtenues. Contiennent-elles la même chose ?
Réponse :
ls -R verif_tar
ls -R verif_zip
Oui.

14.
- s11.tar est-il une archive ?
Réponse : Oui.
- s11.zip est-il une archive ?
Réponse : Oui.
- Laquelle est compressée ?
Réponse : s11.zip
- Quelle est la différence entre archiver et compresser ?
Réponse : Archiver : réunir plusieurs fichiers et répertoires dans un seul fichier. Compresser : réduire la taille des données.

C. Connexion distante

15. Connectez-vous en ssh au serveur de destination, créez-y un dossier transfert, puis rapatriez-y l'arborescence BBFTP de votre serveur source avec scp.
Réponse :
ssh votre_login@serveur_destination
mkdir -p ~/transfert
scp -r votre_login@serveur_source:~/s11/BBFTP ~/transfert/

16. Copiez le fichier maximes avec scp vers le répertoire /tmp/votre_login d'un autre serveur Linux.
Réponse :
ssh votre_login@serveur_distant "mkdir -p /tmp/votre_login"
scp ~/maximes votre_login@serveur_distant:/tmp/votre_login/