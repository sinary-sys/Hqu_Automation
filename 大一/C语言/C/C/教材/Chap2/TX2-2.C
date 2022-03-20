#include <stdio.h>
void main()
{
	int a=100,b=200,t;
	t=a;
	a=b;
	b=t;
	printf("After swap: \n");
	printf("a=%d,b=%d\n",a,b);
}