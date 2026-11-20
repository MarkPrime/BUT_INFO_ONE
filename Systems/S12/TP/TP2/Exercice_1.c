#include <stdio.h>
#include <stdlib.h>

int main(int argc, char *argv[])
{
    int *integer = malloc(sizeof(int));
    float *floatant = malloc(sizeof(float));
    char *character = malloc(sizeof(char));

    printf("Saisie la valeur int :\n");
    scanf("%d", integer);
    printf("Saisie la valeur float :\n");
    scanf("%f", floatant);
    printf("Saisie la valeur char :\n");
    scanf(" %c", character);

    printf("La valeur de saisie pour int : %d\n", *integer);
    printf("La valeur de saisie pour float : %f\n", *floatant);
    printf("La valeur de saisie pour char : %c\n", *character);

    printf("La talle de int : %zu\n", sizeof(*integer));
    printf("La talle de float : %zu\n", sizeof(*floatant));
    printf("La talle de char : %zu\n", sizeof(*character));

    free(integer);
    integer = NULL;
    free(floatant);
    floatant = NULL;
    free(character);
    character = NULL;
}