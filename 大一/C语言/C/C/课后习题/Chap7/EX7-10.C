#include <stdio.h>
#define N 5
void main()
{
	int pattern[N][N],row,col;
	for (row=0;row<N;row++)
	{
		pattern[row][0]=row+1;
		for (col=1;col<N;col++)
			pattern[row][col]=pattern[row][col-1]%5+1;
	}
	for (row=0;row<N;row++)
	{
		for (col=0;col<N;col++)
			printf("%3d",pattern[row][col]);
		printf("\n");
	}
}