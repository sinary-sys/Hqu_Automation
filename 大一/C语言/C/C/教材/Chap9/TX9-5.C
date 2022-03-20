#include <stdio.h>
void main(void) {
	int a[10],k;
	int *pa=a;

	printf("Enter 10 integers: \n");

	for (k=0;k<10;k++)
		scanf("%d",pa++);
/*	pa=a+9;*/

	printf("Output: \n");
	for (--pa;pa>=a;pa--)
		printf("%-3d",*pa);
	printf("\n");
}