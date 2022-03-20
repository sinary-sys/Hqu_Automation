#include <stdio.h>
#define PI 3.14
#define S(r) PI*r*r

void main(void) {
	double r1=1.0, r2=2.0;
	double Area1=S(r1+r2);
	printf("Area=%f\n",Area1);
}