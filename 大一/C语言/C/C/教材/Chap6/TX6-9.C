#include <stdio.h>
void main()
{
	int days,peaches=1;
	for (days=9;days>=1;days--)
		peaches=(peaches+1)*2;
	printf("There are %d peaches on the first day.\n",peaches);
}