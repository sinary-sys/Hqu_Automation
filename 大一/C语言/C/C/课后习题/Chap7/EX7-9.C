#include <stdio.h>
#define M 4
#define N 4
void main()
{
	int A[M][N]={{1,2,3,4},{0,5,6,0},{1,0,3,2},{0,1,0,1}};
	int row,col,maxrow,maxcol;
	maxrow=maxcol=0;
	for (row=0;row<M;row++)
		for (col=0;col<N;col++)
			if (A[row][col]>A[maxrow][maxcol])
			{
				maxrow=row;
				maxcol=col;
			}
	printf("The maximum element of array A is %d at row %d col %d.\n",
	A[maxrow][maxcol],maxrow+1,maxcol+1);
}