#include <stdio.h>
#define M 4
#define N 3

void main()
{
	int A[M][N]={{1,2,3},{4,0,2},{1,1,0},{1,2,1}},
		B[N][N]={{1,0,1},{0,1,0},{1,0,2}},C[M][N],i,j,k;
	for (i=0;i<M;i++)
		for (j=0;j<N;j++)
		{
			C[i][j]=0;
			for (k=0;k<N;k++)
				C[i][j]+=A[i][k]*B[k][j];
		}
	for (i=0;i<M;i++)
	{
		for (j=0;j<N;j++)
			printf("%4d",C[i][j]);
		printf("\n");
	}
}