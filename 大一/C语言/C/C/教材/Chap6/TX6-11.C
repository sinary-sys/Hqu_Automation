#include <stdio.h>
const int N=5;
void main()
{
	int row,col;
	for (row=1;row<=N;row++)
	{
		for (col=1;col<=N;col++)
			printf("%3d",(row+col-1<=5)?(row+col-1):row+col-6);
		printf("\n");
	}
}