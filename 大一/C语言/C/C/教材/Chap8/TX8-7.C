#include <stdio.h>
long fact(int n)
{
	if (n==0 || n==1) return 1l;
	else return n*fact(n-1);
}
void main()
{
	int n;
	printf("Enter n: ");
	scanf("%d",&n);
	printf("%d!=%ld\n",n,fact(n));
}