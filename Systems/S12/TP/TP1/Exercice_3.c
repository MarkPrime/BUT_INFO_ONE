#include <stdio.h>

void incrementEntier(int *n)
{
    *n += 1;
}

int main(int argc, char *argv[])
{
    int a = 20;
    int *ptr = &a;
    incrementEntier(ptr);
    printf("%d", *ptr);
}