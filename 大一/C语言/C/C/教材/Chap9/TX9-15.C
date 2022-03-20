#include <stdio.h>
int a=100;
int *fun()
{
	static int b=10;
	return &b;
}
void main(void) {
	int *p=fun();
	printf("*p=%d\n",*p);

	*p=12;
	printf("*fun()=%d\n",*fun());
}