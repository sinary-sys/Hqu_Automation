#include <stdio.h>
#define N 4
void main()
{
	int a[N][N],i,j;
	printf("Input the elements of the bottom triangle of the matrix: \n");
	for (i=0;i<N;i++)
		for (j=0;j<=i;j++)
		{
			scanf("%d",&a[i][j]);
			a[j][i]=a[i][j];
		}
	printf("The full matrix: \n");
	for (i=0;i<N;i++) {
		for (j=0;j<N;j++)
			printf("%4d",a[i][j]);
		printf("\n");
	}
}