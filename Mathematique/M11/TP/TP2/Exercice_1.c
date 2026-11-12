#include <stdio.h>
#include <stdbool.h>

void convertion(unsigned long num, unsigned int base);

int main(void)
{
    unsigned long numA;
    unsigned int numB;
    
    printf("Entrer un numero : ");
    scanf("%lu", &numA);
    printf("Entrer la base : ");
    scanf("%u", &numB);

    convertion(numA, numB);
    

    return 0;
}

void convertion(unsigned long num, unsigned int base) 
{
    unsigned long puissance;
    unsigned long term;

    term = 1;
    puissance = 1;

    if (num == 0)
    {
        printf("0\n");
        return;
    }

    
    

    while (puissance <= num)
    {
        puissance = puissance * base;
    }

    puissance = puissance/base;

    while (puissance != 0)
    {
        term = num / puissance;
        num = num % puissance;
        puissance = puissance / base;        
        printf("%lu", term);
    }
    printf("\n");
}