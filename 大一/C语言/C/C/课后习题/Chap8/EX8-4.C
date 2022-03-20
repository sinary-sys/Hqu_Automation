#include <stdio.h>
int fib(int n)
{
	if (n==1||n==2) return 1;
	else return fib(n-2)+fib(n-1);
}
void main()
{
	int n;
	printf("Enter n: ");
	scanf("%d",&n);
	printf("fib(%d)=%d\n",n,fib(n));
}