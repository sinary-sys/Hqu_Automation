#include <stdio.h>
#define M 4
#define N 4
void main()
{
	int matrix[M][N]={{1,2,-3,4},{-6,5,0,7},{8,-9,1,0},{-2,3,0,4}};
	int row,col,sum=0;
	for (row=0;row<M;row++)
		for (col=0;col<N;col++)
			if (matrix[row][col]>0) sum+=matrix[row][col];
			else if (matrix[row][col]==0) break;
	printf("sum=%d\n",sum);
}