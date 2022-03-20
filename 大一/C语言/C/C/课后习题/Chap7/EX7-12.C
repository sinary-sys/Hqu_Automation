#include <stdio.h>
void main(void) {
	int a[3][4],i,j,k=0;
	unsigned int b[12];
	printf("Input twelve integers: \n");
	for (i=0;i<3;i++)
		for (j=0;j<4;j++)
		{
			scanf("%d",&a[i][j]);
			if (a[i][j]>0) b[k++]=a[i][j];
		}
	for (i=0;i<k;i++) printf("%4u",b[i]);
	printf("\n");
}