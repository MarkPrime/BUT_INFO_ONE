#include <stdio.h>

int main(int args, char *argv[])
{
    int v = 5;
    int *p, *q;
    int **pp;

    p = &v;
    pp = &p;
    *p = 7;
    q = *pp;

    return 0;
}