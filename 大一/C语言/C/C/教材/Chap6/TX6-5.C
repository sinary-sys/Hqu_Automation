#include <stdio.h>
void main()
{
	int i,sum;
	for (i=1,sum=0;i<=100;i++)
		sum+=i;
	printf("1+2+3+...+100=%d\n",sum);
}