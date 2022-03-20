#include <stdio.h>
void series_start(int seed);
int series(int diff);
void main()
{
	int num;
	series_start(10);
	for (num=1;num<=10;num++)
		printf("%4d",series(5));
}