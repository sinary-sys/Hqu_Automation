#include <stdio.h>
void reverse(unsigned int n) {
	if (n<10) {
		printf("%d",n);
		return;
	}
	printf("%u",n%10);
	reverse(n/10);
}
void main()
{
	unsigned int n;
	printf("Enter a positive integer: ");
	scanf("%u",&n);
	reverse(n);
	printf("\n");
}