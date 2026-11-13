#include <stdio.h>

int main(int argc, char *argv[])
{
    int a = 0;
    int *ptr = NULL;
    ptr = &a;
    printf("Le adresse de a: %p\n", &a);
    printf("La valeur de a: %d\n", a);
    printf("Le addresse dant pointeur ptr : %p\n", ptr);
    printf("La valeur depointée dans ptr : %d\n", *ptr);
    printf("Le addresse de ptr : %p\n", &ptr);
    return 0;
}