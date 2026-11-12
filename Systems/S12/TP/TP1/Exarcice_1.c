#include <stdio.h>

int main(int argc, char *argv[])
{
    int nb; /* declaration de nb */
    scanf("%d", &nb); /* demande un nombre a utilisateur */

    int *ptr_nb = NULL; /* declaration de pointeur */
    ptr_nb = &nb; /* pointeur point vers variable nb */

    *ptr_nb = *ptr_nb + 10; /* ajouter la valeur dans la variable nb via le pointeur */
    return 0;
}