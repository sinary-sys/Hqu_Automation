#include <stdio.h>
#define LINES 10
void main()
{
	int row,col;
	for (row=1;row<=LINES;row++)
	{
		for (col=1;col<=LINES-row;col++)
			printf(" ");
		for (col=1;col<=2*row-1;col++)
			printf("*");
		printf("\n");
	}
}