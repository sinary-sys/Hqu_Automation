#include <stdio.h>
int gcd(int m,int n)
{
	if (m%n==0) return n;
	else return gcd(n,m%n);
}
void main()
{
	int m,n;
	printf("Input two integers: ");
	scanf("%d%d",&m,&n);
	printf("gcd(%d,%d)=%d\n",m,n,gcd(m,n));
}