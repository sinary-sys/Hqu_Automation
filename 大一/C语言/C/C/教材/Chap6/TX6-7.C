#include <stdio.h>
void main()
{
	int n,i;
	long int item=1,sum=0;
	printf("Input integer n: ");
	scanf("%d",&n);
	for (i=1;i<=n;i++)
	{
		item*=i;
		sum+=item;
	}
	printf("1!+2!+3!+4!+...+%d!=%ld\n",n,sum);
}