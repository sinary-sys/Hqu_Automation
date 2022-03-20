#include <stdio.h>
void matrix_mul(int a[3][2],int b[2][4],int c[3][4])
{
	int i,j,k;
	for (i=0;i<3;i++)
		for (j=0;j<4;j++)
		{
			c[i][j]=0;
			for (k=0;k<2;k++)
				c[i][j]+=a[i][k]*b[k][j];
		}
}
void main()
{
	int A[][2]={{1,2},{3,4},{5,6}},B[][4]={{0,1,0,1},{1,0,1,0}},C[3][4],i,j;
	matrix_mul(A,B,C);
	for (i=0;i<3;i++)
	{
		for (j=0;j<4;j++)
			printf("%3d",C[i][j]);
		printf("\n");
	}
}