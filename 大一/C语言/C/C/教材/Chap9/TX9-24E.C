#include <stdio.h>
#include <stdlib.h>
void main(void) {
	int *p=(int *)malloc(sizeof(int));
	*p=100;

	free(p);
	printf("*p=%d\n",*p);
}