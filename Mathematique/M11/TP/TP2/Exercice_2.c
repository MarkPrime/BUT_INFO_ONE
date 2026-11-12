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
    char dix = 'A';
/*    char onze = 'B';
    char douze = 'C';
    char treze = 'D';
    char quateurze = 'E';
    char quanze = 'F';*/


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
        //printf("%lu\n" ,puissance);
    }

    puissance = puissance/base;

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
            printf("%c", (char)(term - 10 + dix));
        }
        
        
/*       if (base > 9 && base <= 16)
        {
            if (term == 10)
            {
                printf("%c", dix);
            }
            else if (term == 11)
            {
                printf("%c", onze);
            }
            else if (term == 12)
            {
                printf("%c", douze);
            }
            else if (term == 13)
            {
                printf("%c", treze);
            }
            else if (term == 14)
            {
                printf("%c", quateurze);
            }
            else if (term == 15)
            {
                printf("%c", quanze);
            }
            else if (term <= 9)
            {
                printf("%lu", term);
            }
        }*/
    }
    printf("\n");
}