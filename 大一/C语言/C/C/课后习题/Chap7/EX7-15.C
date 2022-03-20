#include <stdio.h>
void main(void)
{
	int A[10],B[2][5],C[10],i,j,k=0;
	printf("Input ten integers: ");
	for (i=0;i<10;i++)	scanf("%d",&A[i]);
	for (i=0;i<2;i++)
		for (j=0;j<5;j++)
		{
			B[i][j]=A[i*5+j];
			if (B[i][j]%2==0) C[k++]=B[i][j];
		}
	for (i=0;i<k;i++) printf("%4d",C[i]);
	printf("\n");
}