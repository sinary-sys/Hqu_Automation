#include <stdio.h>
#include <stdlib.h>
void main(void) {
	int *p;
	p=(int *)malloc(sizeof(int));
	scanf("%d",p);
	printf("%d\n",*p);
	free(p);
}
