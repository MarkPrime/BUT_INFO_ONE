#include <stdio.h>

void permute(char *a, char *b)
{
    char c = *a;
    *a = *b;
    *b = c;
}

int main(int argc, char *argv[])
{
    char a = 'a';
    char b = 'b';
    char *pa = &a;
    char *pb = &b;
    printf("Le chaine de caracter a et b, %c et %c\n", *pa, *pb);
    permute(pa, pb);
    printf("Apres permutation b et a, %c et %c\n", *pa, *pb);
}