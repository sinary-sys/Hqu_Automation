#include <stdio.h>
#define g 9.8
void main(void) {
	float t,s;
	printf("Input the falling time of objects: ");
	scanf("%f",&t);
	s=.5*g*t*t;
	printf("s=%f\n",s);
}