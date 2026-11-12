#include <stdio.h>
#include <stdbool.h>

void convertion(unsigned long num, unsigned int base);
void comptage(unsigned int b);

int main(void)
{
//    unsigned long numA;
    unsigned int numB;
/*    
    printf("Entrer un numero : ");
    scanf("%lu", &numA);
    printf("Entrer la base : ");
    scanf("%u", &numB);

    convertion(numA, numB);*/
    scanf("%u", &numB);

    comptage(numB);
    

    return 0;
}

void convertion(unsigned long num, unsigned int base) 
{
    unsigned long puissance;
    unsigned long term;
    char charact = 'A';


    term = 1;
    puissance = 1;

    while (puissance <= num / base)
    {
        puissance = puissance * base;
    }

    while (puissance != 0)
    {
        term = num / puissance;
        num = num % puissance;
        puissance = puissance / base;
        if (term < 10)
        {
            printf("%lu", term);
        }
        else if (term < 37)
        {
            printf("%c", (char)(term - 10 + charact));
        }
    }
    printf("\n");
}

void comptage(unsigned int b)
{
    printf("Comptage jusqu'a (100)_%u en base %u:\n", b, b);
    for (unsigned long  i = 0; i <= b * b; i++)
    {
        printf("%lu : \t", i);
        convertion(i, b);
    }
    
}