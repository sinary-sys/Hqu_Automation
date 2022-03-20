#include <stdio.h>
void main()
{
	int i=1,sum=0;
	while (i<=100)
		sum+=i++;
	printf("1+2+3+...+100=%d\n",sum);
}