#include <stdio.h>
#include <stdlib.h>
int a=100;
int *fun(void) {
	int *p=(int*)malloc(sizeof(int));
	*p=a+1;
	return p;
}
void main(void) {
	int *q=fun();
	printf("*q=%d\n",*q);
}