TP3 - Gestion des droits, redirections, et tubes
RÉPONSES


Exercice 1 : redirections, cat, head, tail et tube
--------------------------------------------------

1. Créer le fichier tout.txt, concaténation de introduction.txt, developpement.txt et conclusion.txt.
Réponse : cat introduction.txt developpement.txt conclusion.txt > tout.txt

2. À partir de tout.txt, créer debut.txt (lignes 1 à 40) et milieu.txt (lignes 41 à 80).
Réponse :
head -n40 tout.txt > debut.txt
head -n80 tout.txt | tail -n40 > milieu.txt

3. Créer fin.txt en une seule commande à partir de developpement.txt et conclusion.txt (sans utiliser tout.txt).
Réponse : cat developpement.txt conclusion.txt | tail -n40 > fin.txt

4. Vérifiez votre travail : 40 lignes par fichier, et la reconstruction doit redonner tout.txt.
Réponse :
wc -l debut.txt milieu.txt fin.txt
cat debut.txt milieu.txt fin.txt > reconstitue.txt
diff tout.txt reconstitue.txt
(aucune sortie = fichiers identiques)


Exercice 2
----------

1. Déplacez-vous dans le répertoire Seattle.
Réponse : cd ~/s11/BBFTP/Seattle

2. Créez, avec des chemins relatifs, un lien symbolique excentrique pointant vers TwinPeaks/dale.cooper.
Réponse : ln -s TwinPeaks/dale.cooper excentrique

3. Vérifiez que le lien symbolique est correct.
Réponse : cat excentrique

4. Renommez dale.cooper en lee.cooper. Le lien excentrique est-il toujours opérationnel ? Expliquez.
Réponse :
mv TwinPeaks/dale.cooper TwinPeaks/lee.cooper
Non : le lien contient le chemin TwinPeaks/dale.cooper, qui n'existe plus.

5. Redonnez à lee.cooper son nom d'origine et supprimez le lien excentrique (en une seule commande).
Réponse : mv TwinPeaks/lee.cooper TwinPeaks/dale.cooper ; rm excentrique

6. Déplacez-vous dans TwinPeaks.
Réponse : cd TwinPeaks

7. Créez, avec des chemins relatifs, un lien symbolique excentrique, localisé sous Seattle, pointant vers dale.cooper.
Réponse : ln -s TwinPeaks/dale.cooper ../excentrique

8. Vérifiez que le lien est fonctionnel.
Réponse : cat ../excentrique

9. Toujours sous TwinPeaks, créez à Seattle un lien direct (hard link) de dale.cooper.
Réponse : ln dale.cooper ../agent_fbi

10. Vérifiez avec cat que le lien est correct.
Réponse :
cat ../agent_fbi
ls -li dale.cooper ../agent_fbi   (même n° d'inode)

11. Renommez dale.cooper en kyle.maclachlan et contrôlez si le lien direct fonctionne toujours.
Réponse :
mv dale.cooper kyle.maclachlan
cat ../agent_fbi
Oui, il fonctionne toujours.

12. Nettoyage : remettez l'arborescence dans son état initial.
Réponse :
mv kyle.maclachlan dale.cooper
rm ../excentrique ../agent_fbi


Exercice 3
----------

Déplacez-vous dans FringeSection et écrivez les commandes chmod pour obtenir avec ls -al :
drwxrw-r-x  .
drwxr--r--  ..
-rwxrwxrwx  olivia.fbi
-rwxr--r--  walter.bishop
-rwxrw-rw-  phillip.fbi
Réponse :
cd ../../Boston/FringeSection
chmod 765 . ; chmod 744 ..
chmod 777 olivia.fbi ; chmod 744 walter.bishop ; chmod 766 phillip.fbi

1. Un utilisateur autre (o) ne peut pas lister FringeSection alors qu'il a les droits r et x dessus. Pourquoi ?
Réponse : Il n'a pas le droit x sur le répertoire père Boston.

2. Donnez les droits à votre groupe pour pouvoir traverser FringeSection (symbolique et octal).
Réponse :
chmod g+x . ; chmod g+x ..
chmod 775 . ; chmod 754 ..

3. Un membre de votre groupe pourrait-il supprimer walter.bishop ? Pourquoi ?
Réponse : Oui : le groupe a les droits w et x sur FringeSection.

4. Un utilisateur autre (o) pourrait-il le faire ? Expliquez.
Réponse : Non : pas de droit w sur FringeSection.

5. Ajoutez au groupe la permission d'écriture sur Boston et ôtez-la sur FringeSection.
Réponse : chmod g+w .. ; chmod g-w .

6. Pouvez-vous copier phillip.fbi vers Boston sous le nom copie_phillip.fbi ? Pourquoi ? Et le groupe ? Et les autres ?
Réponse :
cp phillip.fbi ../copie_phillip.fbi
Propriétaire : oui (r sur phillip.fbi, w et x sur Boston).
Groupe : oui (mêmes raisons).
Autres : non (ni w ni x sur Boston).

7. Pouvez-vous déplacer phillip.fbi vers Boston ? Pourquoi ? Et le groupe ? Et les autres ?
Réponse :
mv phillip.fbi ..
Propriétaire : oui (w et x sur FringeSection et sur Boston).
Groupe : non (pas de w sur FringeSection).
Autres : non (pas de w sur FringeSection ni sur Boston).

8. Créez un lien physique de walter.bishop dans Boston sous le nom lpwalter.
Réponse : ln walter.bishop ../lpwalter

9. Vérifiez avec cat que le lien a été créé correctement.
Réponse : cat ../lpwalter

10. Supprimez le droit w du propriétaire sur walter.bishop.
Réponse : chmod u-w walter.bishop

11. Comparez les permissions de walter.bishop et lpwalter. Que constatez-vous ? Pourquoi ?
Réponse :
ls -li walter.bishop ../lpwalter
Permissions identiques : même n° d'inode (même fichier).

12. Remettez en place le droit w.
Réponse : chmod u+w walter.bishop

13. Créez un lien symbolique de walter.bishop dans Boston sous le nom lswalter.
Réponse : ln -s FringeSection/walter.bishop ../lswalter

14. Vérifiez avec cat que le lien est opérationnel.
Réponse : cat ../lswalter

15. Observez les droits d'accès de lswalter. Que remarquez-vous ?
Réponse :
ls -l ../lswalter
lrwxrwxrwx : ces droits ne contrôlent pas l'accès, ce sont ceux de la cible qui comptent.

16. Exécutez chmod u-r ../lswalter. Observez les permissions de lswalter, walter.bishop et lpwalter. Quel objet a réellement été modifié ?
Réponse :
chmod u-r ../lswalter
ls -l ../lswalter
ls -li walter.bishop ../lpwalter
C'est la cible walter.bishop qui a été modifiée (lswalter reste lrwxrwxrwx).

17. Quels fichiers ont réellement été impactés par la suppression du droit ?
Réponse : walter.bishop et lpwalter (même inode).

18. Remettez les fichiers et les permissions dans leur état initial (depuis FringeSection).
Réponse :
chmod u+r walter.bishop
rm ../lpwalter
rm ../lswalter
rm ../copie_phillip.fbi
mv ../phillip.fbi .
chmod 765 .
chmod 744 ..


Exercice 4 : Rappel des commandes de filtrage et tubes
------------------------------------------------------

Revenez dans BBFTP : cd ../..

1. Le nombre de lignes et de mots du fichier mystery.
Réponse : wc -lw < mystery

2. Les 5 dernières lignes du fichier synopsis sous Albuquerque.
Réponse : tail -n5 Albuquerque/synopsis

3. Les lignes 3 à 6 (incluses) de ce synopsis.
Réponse : head -n6 Albuquerque/synopsis | tail -n4

4. Les lignes du synopsis de FringeSection qui comportent le motif Walter.
Réponse : grep Walter Boston/FringeSection/synopsis

5. Même requête, avec en plus les n° des lignes.
Réponse : grep -n Walter Boston/FringeSection/synopsis

6. Le nombre de lignes, parmi les 5 premières du synopsis de FringeSection, qui contiennent Walter.
Réponse : head -n5 Boston/FringeSection/synopsis | grep -c Walter


Exercice 5 : grep et expressions régulières
-------------------------------------------

1. Obtenir la ligne contenant la chaîne "inode" dans list.txt.
Réponse : grep inode list.txt

2. Obtenir la ligne contenant "inode lis " dans list.txt.
Réponse : grep "inode lis " list.txt   (aucun résultat)

3. Rechercher la ligne contenant "inode list" dans tous les fichiers du répertoire courant.
Réponse : grep "inode list" *

4. Obtenir les lignes commençant par le mot "Call".
Réponse : grep '^Call' list.txt

5. Obtenir les lignes commençant par le mot " Reboot".
Réponse : grep '^ Reboot' list.txt

6. Obtenir les lignes finissant par le mot "today".
Réponse : grep 'today$' list.txt

7. Compter le nombre de lignes vides.
Réponse : grep -c '^$' list.txt

8. Afficher toutes les lignes contenant uniquement le mot "End".
Réponse : grep '^End$' list.txt

9. Obtenir les lignes contenant "reboot" ou "Reboot".
Réponse : grep '[Rr]eboot' list.txt

10. Afficher les lignes qui contiennent trois chiffres consécutifs.
Réponse : grep '[0-9][0-9][0-9]' list.txt

11. Afficher les lignes contenant quatre caractères ou plus.
Réponse : grep '....' list.txt

12. Afficher toutes les lignes non vides.
Réponse : grep '.' list.txt

13. Afficher les lignes qui contiennent un point.
Réponse : grep '\.' list.txt

14. Afficher les lignes qui contiennent "Oop", "Oops", "Oopss", etc.
Réponse : grep 'Oops*' list.txt

15. Afficher les lignes qui contiennent "Oops", "Oopss", etc.
Réponse : grep 'Oopss*' list.txt

16. Afficher les lignes qui contiennent deux chiffres consécutifs ou plus.
Réponse : grep '[0-9][0-9][0-9]*' list.txt

17. Afficher les lignes qui contiennent '3' ou '34'.
Réponse : grep -E '34?' list.txt

18. Afficher les lignes contenant au moins un chiffre.
Réponse : grep -E '[0-9]+' list.txt

19. Afficher les lignes contenant trois ou quatre "s" consécutifs.
Réponse : grep -E 's{3,4}' list.txt

20. Afficher les lignes contenant des numéros à trois, quatre ou cinq chiffres.
Réponse : grep -E '\<[0-9]{3,5}\>' list.txt

21. Afficher les lignes contenant "Reboot", "reboot" ou "support".
Réponse : grep -E '[Rr]eboot|support' list.txt

22. Afficher les lignes contenant une lettre quelconque.
Réponse : grep '[A-Za-z]' list.txt

23. Afficher les lignes contenant un caractère non alphanumérique (espace compris).
Réponse : grep '[^0-9A-Za-z]' list.txt

24. Afficher les lignes contenant une majuscule suivie de zéro ou plus minuscules.
Réponse : grep '[A-Z][a-z]*' list.txt

25. Afficher les lignes contenant un numéro de téléphone à 3 chiffres.
Réponse : grep -E 'tel [0-9]{3}\>' list.txt