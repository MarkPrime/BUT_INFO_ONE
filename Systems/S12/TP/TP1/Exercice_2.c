#include <stdio.h>

int main(int argc, char *argv[])
{
    int a = 5;
    int b = 6;
    int *ptra;
    int *ptrb;

    ptra = &a;
    ptrb = &b;

    printf("a = %d + b = %d = %d", *ptra, *ptrb, *ptra+*ptrb);
}