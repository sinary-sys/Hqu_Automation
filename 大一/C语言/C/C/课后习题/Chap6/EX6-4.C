#include <stdio.h>
void main()
{
	int i,n;
	printf("Input integer n: ");
	scanf("%d",&n);
	for (i=2;i*i<=n;i++)
		if (n%i==0) break;
	if (i*i>n) printf("%d is a prime number.\n",n);
	else printf("%d is not a prime number.\n",n);
}