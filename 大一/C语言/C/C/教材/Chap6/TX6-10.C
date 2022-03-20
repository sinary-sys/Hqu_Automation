#include <stdio.h>
void main()
{
	int row,col,num;
	for (row=1,num=1;row<=5;row++,num++)
	{
		for (col=1;col<=5-row;col++)
			printf(" ");
		for (col=1;col<=2*row-1;col++)
			printf("%d",num);
		printf("\n");
	}
	for (row=1,num=4;row<=4;row++,num--)
	{
		for (col=1;col<=row;col++)
			printf(" ");
		for (col=1;col<=9-2*row;col++)
			printf("%d",num);
		printf("\n");
	}
}