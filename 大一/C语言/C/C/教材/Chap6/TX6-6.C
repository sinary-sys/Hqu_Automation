#include <stdio.h>
#define N 5
void main()
{
	int row,col;
	for (row=1;row<=N;row++)
	{
		for (col=1;col<=N;col++)
			printf("*");
		printf("\n");
	}
}