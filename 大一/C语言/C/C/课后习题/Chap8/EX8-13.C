#include <stdio.h>
void fun(int a[3][4],int b[4][5],int c[3][5])
{
	int i,j,k;
	for (i=0;i<3;i++)
		for (j=0;j<5;j++)
		{
			c[i][j]=0;
			for (k=0;k<4;k++)
				c[i][j]+=a[i][k]*b[k][j];
		}
}
void main(void) {
	int A[][4]={{1,5,2,-3},{6,0,5,4},{-1,3,2,-5}},
		B[][5]={{2,3,5,1,8},{7,2,6,-5,5},{-6,3,-8,7,2},{0,3,5,2,6}},C[3][5];
	int i,j;
	fun(A,B,C);
	for (i=0;i<3;i++)
	{
		for (j=0;j<5;j++)
			printf("%4d",C[i][j]);
		printf("\n");
	}
}