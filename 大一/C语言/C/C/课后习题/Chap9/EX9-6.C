#include <stdio.h>
void main(void) {
	int a[2][5]={1,2,3,4,5,6,7,8,9,10},(*p)[5],i,j;
	p=a;
	for (i=0;i<2;i++)
		for (j=0;j<5;j++)
			printf("%4d",*(*(p+i)+j));
	printf("\n");
}