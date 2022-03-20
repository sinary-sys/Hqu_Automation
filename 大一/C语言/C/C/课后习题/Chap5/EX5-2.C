#include <stdio.h>
void main()
{
	int n;
	printf("Input a positive integer: ");
	scanf("%d",&n);
	if (n%2) printf("%d is an odd number.\n");
	else printf("%d is an even number.\n");
}