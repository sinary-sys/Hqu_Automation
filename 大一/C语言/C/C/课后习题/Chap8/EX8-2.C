#include <stdio.h>
long int sum(unsigned int n)
{
	unsigned int i;
	long result=0l;
	for (i=1;i<=n;i++) result+=i;
	return result;
}
void main()
{
	unsigned int n;
	printf("Enter n: ");
	scanf("%d",&n);
	printf("1+2+3+...+%d=%ld\n",n,sum(n));
}