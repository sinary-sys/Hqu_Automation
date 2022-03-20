#include <stdio.h>
long int sum(unsigned int n)
{
	if (n==1) return 1;
	return n+sum(n-1);
}
void main(void)
{
	int n;
	printf("Input an integer: ");
	scanf("%d",&n);
	printf("1+2+3+...+%d=%ld\n",n,sum(n));
}