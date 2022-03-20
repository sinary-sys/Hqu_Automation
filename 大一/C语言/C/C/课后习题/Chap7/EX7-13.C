#include <stdio.h>
void main(void) {
	int a[20],b[4][5],i,j;
	printf("Input twenty integers: \n");
	for (i=0;i<20;i++) scanf("%d",&a[i]);
	for (i=0;i<4;i++)
		for (j=0;j<5;j++)
			b[i][j]=a[i*5+j];
	for (i=0;i<4;i++)
	{
		for (j=0;j<5;j++)
			printf("%4d",b[i][j]);
		printf("\n");
	}
}