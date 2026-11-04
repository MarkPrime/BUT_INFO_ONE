TP1 - Prise en main
RÉPONSES


Exercice 1 : Obtenir des informations du système
------------------------------------------------

1. Quelle est la commande pour consulter les pages de manuel de la commande man 
man man

2. Consultez les pages de manuel des commandes whoami, id, who, finger et w.

man whoami
man id
man who
man finger
man w

3. Peut-on, via la commande finger, avoir des informations sur l'identité d'un utilisateur d'une machine distante ? Si oui, quelle est la syntaxe ?
Réponse : Oui : finger user@host  (ou finger @host)

4. Quel est votre groupe principal (numéro et nom) ? À quels autres groupes appartenez-vous ? Quelle(s) commande(s) utiliser ?
Réponse :
id
id -g    (numéro du groupe principal)
id -gn   (nom du groupe principal)
id -G    (numéros de tous les groupes)
id -Gn   (noms de tous les groupes)


Exercice 2 : Obtenir des informations sur la machine et le système
------------------------------------------------------------------

1. Regardez le résultat de la commande uname.
Réponse : uname  ->  Linux

2. Consultez le manuel de cette commande.
Réponse : man uname

3. Quelle est l'option qui donne accès à toutes les informations ?
Réponse : uname -a

4. Avec quelle option pouvez-vous avoir la release du noyau ?
Réponse : uname -r

5. Quelle est l'option qui vous permet de connaître le système d'exploitation ?
Réponse : uname -o


Exercice 3 : Commandes de base
------------------------------

1. Écrivez sur une même ligne (séparées par ;) les commandes pour répondre à : qui suis-je ? où suis-je ?
Réponse : whoami ; pwd

2. Quelle est l'identité de l'interpréteur (shell) ? Essayez echo SHELL, puis echo $SHELL.
Réponse :
echo SHELL    ->  affiche le mot SHELL
echo $SHELL   ->  affiche le shell de connexion (ex. /bin/bash)


Exercice 4 : Auto-complétion
----------------------------

1. Tapez ls /u puis [Tab]. Que se passe-t-il ?
Réponse : Le shell complète en ls /usr

2. Essayez cd /b puis [Tab]. Que se passe-t-il ?
Réponse : Rien (plusieurs possibilités).

3. Appuyez une deuxième fois sur [Tab]. Que se passe-t-il ?
Réponse : Le shell affiche les possibilités : bin, boot

4. Quelle commande donne des informations sur l'architecture cpu ? (commence par ls)
Réponse : lscpu

5. Quelle est la commande pour trouver l'emplacement d'une commande ? (commence par wh)
Réponse : which  (ou whereis)

6. Quel est le chemin d'accès de la commande ls ?
Réponse : which ls  (ou whereis ls)


Exercice 5 : Connexion à distance et manipulation de répertoires et fichiers
----------------------------------------------------------------------------

1. Connectez-vous sur le serveur sterne.iutrs.unistra.fr avec ssh.
Réponse : ssh votre_login@sterne.iutrs.unistra.fr

2. Créez un répertoire s11 directement sous votre répertoire d'accueil.
Réponse : mkdir s11

3. Téléchargez le fichier maximes dans ce répertoire.
Réponse : Depuis Moodle -> S11 -> Ressources_TP1

4. Vérifiez que le fichier maximes est présent.
Réponse : cd s11 ; ls

5. Affichez le contenu de maximes à l'aide de cat puis more (ou less).
Réponse :
cat maximes
more maximes
less maximes

6. Que remarquez-vous avec la commande more ?
Réponse : Affichage page par page avec « --More-- » et le pourcentage lu. Entrée : ligne suivante, Espace : page suivante, q : quitter.

7. Affichez le contenu de maximes à l'envers avec la commande tac.
Réponse : tac maximes

8. On suppose que le dossier courant est s11 (sinon, faites le nécessaire).
Réponse : cd ~/s11

9. Essayez de supprimer s11 : rmdir s11. Pourquoi la commande échoue-t-elle ?
Réponse : On est déjà dans s11 : il n'y a pas de sous-répertoire s11 ici (No such file or directory).

10. Essayez la même commande depuis votre répertoire d'accueil. Pourquoi échoue-t-elle ?
Réponse : s11 n'est pas vide (Directory not empty).

11. Déplacez maximes de s11 vers votre home. Vérifiez.
Réponse :
mv s11/maximes ~
cd ; ls maximes

12. Quittez sterne, puis connectez-vous avec ssh sur un autre serveur.
Réponse :
exit
ssh votre_login@phoenix.iutrs.unistra.fr

13. Observez les contenus de vos répertoires courant et s11. Que constatez-vous ?
Réponse : ls -l
On retrouve les mêmes fichiers : le répertoire personnel est partagé entre les serveurs.

14. Sortez de la session distante.
Réponse : exit  (ou Ctrl+D)


Exercice 6 : Gestion de fichiers et de répertoires
--------------------------------------------------

Avant de commencer :
mkdir -p ~/s11/tp1-ex6 && cd ~/s11/tp1-ex6

1. Créer trois fichiers fic1, fic2 et fic3 contenant respectivement vos nom et prénom, votre login, et la date du jour.
Réponse :
echo "Prénom NOM" > fic1
whoami > fic2
date +%d/%m/%Y > fic3

2. Renommer fic1 en nom et fic2 en nom_login.
Réponse : mv fic1 nom ; mv fic2 nom_login

3. Copier fic3 dans le répertoire courant sous le nom aujourdhui.
Réponse : cp fic3 aujourdhui

4. Créer un sous-répertoire Corbeille et un sous-répertoire Copie.
Réponse : mkdir Corbeille Copie

5. Déplacer fic3 dans Corbeille.
Réponse : mv fic3 Corbeille

6. Copier nom et nom_login dans Corbeille.
Réponse : cp nom nom_login Corbeille

7. Copier tous les fichiers ordinaires du répertoire courant dans Copie.
Réponse : cp nom nom_login aujourdhui Copie

8. Afficher le contenu de Corbeille.
Réponse : ls -l Corbeille

9. Détruire les fichiers contenus dans Corbeille.
Réponse : rm Corbeille/*

10. Détruire le répertoire Corbeille.
Réponse : rmdir Corbeille


Exercice 7 : Gestion de fichiers et de répertoires (bis)
--------------------------------------------------------

1. Créer un répertoire exo4.
Réponse : mkdir exo4

2. Se placer dans exo4.
Réponse : cd exo4

3. Créer cinq fichiers a, b, c, d et e au contenu quelconque.
Réponse :
echo abc > a
echo def > b
echo ghi > c
echo jkl > d
echo mno > e

4. Créer deux sous-répertoires voyelle et temp.
Réponse : mkdir voyelle temp

5. Se placer dans voyelle.
Réponse : cd voyelle

6. Déplacer dans voyelle tous les fichiers de exo4 dont le nom est une voyelle.
Réponse : mv ../[aeiouyAEIOUY] .

7. Sans changer de répertoire, copier tous les fichiers de voyelle dans temp.
Réponse : cp ./* ../temp/

8. Se placer dans exo4.
Réponse : cd ..

9. Renommer temp en tout.
Réponse : mv temp tout

10. Sans changer de répertoire, déplacer dans tout tous les fichiers (et seulement les fichiers) de exo4.
Réponse : mv b c d tout/
(solution générale : find . -maxdepth 1 -type f -exec mv {} ./tout \;)





