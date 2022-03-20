#include <stdio.h>
void pattern(int n) {
	int i;
	if (n==1) printf("%-3d\n",n);
	else {
		pattern(n-1);
		for (i=1;i<=n;i++) printf("%-3d",i);
		printf("\n");
	}
}
void main()
{
	int n;
	printf("Enter the number of lines: ");
	scanf("%d",&n);
	pattern(n);
}