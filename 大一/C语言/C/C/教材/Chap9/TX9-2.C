#include <stdio.h>
void main(void) {
	const int i=20;
	int k=40;
	const int *p;
	p=&i;
	printf("*p=%d,i=%d\n",*p,i);
}