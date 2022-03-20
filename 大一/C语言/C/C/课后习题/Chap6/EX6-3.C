#include <stdio.h>
void main()
{
	int i,n,sum;
	printf("Enter integer n: ");
	scanf("%d",&n);
	for (i=1,sum=0;i<=n;i++)
		sum+=i;
	printf("1+2+3+4+...+%d=%d\n",n,sum);
}