#include <stdio.h>
int a;
int *fun(void) {
	return &a;
}
void main(void) {
	int *p=fun();
	printf("*p=%d\n",*p);
}