#include <stdio.h>
#include <stdlib.h>
void *fun(void) {
	int *p=(int*)malloc(sizeof(int));
	return p;
}

void main(void) {
	int *p=(int *)fun();
	*p=100;
	printf("*p=%d\n",*p);
}