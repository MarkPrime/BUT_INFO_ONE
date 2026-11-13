#include <stdio.h>

int main(int argc, char *argv[])
{
    int a;
    void *p;
    p = &a;

    double b;
    p = &b;

    double *doublePtr;
    doublePtr = p;

    double value = *p;

    int array[5];
    p = array;
    p += 1;

    int *intPtr;
    intPtr = (int *)p;

    return 0;
}