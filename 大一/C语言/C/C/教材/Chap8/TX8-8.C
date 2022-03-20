#include <stdio.h>
long sum(int n)
{
	if (n==1) return 1;
	else return n+sum(n-1);
}
void main()
{
	int n;
	printf("Enter n: ");
	scanf("%d",&n);
	printf("1+2+3+...+%d=%ld\n",n,sum(n));
}