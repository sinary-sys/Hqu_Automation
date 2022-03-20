#include <stdio.h>
void main()
{
	int n,nabs;
	printf("Input an integer: ");
	scanf("%d",&n);
	nabs=n;
	if (nabs<0) nabs=-nabs;
	printf("The absolute value of %d is %d.\n",n,nabs);
}